<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pomodoro.aspx.cs" Inherits="pomodoro_webapp.Pomodoro"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="EntryID" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display.">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="EntryID" HeaderText="EntryID" ReadOnly="True" SortExpression="EntryID" />
            <asp:BoundField DataField="Timestamp" HeaderText="Timestamp" SortExpression="Timestamp" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PomodoroConnectionString1 %>" DeleteCommand="DELETE FROM [Entry] WHERE [EntryID] = @EntryID" InsertCommand="INSERT INTO [Entry] ([Timestamp], [Description]) VALUES (@Timestamp, @Description)" ProviderName="<%$ ConnectionStrings:PomodoroConnectionString1.ProviderName %>" SelectCommand="SELECT [EntryID], [Timestamp], [Description] FROM [Entry]" UpdateCommand="UPDATE [Entry] SET [Timestamp] = @Timestamp, [Description] = @Description WHERE [EntryID] = @EntryID">
        <DeleteParameters>
            <asp:Parameter Name="EntryID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Timestamp" Type="DateTime" />
            <asp:Parameter Name="Description" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Timestamp" Type="DateTime" />
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="EntryID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
