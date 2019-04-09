<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<UniversitySystem.Models.Lecturer>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Lecturer List
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Lecturer List</h2>

     <p>
        <%: Html.ActionLink("Register a new Lecturer ", "Create") %>
    </p>

    <table>
        <tr>
            <th></th>
            <th>
                LecturerId
            </th>
            <th>
                LecturerName
            </th>
            <th>
                Address
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.LecturerId }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.LecturerId })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.LecturerId })%>
            </td>
            <td>
                <%: item.LecturerId %>
            </td>
            <td>
                <%: item.LecturerName %>
            </td>
            <td>
                <%: item.Address %>
            </td>
        </tr>
    
    <% } %>

    </table>

   

</asp:Content>

