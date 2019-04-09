<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UniversitySystem.Models.Lecturer>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Lecturer Registration
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <script src="/Scripts/MicrosoftAjax.js" type="text/javascript"></script>
    <script src="/Scripts/MicrosoftMvcValidation.js" type="text/javascript"></script>

     <% Html.EnableClientValidation(); %>
    <h2>Lecturer Registration</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
           
            
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
            </div>
            
            <p>
                <input type="submit" value="Register" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

