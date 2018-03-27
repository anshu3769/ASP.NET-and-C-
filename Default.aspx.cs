using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicTacToeHW2
{
    /*This class contains the user authentication logic for the incoming user. When the user clicks the Login button
     * after entering the details, Login_Authenticate function is called. Depending on the scenario whether
     * the user is using the site for the first time or he/she has registered before, the authentication process
     * will take place. Upon authentication, session variables - "userId" and "timer" are set for the user session.
     * These variables will be removed on timeout that is 10 minutes for the current user or if the user logs out.
     * 
     * Besides, the Default.aspx has three views:-
     * 1. Default login view- in which the user is asked to enter the details
     * 2. View on authentication failure- in which the user is asked to enter the details again with a message of 
     * authentication failure.
     * 3. View with logout button - when the logged in user clicks on the login button.
     *
     */
    public partial class WebForm3 : System.Web.UI.Page
    {
        private static bool authentication_failure = false;  //Set when user authentication fails

        protected void Page_Load(object sender, EventArgs e)
        {
           
            if(Session["timer"] == null && Session["userId"] == null) //Page view when no user is logged in 
            {
                if (authentication_failure)  //Page view when the login credentials are not correct                        
                {
                    tryAgain.Visible = true;
                    authentication_failure = false;
                    logout.Visible = false;
                    Login.Visible = true;
                    reg_text.Visible = false;
                }

                else //Primary view of the page                                              
                {
                    logout.Visible = false;
                    Login.Visible = true;
                    SignIn.Visible = true;
                    reg_text.Visible = false;
                    tryAgain.Visible = false;
                } 
            }
            else   //Page view when some user is logged in                                         
            {
                logout.Visible = true;
                Login.Visible = false;
                SignIn.Visible = false;
                reg_text.Visible = false;
                tryAgain.Visible = false;
            } 

        }
        protected void Login_Authenticate1(object sender, AuthenticateEventArgs e)
        {
            //List of the registered users maintained in Application state.
            Application.Lock();  //Lock the application state while reading
            List<UserInfo> arryofUsers = (List<UserInfo>)Application["userList"];
            Application.UnLock(); //Unlock after using

            if (arryofUsers != null) //Check if the list is empty
            {
                int i = 0;
                for (i = 0; i < arryofUsers.Count; i++)
                {
                    if (arryofUsers[i].GetUserName().Equals(Login.UserName)) //User name is in the list
                    {
                        if (Crypto.VerifyHashedPassword(arryofUsers[i].GetPsswrd(), Login.Password))  //Password matches
                        {
                            e.Authenticated = true;

                            string uniqueId = Guid.NewGuid().ToString(); //Generate a unique ID for the authenticated user.

                            Session["userId"] = Crypto.Hash(uniqueId); //Encrypt the user session ID and save in server memory
                            Session["timer"] = DateTime.Now.AddMinutes(10); //Save the user session expiry in server memory
                            Response.Cookies["userSessionId"]["Value"] = (String)Session["userId"]; //Store the encrypted user session ID in a browser cookie
                            Response.Redirect("TicTacToe.aspx");
                            break;
                        }
                        else  //Password does not match
                        {

                            e.Authenticated = false; 
                            authentication_failure = true;
                            Response.Redirect("Default.aspx");
                        }
                    }
                    else if (i == arryofUsers.Count - 1) //Reach the end of the list. User name could not be found
                    {
                        e.Authenticated = true;
                        UserInfo obj = new UserInfo(Login.UserName, Login.Password);
                        arryofUsers.Add(obj);
                        //UserInfo.userDetails.Add(obj);

                        Application.Lock();
                        Application["userList"] = arryofUsers;
                        Application.UnLock();

                        string uniqueId = Guid.NewGuid().ToString();
                        Session["userId"] = Crypto.Hash(uniqueId);  //Encrypt the user session ID and store in server memory
                        Session["timer"] = DateTime.Now.AddMinutes(10);
                        Response.Cookies["userSessionId"]["Value"] = (String)Session["userId"]; //Store the encrypted user session ID in browser cookie
                        Response.Redirect("TicTacToe.aspx");
                       

                    }
                }
            }
            else  //List is empty. No user has registered yet.
            {
                e.Authenticated = true;
          
                UserInfo obj = new UserInfo(Login.UserName, Login.Password);
                List<UserInfo> arrOfUsers = new List<UserInfo>();
                arrOfUsers.Add(obj);
                //UserInfo.userDetails.Add(obj);

                Application.Lock();
                Application["userList"] = arrOfUsers;
                Application.UnLock();

                string uniqueId = Guid.NewGuid().ToString();
                //UserInfo.userIDList.Add(uniqueId);
                Session["userId"] = Crypto.Hash(uniqueId); //Encrypt the user session ID and store in server memory
                Session["timer"] = DateTime.Now.AddMinutes(10);

                Response.Cookies["userSessionId"]["Value"] = (String)Session["userId"]; //Store the encrypted user session id in browser cookie

                Response.Redirect("TicTacToe.aspx");
             
            }
           
        }

        protected void SignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void About_Click(object sender, EventArgs e)
        {
            Response.Redirect("Public.aspx");
        }

        protected void TicTacToe_Click(object sender, EventArgs e)
        {   
             Response.Redirect("TicTacToe.aspx");
         
        }


        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Remove("UserId");  //Remove the userId from server memory.
            Session.Remove("timer");  // Remover the timer for the user session expiration from the server memory.
            Response.Redirect("Default.aspx");
        }
    }
}
