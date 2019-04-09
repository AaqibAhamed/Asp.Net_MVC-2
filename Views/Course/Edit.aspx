<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UniversitySystem.Models.Course>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Fields</legend>
            
            <%--<div class="editor-label">
                <%: Html.LabelFor(model => model.CourseId) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.CourseId) %>
                <%: Html.ValidationMessageFor(model => model.CourseId) %>
            </div>
            --%>
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
            
           <%-- <div class="editor-label">
                <%: Html.LabelFor(model => model.LecturerId) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.LecturerId) %>
                <%: Html.ValidationMessageFor(model => model.LecturerId) %>
            </div>--%>
            
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

