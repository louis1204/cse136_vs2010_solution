<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MVCWeb.Models.PLStudent>" %>

<!-- note, this overrides the default rendering by MVC.  For example, DisplayName is not "First Name", it's "First".-->
<div class="display-label"><strong>Student ID</strong></div>
<div class="display-field"><%: Model.ID %></div>
        
<div class="display-label"><strong>SSN#</strong></div>
<div class="display-field"><%: Model.SSN %></div>
        
<div class="display-label"><strong>First</strong></div>
<div class="display-field"><%: Model.FirstName %></div>
        
<div class="display-label"><strong>Last</strong></div>
<div class="display-field"><%: Model.LastName %></div>
        
<div class="display-label"><strong>Email</strong></div>
<div class="display-field"><%: Model.EmailAddress %></div>
