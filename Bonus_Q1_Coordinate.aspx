<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bonus_Q1_Coordinate.aspx.cs" Inherits="HTTP5101A_N01371157_Bonus_Q1.Bonus_Q1_Coordinate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <h1>Please select an x-axis value (whole numbers only):</h1>
                <div>
                    <asp:TextBox runat="server" ID="xaxis"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" EnableClientScript="true"  ControlToValidate="xaxis" ErrorMessage="Please enter a value." ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="xaxis" ErrorMessage="Please enter a whole number." ForeColor="Red"></asp:CompareValidator>
                    <%--REFERENCE: https://stackoverflow.com/questions/1427629/asp-net-validation-to-make-sure-textbox-has-integer-values --%>
                    <%--PURPOSE: Operator:DataTypeCheck & Type:Integer--%>
                </div>
            <h1>Please select a y-axis value:</h1>
                <div>
                    <asp:TextBox runat="server" ID="yaxis"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ControlToValidate="yaxis" ErrorMessage="Please enter a value" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="yaxis" ErrorMessage="Please enter a whole number." ForeColor="Red"></asp:CompareValidator>
                </div>
        </section>
        <div id="confirmation" runat="server">
          
        </div>
        <section>
            <asp:Button runat="server" Text="Submit" />
        </section>
    </form>
</body>
</html>
