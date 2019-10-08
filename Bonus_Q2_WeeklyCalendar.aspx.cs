using System;
using System.Collections.Generic;
using System.Web.UI;

namespace HTTP5101A_N01371157_Bonus_Q1
{
    public partial class Bonus_Q2_WeeklyCalendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            confirmation_schedule.InnerHtml = ""; // TO CLEAR PRINT MESSAGE WITH EACH RESUBMIT
            if (Page.IsPostBack)
                if (Page.IsPostBack)
                {
                Page.Validate();
                if (Page.IsValid)
                {
                    //GET & SET VARIABLES:

                    List<int> User_Workdays = new List<int>();
                    // REFERENCE: https://stackoverflow.com/questions/29975913/adding-a-new-element-to-the-end-of-a-c-sharp-array?fbclid=IwAR1i23P1GUsYDxABtxJMqw-j1X6RSWEG126BO-CzSYE8osfN6Il69Wi18lw
                    // PURPOSE: How to declare an array in C#

                    for (int i = 0; i < user_workdays.Items.Count; i++)
                    {

                        if (user_workdays.Items[i].Selected)
                        {
                            User_Workdays.Add(Convert.ToInt32(user_workdays.Items[i].Value));
                            // TEST BELOW: CHECK TO SEE USER INPUT
                            // confirmation_userInput.InnerHtml += user_workdays.Items[i].Value + ",";
                        }

                    }

                    // TEST BELOW: CHECK TO SEE IF THE VALUES ARE STORED IN THE ARRAY
                    //foreach (int item in User_Workdays)
                    //{
                    //        confirmation_arrayInsertion.InnerHtml += item +",";
                    //}


                    // SET VARIABLES:
                    string day = "";
                    string Funday = "Time to have fun!";
                    string Workday = "Time to work!";

                    for (int i = 0; i < 31; i++)
                    {
                        string Message = Funday;
                        int count = i; 
                        int modulus = count % 7;
                        if (modulus == 6)
                        {
                            day = "Monday";
                        }
                        else if (modulus == 0)
                        {
                            day = "Tuesday";
                        }
                        else if (modulus == 1)
                        {
                            day = "Wednesday";
                        }
                        else if (modulus == 2)
                        {
                            day = "Thursday";
                        }
                        else if (modulus == 3)
                        {
                            day = "Friday";
                        }
                        else if (modulus == 4)
                        {
                            day = "Saturday";
                        }
                        else if (modulus == 5)
                        {
                            day = "Sunday";
                        }

                        foreach (int selected_value in User_Workdays)
                        {
                            if (selected_value == (modulus + 1))
                            {
                                Message = Workday;
                            }
                        }
                        confirmation_schedule.InnerHtml += "Oct " + (i + 1) + " is a " + day + ". " + Message + "<br/>";
                    }

                }
                }



        }
    }
}