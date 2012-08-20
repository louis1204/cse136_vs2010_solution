<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MVCWeb.Models.PLStudent>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	CreateStudent
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>CreateStudent</h2>

    <%= Ajax.ActionLink(
          "How many students are there right now?",
          "GetNumStudentsTotal", 
          new AjaxOptions { UpdateTargetId = "DivNumStudents" })
    %>

    <div id="DivNumStudents"></div>

    <input id="button1" type="button" value="Click for sample student (JSON query)" />

    <div id="SampleStudent"></div>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.ID) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.ID) %>
                <%: Html.ValidationMessageFor(model => model.ID) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.SSN) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.SSN) %>
                <%: Html.ValidationMessageFor(model => model.SSN) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.FirstName) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.FirstName) %>
                <%: Html.ValidationMessageFor(model => model.FirstName) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.LastName) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.LastName) %>
                <%: Html.ValidationMessageFor(model => model.LastName) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.EmailAddress) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.EmailAddress) %>
                <%: Html.ValidationMessageFor(model => model.EmailAddress) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Password) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Password) %>
                <%: Html.ValidationMessageFor(model => model.Password) %>
            </div>

            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>
    <br />

    <script type="text/javascript" src="../../Scripts/jquery-1.4.1-vsdoc.js"></script>
    <script type="text/javascript">
      $(document).ready(function () {
        $.ajaxSettings.cache = false;
        $(button1).click(function () {
          $.getJSON(
            '/Student/GetSampleStudent',
            { idx: '1' },
            function (data) {
              var info = "";
              info += "First : " + data.FirstName + "<br />";
              info += "Last: " + data.LastName + "<br />";
              info += "Email : " + data.EmailAddress + "<br />";
              info += "SSN : " + data.SSN + "<br />";
              info += "Password : " + data.Password + "<br />";

              $(SampleStudent).html(info);
            });
        });
      });

    </script>
</asp:Content>

