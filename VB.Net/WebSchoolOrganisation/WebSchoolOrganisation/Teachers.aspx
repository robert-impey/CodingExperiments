<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master"
    CodeBehind="Teachers.aspx.vb" Inherits="WebSchoolOrganisation.Teachers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="addNewTeacher">
        <ul>
            <li>
                <asp:Label ID="FirstNameLabel" runat="server" Text="First Name"></asp:Label>
                <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label ID="LastNameLabel" runat="server" Text="Last Name"></asp:Label>
                <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>
            </li>
        </ul>
        <asp:Label ID="NationalityLabel" runat="server" Text="Nationality"></asp:Label>
        <asp:DropDownList ID="NationalityDropDownList" runat="server" 
            AutoPostBack="True" DataSourceID="SchoolOrganisationSqlDataSource" 
            DataTextField="Name" DataValueField="Id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SchoolOrganisationSqlDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:SchoolOrganisationConnectionString %>" 
            SelectCommand="SELECT * FROM [Country] ORDER BY [Name]"></asp:SqlDataSource>
        <p>
            <asp:Button ID="AddNewTeacherButton" runat="server" Text="Add" />
        </p>
        <p>
            <asp:Label ID="NewFullNameLabel" runat="server" Text=""></asp:Label>
        </p>
    </div>
    <asp:GridView ID="teachersGridView" runat="server">
    </asp:GridView>
</asp:Content>
