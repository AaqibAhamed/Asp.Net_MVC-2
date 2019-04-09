<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UniversitySystem.Models.ViewModel.StudentCourseViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
           <%-- <div class="editor-label">
                <%: Html.LabelFor(model => model.StudentId) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.StudentId) %>
                <%: Html.ValidationMessageFor(model => model.StudentId) %>
            </div>--%>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.StudentName) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.StudentName) %>
                <%: Html.ValidationMessageFor(model => model.StudentName) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Address) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Address) %>
                <%: Html.ValidationMessageFor(model => model.Address) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Email) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Email) %>
                <%: Html.ValidationMessageFor(model => model.Email) %>
            </div>
            <%--
            <div class="editor-label">
                <%: Html.LabelFor(model => model.CourseId) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.CourseId) %>
                <%: Html.ValidationMessageFor(model => model.CourseId) %>
            </div>
            --%>
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
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

