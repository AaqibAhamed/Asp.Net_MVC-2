<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UniversitySystem.Models.ViewModel.StudentCourseViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>
        <%--
        <div class="display-label">StudentId</div>
        <div class="display-field"><%: Model.StudentId %></div>--%>
        
        <div class="display-label">StudentName</div>
        <div class="display-field"><%: Model.StudentName %></div>
        
        <div class="display-label">Address</div>
        <div class="display-field"><%: Model.Address %></div>
        
        <div class="display-label">Email</div>
        <div class="display-field"><%: Model.Email %></div>
        <%--
        <div class="display-label">CourseId</div>
        <div class="display-field"><%: Model.CourseId %></div>--%>
        
        <%--<div class="display-label">CourseName</div>
        <div class="display-field"><%: Model.CourseName %></div>--%>

        <table>
            <% for (int i = 0; i < Model.AvailableCourses.Count; i++)
               { %>
            <tr>
                <td>
                   <%: Html.HiddenFor(x => Model.AvailableCourses[i].CourseId)%>
                   <%: Html.DisplayFor(it => Model.AvailableCourses[i].CourseName)%>
                </td>
                <td>
                    <%: Html.CheckBoxFor(it => Model.AvailableCourses[i].IsChecked)%>
                </td>
            </tr>
            <%} %>
            
     </table>
        
    </fieldset>
    <p>
       <%-- <%: Html.ActionLink("Edit", "Edit", new { /* id=Model.PrimaryKey */ }) %> |--%>
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

