<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Login</h2>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Login</legend>

            <div class="editor-label">
              <%: ViewData["message"] %>
            </div>
            
            <div class="editor-label">
                User:
            </div>
            <div class="editor-field">
                <%: Html.TextBox("Email", "ichu@cs.ucsd.edu") %>
            </div>
            
            <div class="editor-label">
                Password:
            </div>
            <div class="editor-field">
                <%: Html.Password("Password", "pass1234") %>
            </div>
            <p>
                <input type="submit" value="Login" />
            </p>
        </fieldset>

    <% } %>
</asp:Content>
