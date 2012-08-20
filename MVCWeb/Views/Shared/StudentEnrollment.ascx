﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MVCWeb.Models.PLStudent>" %>
    <h2>Current Enrollment</h2>

    <table>
        <tr>
            <th>
            </th>
            <th>
                Course
            </th>
            <th>
                Description
            </th>
            <th>
                Year
            </th>
            <th>
                Quarter
            </th>
            <th>
                Session
            </th>
        </tr>

        <% if (Model.Enrollments != null) { %>
          <% foreach (var item in Model.Enrollments) { %>
    
              <tr>
                  <td>
                      <% if (Session["role"].ToString().Equals("student"))
                         { %>
                        <%: Html.ActionLink("Drop", "Drop", "Student", new { schedule_id = item.schedule_id }, null)%> |
                      <% } %>
                  </td>

                  <td>
                      <%: item.course_title %>
                  </td>
                  <td>
                      <%: item.course_description %>
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
              </tr>
    
          <% } %>
        <% } %>

    </table>
