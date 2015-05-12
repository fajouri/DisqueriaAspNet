<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogOn.aspx.cs" Inherits="DisqueriaAspNet.Views.LogOn" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>Log On</h2>
<p>
    Please enter your user name and password. <a id="lnkRegister" href="LogOn.aspx">Register</a> if you don't have an account.
</p>

    <div>
        <form id="Registerform" runat="server">
        <fieldset>
            <legend>Account Information</legend>

            <div class="editor-label">
                <label id="lblUserName">User name</label>
            </div>
            <div class="editor-field">
                <input type="text"  id="txtUserName" runat="server"/>
                 <asp:RequiredFieldValidator runat="server"  ControlToValidate="txtUserName"
            ErrorMessage="User ID is required."> *
        </asp:RequiredFieldValidator>
            </div>

            <div class="editor-label">
                <label id="lblPassword">Password</label>
                

            </div>
            <div class="editor-field">
                <input type="text"  id="txtPassword" runat="server"/>
                <asp:RegularExpressionValidator runat="server" display="Dynamic"
            controltovalidate="txtPassword" 
            errormessage="Password must contain one of @#$%^&*/."
            validationexpression=".*[@#$%^&*/].*" />
                <asp:RegularExpressionValidator runat="server" display="Dynamic"
            controltovalidate="txtPassword" 
            errormessage="Password must be 4-12 nonblank characters." 
            validationexpression="[^\s]{4,12}" />
            </div>

            <div class="editor-label">
                <input  type="checkbox" id="chkRememberme" runat="server" title="Remember me"/>
            </div>

            <p>
                <%--<asp:Button runat="server" Text="Whatever" OnClick="btnsubmit_Click"/>--%>
                <input type="submit" value="Log On" onclick="btnsubmit_Click" runat="server"/>
            </p>
        </fieldset>
        </form>
    </div>

</asp:Content>