<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UniversitySystem.Models.ViewModel.LecturerCourseViewModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script src="/Scripts/MicrosoftAjax.js" type="text/javascript"></script>
    <script src="/Scripts/MicrosoftMvcValidation.js" type="text/javascript"></script>

     <% Html.EnableClientValidation(); %>

    <h2>Create</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <%--<div class="editor-label">
                <%: Html.LabelFor(model => model.LecturerId) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.LecturerId) %>
                <%: Html.ValidationMessageFor(model => model.LecturerId) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.LecturerName) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.LecturerName) %>
                <%: Html.ValidationMessageFor(model => model.LecturerName) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Address) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Address) %>
                <%: Html.ValidationMessageFor(model => model.Address) %>
            </div>--%>

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
                <input type="submit" value="Assign" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

