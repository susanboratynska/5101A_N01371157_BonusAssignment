<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bonus_Q3_RaffleBundle.aspx.cs" Inherits="HTTP5101A_N01371157_Bonus_Q1.Bonus_Q3_RaffleBundle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <h1>Enter the number of tickets you wish to purchase:</h1>
            <asp:TextBox runat="server" ID="userinput_ticketquantity"></asp:TextBox>
            <div>
                <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ControlToValidate="userinput_ticketquantity" ErrorMessage="Please enter the number of tickets you would like to purchase." ForeColor="Red"></asp:RequiredFieldValidator>
                <!--<asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="userinput_ticketquantity" ErrorMessage="Please enter a whole number." ForeColor="Red"></asp:CompareValidator> -->
            </div>
            <div>
                <asp:CompareValidator runat="server" ControlToValidate="userinput_ticketquantity" ValueToCompare="0" Operator="GreaterThan" Type="Integer" ErrorMessage="Come on, don't you want the chance to win a new laptop? Buy at least 1 raffle ticket in support of the HTTB! <br> Please enter a whole number." ForeColor="Red"></asp:CompareValidator>
                <!--REFERENCE:https://www.codeproject.com/Questions/548450/validationplusforplusnumberplusgreaterplusthanplus
                    PURPOSE: Originally I only had a DataTypeCheck (commented out above) but I also wanted to to ensure that the value is greater than 0 and came across this snippet code which checks both the data type and value. -->
            </div>
            <div>
                <asp:Button runat="server" Text="Submit" />
            </div>
        </section>
        <div runat="server" id="confirmation">

        </div>
    </form>
</body>
</html>
