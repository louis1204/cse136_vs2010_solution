<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MVCWeb.Models.PLStudent>" %>
<%@ Import Namespace="MVCWeb.Models" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <!--Note, this will call the Student/DisplayTemplates/PLStudent.ascx because we created a PLStudent.ascx and customized it --> 
    <%: Html.DisplayForModel() %> 

    <% Html.RenderPartial("StudentEnrollment", Model); %>
    <p>
        <%: Html.ActionLink("Edit", "Edit", new { id=Model.ID }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

