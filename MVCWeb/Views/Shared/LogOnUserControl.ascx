<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%
  if (Session["email"] != null)
  {
%>
        Welcome <b><%: Session["email"]%></b>!
        <% using (Html.BeginForm("LogOff", "Login"))
           {%>
            <input type="submit" value="Logout" />
        <% } %>
<%
    }
    else {
%> 
        [ <%: Html.ActionLink("Log On", "Index", "Login") %> ]
<%
    }
%>
