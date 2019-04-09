<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<UniversitySystem.Models.Course>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Course List
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Course List</h2>

      <p>
        <%: Html.ActionLink("Create a New Course", "Create") %>
    </p>

    <table>
        <tr>
            <th></th>
            <th>
                CourseId
            </th>
            <th>
                CourseName
            </th>
            <th>
                CourseCredit
            </th>
            <th>
                LecturerId
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.CourseId }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.CourseId })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.CourseId })%>
            </td>
            <td>
                <%: item.CourseId %>
            </td>
            <td>
                <%: item.CourseName %>
            </td>
            <td>
                <%: item.CourseCredit %>
            </td>
            <td>
                <%: item.LecturerId %>
            </td>
        </tr>
    
    <% } %>

    </table>

  

</asp:Content>

