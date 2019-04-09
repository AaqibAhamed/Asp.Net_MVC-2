<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UniversitySystem.Models.Course>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>
       <%-- 
        <div class="display-label">CourseId</div>
        <div class="display-field"><%: Model.CourseId %></div>--%>
        
        <div class="display-label">CourseName</div>
        <div class="display-field"><%: Model.CourseName %></div>
        
        <div class="display-label">CourseCredit</div>
        <div class="display-field"><%: Model.CourseCredit %></div>
       <%-- 
        <div class="display-label">LecturerId</div>
        <div class="display-field"><%: Model.LecturerId %></div>--%>
        
    </fieldset>
    <p>

        <%: Html.ActionLink("Edit", "Edit", new { id=Model.CourseId }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

