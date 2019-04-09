<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UniversitySystem.Models.Lecturer>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>
        
       <%-- <div class="display-label">LecturerId</div>
        <div class="display-field"><%: Model.LecturerId %></div>
        --%>
        <div class="display-label">LecturerName</div>
        <div class="display-field"><%: Model.LecturerName %></div>
        
        <div class="display-label">Address</div>
        <div class="display-field"><%: Model.Address %></div>
        
    </fieldset>
    <p>

        <%: Html.ActionLink("Edit", "Edit", new { id=Model.LecturerId }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

