<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<UniversitySystem.Models.Student>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Student Enrollment
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Student Enrollment</h2>

    
    <p>
        <%: Html.ActionLink("Register a new Student", "Create") %>
    </p>
    <table>
        <tr>
            <th></th>
            <th>
                StudentId
            </th>
            <th>
                StudentName
            </th>
            <th>
                Address
            </th>
            <th>
                Email
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Re-Register", "Edit", new { id=item.StudentId }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.StudentId })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.StudentId })%>
            </td>
            <td>
                <%: item.StudentId %>
            </td>
            <td>
                <%: item.StudentName %>
            </td>
            <td>
                <%: item.Address %>
            </td>
            <td>
                <%: item.Email %>
            </td>
        </tr>
    
    <% } %>

    </table>


</asp:Content>

