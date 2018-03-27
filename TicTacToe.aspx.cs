using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicTacToeHW2
{
    /*This page contains Tic Tac Toe game logic. The current state of the game for a user 
     is checked by the function "Check()". The default idle time for the game is 10 minutes.
     On expiry, the user will be asked to login again if he/she tries to play the game after 10 minutes of
     expiry time.If the user is playing the game , the user session expiration time will keep on extending by 
     10 minutes.Also, if there is any activity on the page, the session expiration will extend in that case too.
     Besides, the TicTacToe page has two views:-
     1. For the unauthorized user. It asks the user to login to play the game.
     2. Game board for the authorized user.
     */
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["userId"] == null && Session["timer"] == null) //Page view when no user is logged in
            {
                container.Visible = false;
                progressText.Text = "You do not have access to this game.Please Login";
                LoginLink.Visible = true;

            }
            else  //Game resets when logged in user clicks on TicTacToe
            {
                container.Visible = true;
                progressText.Text = "Player X to play!";
                LoginLink.Visible = false;
                if (!IsPostBack)
                {

                    ViewState["x_flag"] = true;
                    ViewState["o_flag"] = false;
                    ViewState["gameOver"] = false;
                }
            }

            if (!IsPostBack)
            {
                ViewState["DefaultRefUrl"] = Request.UrlReferrer.ToString();
            }

        }

        protected void Check()  //Check the game state for potential win or tie
        {
            //Horizontol check
            if ((x_1.Visible == true && x_2.Visible == true && x_3.Visible == true) || (x_4.Visible == true && x_5.Visible == true && x_6.Visible == true) || (x_7.Visible == true && x_8.Visible == true && x_9.Visible == true))
            {
                progressText.Text = "Player X has won !! Click on TicTacToe to start new game.";
                ViewState["gameOver"] = true;
                btn1.Enabled = false;   btn1.Visible = false;
                btn2.Enabled = false;   btn2.Visible = false;
                btn3.Enabled = false;   btn3.Visible = false;
                btn4.Enabled = false;   btn4.Visible = false;
                btn5.Enabled = false;   btn5.Visible = false;
                btn6.Enabled = false;   btn6.Visible = false;
                btn7.Enabled = false;   btn7.Visible = false;
                btn8.Enabled = false;   btn8.Visible = false;
                btn9.Enabled = false;   btn9.Visible = false;

            }
            else if ((o_1.Visible == true && o_2.Visible == true && o_3.Visible == true) || (o_4.Visible == true && o_5.Visible == true && o_6.Visible == true) || (o_7.Visible == true && o_8.Visible == true && o_9.Visible == true))
            {
                progressText.Text = "Player O has won !! Click on TicTacToe to start new game.";
                ViewState["gameOver"] = true;
                btn1.Enabled = false;   btn1.Visible = false;
                btn2.Enabled = false;   btn2.Visible = false;
                btn3.Enabled = false;   btn3.Visible = false;
                btn4.Enabled = false;   btn4.Visible = false;
                btn5.Enabled = false;   btn5.Visible = false;
                btn6.Enabled = false;   btn6.Visible = false;
                btn7.Enabled = false;   btn7.Visible = false;
                btn8.Enabled = false;   btn8.Visible = false;
                btn9.Enabled = false;   btn9.Visible = false;

            }

            //Vertical check
            else if ((x_1.Visible == true && x_4.Visible == true && x_7.Visible == true) || (x_2.Visible == true && x_5.Visible == true && x_8.Visible == true) || (x_3.Visible == true && x_6.Visible == true && x_9.Visible == true))
            {
                progressText.Text = "Player X has won !! Click on TicTacToe to start new game.";
                ViewState["gameOver"] = true;
                btn1.Enabled = false;  btn1.Visible = false;
                btn2.Enabled = false;  btn2.Visible = false;
                btn3.Enabled = false;  btn3.Visible = false;
                btn4.Enabled = false;  btn4.Visible = false;
                btn5.Enabled = false;  btn5.Visible = false;
                btn6.Enabled = false;  btn6.Visible = false;
                btn7.Enabled = false;  btn7.Visible = false;
                btn8.Enabled = false;  btn8.Visible = false;
                btn9.Enabled = false;  btn9.Visible = false;

            }
            else if ((o_1.Visible == true && o_4.Visible == true && o_7.Visible == true) || (o_2.Visible == true && o_5.Visible == true && o_8.Visible == true) || (o_3.Visible == true && o_6.Visible == true && o_9.Visible == true))
            {
                progressText.Text = "Player O has won !! Click on TicTacToe to start new game.";
                ViewState["gameOver"] = true;
                btn1.Enabled = false;  btn1.Visible = false;
                btn2.Enabled = false;  btn2.Visible = false;
                btn3.Enabled = false;  btn3.Visible = false;
                btn4.Enabled = false;  btn4.Visible = false;
                btn5.Enabled = false;  btn5.Visible = false;
                btn6.Enabled = false;  btn6.Visible = false;
                btn7.Enabled = false;  btn7.Visible = false;
                btn8.Enabled = false;  btn8.Visible = false;
                btn9.Enabled = false;  btn9.Visible = false;

            }

            //Diagonal check
            else if ((x_1.Visible == true && x_5.Visible == true && x_9.Visible == true) || (x_3.Visible == true && x_5.Visible == true && x_7.Visible == true))
            {
                progressText.Text = "Player X has won !! Click on TicTacToe to start new game.";
                ViewState["gameOver"] = true;
                btn1.Enabled = false;   btn1.Visible = false;
                btn2.Enabled = false;   btn2.Visible = false;
                btn3.Enabled = false;   btn3.Visible = false;
                btn4.Enabled = false;   btn4.Visible = false;
                btn5.Enabled = false;   btn5.Visible = false;
                btn6.Enabled = false;   btn6.Visible = false;
                btn7.Enabled = false;   btn7.Visible = false;
                btn8.Enabled = false;   btn8.Visible = false;
                btn9.Enabled = false;   btn9.Visible = false;

            }
            else if ((o_1.Visible == true && o_5.Visible == true && o_9.Visible == true) || (o_3.Visible == true && o_5.Visible == true && o_7.Visible == true))
            {
                progressText.Text = "Player O has won !! Click on TicTacToe to start new game.";
                ViewState["gameOver"] = true;
                btn1.Enabled = false;   btn1.Visible = false;
                btn2.Enabled = false;   btn2.Visible = false;
                btn3.Enabled = false;   btn3.Visible = false;
                btn4.Enabled = false;   btn4.Visible = false;
                btn5.Enabled = false;   btn5.Visible = false;
                btn6.Enabled = false;   btn6.Visible = false;
                btn7.Enabled = false;   btn7.Visible = false;
                btn8.Enabled = false;   btn8.Visible = false;
                btn9.Enabled = false;   btn9.Visible = false;

            }
            else
            {
                if(btn1.Enabled == false && btn2.Enabled == false && btn3.Enabled == false && btn4.Enabled == false && btn5.Enabled == false && btn6.Enabled == false && btn7.Enabled == false && btn8.Enabled == false && btn9.Enabled == false)
                {
                    progressText.Text = "The game tied ! Click on TicTacToe to play again";
                    ViewState["gameOver"] = true;
                }
            }

        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            if (Session["timer"] != null)
            {
                if (DateTime.Now.CompareTo(Session["timer"]) < 0)
                {
                    Session["timer"] = DateTime.Now.AddMinutes(10);
                    btn1.Enabled = false;
                    btn1.Visible = false;

                    if ((bool)ViewState["x_flag"] == true)
                    {
                        x_1.Visible = true;
                        Check();
                        ViewState["x_flag"] = false;
                        ViewState["o_flag"] = true;

                        if (!(bool)ViewState["gameOver"])
                        {
                            progressText.Text = "Player O to play!";
                        }
                    }
                    else
                    {
                        o_1.Visible = true;
                        Check();
                        ViewState["x_flag"] = true;
                        ViewState["o_flag"] = false;

                        if (!(bool)ViewState["gameOver"])
                        {
                            progressText.Text = "Player X to play!";
                        }
                    }
                }
                else  //User session expired
                {
                    Session.Remove("UserId");  //Remove the userId from server memory.
                    Session.Remove("timer");  // Remover the timer for the user session expiration from the server memory.
                    Response.Redirect("TicTacToe.aspx");
                }
            }
        }

        protected void Btn2_Click(object sender, EventArgs e)
        {
            if (Session["timer"] != null)
            {
                if (DateTime.Now.CompareTo(Session["timer"]) < 0)
                {
                    Session["timer"] = DateTime.Now.AddMinutes(10);
                    btn2.Enabled = false;
                    btn2.Visible = false;
                    if ((bool)ViewState["x_flag"] == true)
                    {
                        x_2.Visible = true;
                        Check();
                        ViewState["x_flag"] = false;
                        ViewState["o_flag"] = true;
                        if (!(bool)ViewState["gameOver"])
                        {
                            progressText.Text = "Player O to play!";
                        }

                    }
                    else
                    {
                        o_2.Visible = true;
                        Check();
                        ViewState["x_flag"] = true;
                        ViewState["o_flag"] = false;
                        if (!(bool)ViewState["gameOver"])
                        {
                            progressText.Text = "Player X to play!";
                        }
                    }
                }
                else  //User session expired
                {
                    Session.Remove("UserId");  //Remove the userId from server memory.
                    Session.Remove("timer");  // Remover the timer for the user session expiration from the server memory.
                    Response.Redirect("TicTacToe.aspx");
                }
            }
        }

        protected void Btn3_Click(object sender, EventArgs e)
        {
            if (Session["timer"] != null)
            {
                if (DateTime.Now.CompareTo(Session["timer"]) < 0)
                {
                    Session["timer"] = DateTime.Now.AddMinutes(10);
                    btn3.Enabled = false;
                    btn3.Visible = false;
                    if ((bool)ViewState["x_flag"] == true)
                    {
                        x_3.Visible = true;
                        Check();
                        ViewState["x_flag"] = false;
                        ViewState["o_flag"] = true;
                        if (!(bool)ViewState["gameOver"])
                        {
                            progressText.Text = "Player O to play!";
                        }

                    }
                    else
                    {
                        o_3.Visible = true;
                        Check();
                        ViewState["x_flag"] = true;
                        ViewState["o_flag"] = false;
                        if (!(bool)ViewState["gameOver"])
                        {
                            progressText.Text = "Player X to play!";
                        }
                    }
                }
                else  //User session Expired
                {
                    Session.Remove("UserId");  //Remove the userId from server memory.
                    Session.Remove("timer");  // Remover the timer for the user session expiration from the server memory.
                    Response.Redirect("TicTacToe.aspx");
                }
            }
        }

        protected void Btn4_Click(object sender, EventArgs e)
        {
            if (Session["timer"] != null)
            {
                if (DateTime.Now.CompareTo(Session["timer"]) < 0)
                {
                    Session["timer"] = DateTime.Now.AddMinutes(10);
                    btn4.Enabled = false;
                    btn4.Visible = false;
                    if ((bool)ViewState["x_flag"] == true)
                    {
                        x_4.Visible = true;
                        Check();
                        ViewState["x_flag"] = false;
                        ViewState["o_flag"] = true;
                        if (!(bool)ViewState["gameOver"])
                        {
                            progressText.Text = "Player O to play!";
                        }

                    }
                    else
                    {
                        o_4.Visible = true;
                        Check();
                        ViewState["x_flag"] = true;
                        ViewState["o_flag"] = false;
                        if (!(bool)ViewState["gameOver"])
                        {
                            progressText.Text = "Player X to play!";
                        }
                    }
                }
                else //User session Expired
                {
                    Session.Remove("UserId");  //Remove the userId from server memory.
                    Session.Remove("timer");  // Remover the timer for the user session expiration from the server memory.
                    Response.Redirect("TicTacToe.aspx");
                }
            }
        }

        protected void Btn5_Click(object sender, EventArgs e)
        {
            if (Session["timer"] != null)
            {
                if (DateTime.Now.CompareTo(Session["timer"]) < 0)
                {
                    Session["timer"] = DateTime.Now.AddMinutes(10);
                    btn5.Enabled = false;
                    btn5.Visible = false;
                    if ((bool)ViewState["x_flag"] == true)
                    {
                        x_5.Visible = true;
                        Check();
                        ViewState["x_flag"] = false;
                        ViewState["o_flag"] = true;
                        if (!(bool)ViewState["gameOver"])
                        {
                            progressText.Text = "Player O to play!";
                        }
                    }
                    else
                    {
                        o_5.Visible = true;
                        Check();
                        ViewState["x_flag"] = true;
                        ViewState["o_flag"] = false;
                        if (!(bool)ViewState["gameOver"])
                        {
                            progressText.Text = "Player X to play!";
                        }
                    }
                }
                else  //User session expired
                {
                    Session.Remove("UserId");  //Remove the userId from server memory.
                    Session.Remove("timer");  // Remover the timer for the user session expiration from the server memory.
                    Response.Redirect("TicTacToe.aspx");
                }
            }
        }

        protected void Btn6_Click(object sender, EventArgs e)
        {
            if (Session["timer"] != null)
            {
                if (DateTime.Now.CompareTo(Session["timer"]) < 0)
                {
                    Session["timer"] = DateTime.Now.AddMinutes(10);
                    btn6.Enabled = false;
                    btn6.Visible = false;
                    if ((bool)ViewState["x_flag"] == true)
                    {
                        x_6.Visible = true;
                        Check();
                        ViewState["x_flag"] = false;
                        ViewState["o_flag"] = true;
                        if (!(bool)ViewState["gameOver"])
                        {
                            progressText.Text = "Player O to play!";
                        }
                    }
                    else
                    {
                        o_6.Visible = true;
                        Check();
                        ViewState["x_flag"] = true;
                        ViewState["o_flag"] = false;
                        if (!(bool)ViewState["gameOver"])
                        {
                            progressText.Text = "Player X to play!";
                        }
                    }
                }
                else //User session Expired
                {
                    Session.Remove("UserId");  //Remove the userId from server memory.
                    Session.Remove("timer");  // Remover the timer for the user session expiration from the server memory.
                    Response.Redirect("TicTacToe.aspx");
                }
            }
        }

        protected void Btn7_Click(object sender, EventArgs e)
        {
            if (Session["timer"] != null)
            {
                if (DateTime.Now.CompareTo(Session["timer"]) < 0)
                {
                    Session["timer"] = DateTime.Now.AddMinutes(10);
                    btn7.Enabled = false;
                    btn7.Visible = false;
                    if ((bool)ViewState["x_flag"] == true)
                    {
                        x_7.Visible = true;
                        Check();
                        ViewState["x_flag"] = false;
                        ViewState["o_flag"] = true;
                        if (!(bool)ViewState["gameOver"])
                        {
                            progressText.Text = "Player O to play!";
                        }
                    }
                    else
                    {
                        o_7.Visible = true;
                        Check();
                        ViewState["x_flag"] = true;
                        ViewState["o_flag"] = false;
                        if (!(bool)ViewState["gameOver"])
                        {
                            progressText.Text = "Player X to play!";
                        }
                    }
                }
                else //User session expired
                {
                    Session.Remove("UserId");  //Remove the userId from server memory.
                    Session.Remove("timer");  // Remover the timer for the user session expiration from the server memory.
                    Response.Redirect("TicTacToe.aspx");
                }
            }
        }

        protected void Btn8_Click(object sender, EventArgs e)
        {
            if (Session["timer"] != null)
            {
                if (DateTime.Now.CompareTo(Session["timer"]) < 0)
                {
                    Session["timer"] = DateTime.Now.AddMinutes(10);
                    btn8.Enabled = false;
                    btn8.Visible = false;
                    if ((bool)ViewState["x_flag"] == true)
                    {
                        x_8.Visible = true;
                        Check();
                        ViewState["x_flag"] = false;
                        ViewState["o_flag"] = true;
                        if (!(bool)ViewState["gameOver"])
                        {
                            progressText.Text = "Player O to play!";
                        }

                    }
                    else
                    {
                        o_8.Visible = true;
                        Check();
                        ViewState["x_flag"] = true;
                        ViewState["o_flag"] = false;
                        if (!(bool)ViewState["gameOver"])
                        {
                            progressText.Text = "Player X to play!";
                        }
                    }
                }
                else  //User session expired
                {
                    Session.Remove("UserId");  //Remove the userId from server memory.
                    Session.Remove("timer");  // Remover the timer for the user session expiration from the server memory.
                    Response.Redirect("TicTacToe.aspx");
                }
            }
        }

        protected void Btn9_Click(object sender, EventArgs e)
        {
            if (Session["timer"] != null)
            {
                if (DateTime.Now.CompareTo(Session["timer"]) < 0)
                {
                    Session["timer"] = DateTime.Now.AddMinutes(10);
                    btn9.Enabled = false;
                    btn9.Visible = false;
                    if ((bool)ViewState["x_flag"] == true)
                    {
                        x_9.Visible = true;
                        Check();
                        ViewState["x_flag"] = false;
                        ViewState["o_flag"] = true;
                        if (!(bool)ViewState["gameOver"])
                        {
                            progressText.Text = "Player O to play!";
                        }
                    }
                    else
                    {
                        o_9.Visible = true;
                        Check();
                        ViewState["x_flag"] = true;
                        ViewState["o_flag"] = false;
                        if (!(bool)ViewState["gameOver"])
                        {
                            progressText.Text = "Player X to play!";
                        }
                    }
                }
                else  //User session expired
                {
                    Session.Remove("UserId");  //Remove the userId from server memory.
                    Session.Remove("timer");  // Remover the timer for the user session expiration from the server memory.
                    Response.Redirect("TicTacToe.aspx");
                }
            }
        }

        protected void About_Click(object sender, EventArgs e)
        { 
            Response.Redirect("Public.aspx");
            
        }

        protected void TicTacToe_Click(object sender, EventArgs e)
        {
            if (Session["timer"] != null)
            {
                if (DateTime.Now.CompareTo(Session["timer"]) < 0)
                {
                    Session["timer"] = DateTime.Now.AddMinutes(10);
                    ViewState["x_flag"] = true;
                    ViewState["o_flag"] = false;
                    ViewState["gameOver"] = false;

                    btn1.Enabled = true; btn1.Visible = true;
                    btn2.Enabled = true; btn2.Visible = true;
                    btn3.Enabled = true; btn3.Visible = true;
                    btn4.Enabled = true; btn4.Visible = true;
                    btn5.Enabled = true; btn5.Visible = true;
                    btn6.Enabled = true; btn6.Visible = true;
                    btn7.Enabled = true; btn7.Visible = true;
                    btn8.Enabled = true; btn8.Visible = true;
                    btn9.Enabled = true; btn9.Visible = true;

                    x_1.Visible = false; o_1.Visible = false;
                    x_2.Visible = false; o_2.Visible = false;
                    x_3.Visible = false; o_3.Visible = false;
                    x_4.Visible = false; o_4.Visible = false;
                    x_5.Visible = false; o_5.Visible = false;
                    x_6.Visible = false; o_6.Visible = false;
                    x_7.Visible = false; o_7.Visible = false;
                    x_8.Visible = false; o_8.Visible = false;
                    x_9.Visible = false; o_9.Visible = false;
                    progressText.Text = "Player X to play!";
                    Session["timer"] = DateTime.Now.AddMinutes(10);
                }
                else  //User session is expired.
                {
                    container.Visible = false;
                    progressText.Text = "You do not have access to this game.Please Login";
                }
            }
            else // Either user session expired or user is not logged in
            {
                container.Visible = false;
                progressText.Text = "You do not have access to this game.Please Login";
            }
        }

        protected void SignIn_Click(object sender, EventArgs e)
        {
            if (Session["timer"] != null)
            {
                if (DateTime.Now.CompareTo(Session["timer"]) < 0)
                {
                    
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    Session.Remove("UserId");  //Remove the userId from server memory.
                    Session.Remove("timer");  // Remover the timer for the user session expiration from the server memory.
                    Response.Redirect("Default.aspx");
                }
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}