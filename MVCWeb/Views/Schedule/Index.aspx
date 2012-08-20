<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCWeb.Models.PLSchedule>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <% Html.RenderPartial("StudentEnrollment", ViewData["student"]); %>
    <br />
    <% using (Html.BeginForm("Index", "Schedule")) {%>
      <h2>Schedule</h2>
      <table>
          <tr>
              <th></th>
              <th>
                  Schedule ID
              </th>
              <th>
                <%: Html.DropDownList("yearFilter", (List<SelectListItem>)ViewData["YearList"], new { onchange = "this.form.submit()" })%>
              </th>
              <th>
                <%: Html.DropDownList("quarterFilter", (List<SelectListItem>)ViewData["QuarterList"], new { onchange = "this.form.submit()" })%>
              </th>
              <th>
                  Session
              </th>
              <th>
                  Course Title
              </th>
              <th>
                  Description
              </th>
          </tr>
          <% foreach (var item in Model) { %>
          <tr>
              <td>
                  <%: Html.ActionLink("Add", "Enroll", "Student", new { schedule_id = item.schedule_id }, null)%> |
              </td>
              <td>
                  <%: item.schedule_id %>
              </td>
              <td>
                  <%: item.year %>
              </td>
              <td>
                  <%: item.quarter %>
              </td>
              <td>
                  <%: item.session %>
              </td>
              <td>
                  <%: item.course_title %>
              </td>
              <td>
                  <%: item.course_description %>
              </td>
          </tr>
          <% } %>
      </table>
    <% } %>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

