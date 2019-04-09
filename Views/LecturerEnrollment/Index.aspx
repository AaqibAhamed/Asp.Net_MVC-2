<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<UniversitySystem.Models.Lecturer>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Lecturer Enrollment</h2>

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
                
                <%: Html.ActionLink("Details", "Details", new { id=item.LecturerId })%> |
                <%: Html.ActionLink("Assign Course", "Create") %>
                
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

    <p>
         
    </p>

</asp:Content>

