<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UniversitySystem.Models.Student>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">StudentId</div>
        <div class="display-field"><%: Model.StudentId %></div>
        
        <div class="display-label">StudentName</div>
        <div class="display-field"><%: Model.StudentName %></div>
        
        <div class="display-label">Address</div>
        <div class="display-field"><%: Model.Address %></div>
        
        <div class="display-label">Email</div>
        <div class="display-field"><%: Model.Email %></div>
        
    </fieldset>
    <p>

        <%: Html.ActionLink("Edit", "Edit", new { id=Model.StudentId }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

