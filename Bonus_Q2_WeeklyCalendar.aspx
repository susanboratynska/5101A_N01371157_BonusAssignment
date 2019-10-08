<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bonus_Q2_WeeklyCalendar.aspx.cs" Inherits="HTTP5101A_N01371157_Bonus_Q1.Bonus_Q2_WeeklyCalendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <method="POST" action="http://sandbox.bittsdevelopment.com/humber/httpdebug/acceptdata.php">
        <section>
            <h1>Select the days of the week where you work. Select all that apply.</h1>
            <asp:CheckBoxList runat="server" ID="user_workdays">
                <asp:ListItem Text="Monday" Value="0"></asp:ListItem>
                <asp:ListItem Text="Tuesday" Value="1"></asp:ListItem>
                <asp:ListItem Text="Wednesday" Value="2"></asp:ListItem>
                <asp:ListItem Text="Thursday" Value="3"></asp:ListItem>
                <asp:ListItem Text="Friday" Value="4"></asp:ListItem>
                <asp:ListItem Text="Saturday" Value="5"></asp:ListItem>
                <asp:ListItem Text="Sunday" Value="6"></asp:ListItem>
            </asp:CheckBoxList>
            <asp:CustomValidator runat="server" ClientValidationFunction="ValidateCheckBoxList" EnableClientScript="true" Display="Dynamic" ErrorMessage="Please select at least one option." ForeColor="Red"></asp:CustomValidator>
                <script type="text/javascript">
                    function ValidateCheckBoxList(sender, args)
                        {
                        var checkBoxList = document.getElementById('<%=user_workdays.ClientID %>');
                        var checkboxes = checkBoxList.getElementsByTagName("input");
                        var isValid = false;
                        for (var i = 0; i < checkboxes.length; i++) {
                            if (checkboxes[i].checked) {
                                isValid = true;
                                break;
                            }
                        }
                        args.IsValid = isValid;
                        //SOURCE: Kahn M. (2013). ASP SNIPPITS. Date accessed: September 20, 2019. https://www.aspsnippets.com/Articles/Validate-ASPNet-CheckBoxList-at-least-one-CheckBox-checked-using-Custom-Validator.aspx?fbclid=IwAR10-3u0IfaiqB-NDo0Xx6ImiyVnUwSUXX87HWbW2JCSAQc3vXLzzUOEi3A  
                        //PURPOSE: to create a custom validator using javascript
                        //CHRISTINE: I am unable to get this custom validator to work; I was able to get it to work last week but I can't figure out why it won't this time.
                    }
                </script>                
            </section>
        <div runat="server" id="confirmation_userInput">
        </div>
        <div runat="server" id="confirmation_arrayInsertion">
        </div>
        <div runat="server" id="confirmation_schedule">
        </div>
        <section>
            <asp:Button runat="server" Text="Submit" />
        </section>
    </form>
</body>
</html>
