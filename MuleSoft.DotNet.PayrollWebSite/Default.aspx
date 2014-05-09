<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>MuleSoft Samples - Payroll Admin Site</h2>
        <p class="lead">&nbsp;</p>
        <p>&nbsp;</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Outstanding Time Card Records for General Ledger</h2>


            <table>
                <tr>
                    <td>Employee ID</td>
                    <td>Machine ID</td>
                    <td>Plant Name</td>
                    <td>Cost $</td>
                    <td>Status</td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="txtEmployeeID" runat="server">111111</asp:TextBox></td>
                    <td><asp:TextBox ID="txtMachineID" runat="server">1234509</asp:TextBox></td>
                    <td><asp:TextBox ID="txtPlantName" runat="server">California</asp:TextBox></td>
                    <td><asp:TextBox ID="txtCost" runat="server">9832</asp:TextBox></td>
                    <td><asp:TextBox ID="txtStatus" runat="server" ForeColor="Red">Unprocessed</asp:TextBox></td>
                </tr>

            </table>
            <br />
            
            <asp:Button ID="btnSubmit" runat="server" Text="Submit Outstanding Time Cards" OnClick="btnSubmit_Click" />
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
        </div>
        <div class="col-md-4">
            <h2>&nbsp;</h2>
            <p>
                &nbsp;</p>
        </div>
    </div>
</asp:Content>
