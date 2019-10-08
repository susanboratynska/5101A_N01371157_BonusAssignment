using System;
using System.Web.UI;

namespace HTTP5101A_N01371157_Bonus_Q1
{
    public partial class Bonus_Q1_Coordinate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    //GET AND SET VARIABLES:
                    int Xaxis = Convert.ToInt32(xaxis.Text);
                    int Yaxis = Convert.ToInt32(yaxis.Text);
                    string QuadrantNumber = "";
                    string Message = "Your selected coordinates are found in Quadrant ";

                    //QUADRANT POSSIBILITIES:
                    if (Xaxis > 0 && Yaxis > 0)
                    {
                        QuadrantNumber = Message + "I";
                    }
                    else if (Xaxis < 0 && Yaxis > 0)
                    {
                        QuadrantNumber = Message + "II";
                    }
                    else if (Xaxis < 0 && Yaxis < 0)
                    {
                        QuadrantNumber = Message + "III";
                    }
                    else if (Xaxis > 0 && Yaxis < 0)
                    {
                        QuadrantNumber = Message + "IV";
                    }

                    confirmation.InnerHtml = QuadrantNumber;

                    //TESTS:
                    //1. X = 1 ; Y = 5 (Expect: Q1)
                    //2. X = 4; Y = -10 (Expect : Q2)
                    //3. X = -1000; Y = -4 (Expect: Q3)
                    //4. X = -5; Y = 100 (Expect: Q4)
                    //5. X = 0; Y = 0 (No Message - assuming that they are non-zero for this assignment)
                    //Received anticipated results for all 5 tests
                }
            }

        }
    }
}