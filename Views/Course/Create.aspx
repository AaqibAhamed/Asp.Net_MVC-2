<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UniversitySystem.Models.Course>" %>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Course Registration
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <script src="/Scripts/MicrosoftAjax.js" type="text/javascript"></script>
    <script src="/Scripts/MicrosoftMvcValidation.js" type="text/javascript"></script>

    <h2>Course Registration</h2>

    <% Html.EnableClientValidation(); %>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            <%--
            <div class="editor-label">
                <%: Html.LabelFor(model => model.CourseId) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.CourseId) %>
                <%: Html.ValidationMessageFor(model => model.CourseId) %>
            </div>--%>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.CourseName) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.CourseName) %>
                <%: Html.ValidationMessageFor(model => model.CourseName) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.CourseCredit) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.CourseCredit) %>
                <%: Html.ValidationMessageFor(model => model.CourseCredit) %>
            </div>
            <%--
            <div class="editor-label">
                <%: Html.LabelFor(model => model.LecturerId) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.LecturerId) %>
                <%: Html.ValidationMessageFor(model => model.LecturerId) %>
            </div>--%>
            <br />
             <table>
            <tr>
                <td>
                    <%: Html.LabelFor(model => model.Lecturer)%>
                    <%: Html.DropDownListFor(model => model.LecturerId, new SelectList(Model.Assign, "LecturerId", "LecturerName" ), "Select a Lecturer")%>
                </td>
            </tr>
            </table>
            <br />
            <br />
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

