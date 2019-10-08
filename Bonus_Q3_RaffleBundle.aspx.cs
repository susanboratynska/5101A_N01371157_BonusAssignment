using System;
using System.Web.UI;

namespace HTTP5101A_N01371157_Bonus_Q1
{
    public partial class Bonus_Q3_RaffleBundle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            confirmation.InnerHtml = ""; // TO CLEAR PRINT MESSAGE WITH EACH RESUBMIT
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    // GET & SET VARIABLES
                    int UserInput_TicketQuantity = Convert.ToInt32(userinput_ticketquantity.Text);
                    double TicketCost = 0.25; // REFERENCE: https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types-and-variables PURPOSE: TYPE OF INTEGER
                    double Cost = TicketCost * UserInput_TicketQuantity;
                    string FinalCost = Cost.ToString("0.00"); // REFERENCE: https://stackoverflow.com/questions/10749506/two-decimal-places-using-c-sharp/10749520 PURPOSE: 2 DECIMAL PLACES
                    string MessageCost = "Your total ticket(s) is " + UserInput_TicketQuantity +" and your cost is $" + FinalCost;

                    // LOGIC
                    // 1-50 TICKETS = BUNDLE OF 1
                    // 51-150 TICKETS = BUNDLE OF 2
                    // 151-300 TICKETS = BUNDLE OF 3
                    // 300 + TICKETS = BUNDLE OF 5

                    if (UserInput_TicketQuantity > 0 && UserInput_TicketQuantity <= 50)
                    {
                        for (int i = 1; i <= UserInput_TicketQuantity; i++)
                        {
                            confirmation.InnerHtml += "You received a bundle of 1 ticket. That's " + (i) + " ticket(s)! <br>";
                        }
                        if (!(UserInput_TicketQuantity % 1 == 0))
                        {
                            confirmation.InnerHtml += "Your leftover is " + (UserInput_TicketQuantity % 1) + " ticket(s)! <br>";
                        }
                        confirmation.InnerHtml += MessageCost;
                    }


                    else if (UserInput_TicketQuantity > 50 && UserInput_TicketQuantity <= 150)
                    {
                        for (int i = 1; i <= (UserInput_TicketQuantity / 2); i++)
                        {
                            confirmation.InnerHtml += "You received a bundle of 2 tickets. That's " + (i * 2) + " ticket(s)! <br>";
                        }
                        if (!(UserInput_TicketQuantity % 2 == 0))
                        {
                            confirmation.InnerHtml += "Your leftover is " + (UserInput_TicketQuantity % 2) + " ticket(s)! <br>";
                        }
                        confirmation.InnerHtml += MessageCost;
                    }


                    else if (UserInput_TicketQuantity > 150 && UserInput_TicketQuantity <= 300)
                    {
                        for (int i = 1; i <= (UserInput_TicketQuantity / 3); i++)
                        {
                            confirmation.InnerHtml += "You received a bundle of 3 tickets. That's " + (i * 3) + " ticket(s)! <br>";
                        }
                        if (!(UserInput_TicketQuantity % 3 == 0))
                        {
                            confirmation.InnerHtml += "Your leftover is " + (UserInput_TicketQuantity % 3) + " ticket(s)! <br>";
                        }
                        confirmation.InnerHtml += MessageCost;
                    }


                    else if (UserInput_TicketQuantity > 300)
                    {
                        for (int i = 1; i <= (UserInput_TicketQuantity / 5); i++)
                        {
                            confirmation.InnerHtml += "You received a bundle of 5 tickets. That's " + (i * 5) + " ticket(s)! <br>";
                        }
                        if (!(UserInput_TicketQuantity % 5 == 0))
                        {
                            confirmation.InnerHtml += "Your leftover is " + (UserInput_TicketQuantity % 5) + " ticket(s)! <br>";
                        }
                        confirmation.InnerHtml += MessageCost;
                    }
                }       //TEST:
            }           //1. 1-50 TICKETS = BUNDLE OF 1         TEST: 0, 1, 50 
                        //2. 51-150 TICKETS = BUNDLE OF 2       TEST: 51, 150
        }               //3. 151-300 TICKETS = BUNDLE OF 3      TEST: 151, 300
    }                   //4. 300 + TICKETS = BUNDLE OF 5        TEST: 301, 400

}