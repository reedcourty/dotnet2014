<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pomodoro.aspx.cs" Inherits="pomodoro_webapp.Pomodoro"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="EntryID" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display." BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="EntryID" HeaderText="EntryID" ReadOnly="True" SortExpression="EntryID" />
            <asp:BoundField DataField="Timestamp" HeaderText="Timestamp" SortExpression="Timestamp" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
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
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="EntryID" DataSourceID="SqlDataSource2" ForeColor="Black" GridLines="Vertical" Height="50px" OnItemUpdated="DetailsView1_ItemUpdated" Width="125px">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <Fields>
            <asp:BoundField DataField="EntryID" HeaderText="EntryID" InsertVisible="False" ReadOnly="True" SortExpression="EntryID" />
            <asp:BoundField DataField="Timestamp" HeaderText="Timestamp" ReadOnly="True" SortExpression="Timestamp" />
            <asp:TemplateField HeaderText="Description" SortExpression="Description">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Description") %>'></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="A mező nem lehet üres!"></asp:RequiredFieldValidator>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Description") %>'></asp:TextBox>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowEditButton="True" />
        </Fields>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
    </asp:DetailsView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:PomodoroConnectionString1 %>" DeleteCommand="DELETE FROM [Entry] WHERE [EntryID] = @original_EntryID AND [Timestamp] = @original_Timestamp AND [Description] = @original_Description" InsertCommand="INSERT INTO [Entry] ([Timestamp], [Description]) VALUES (@Timestamp, @Description)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Entry] WHERE ([EntryID] = @EntryID)" UpdateCommand="UPDATE [Entry] SET [Description] = @Description WHERE [EntryID] = @original_EntryID AND [Timestamp] = @original_Timestamp AND [Description] = @original_Description">
        <DeleteParameters>
            <asp:Parameter Name="original_EntryID" Type="Int32" />
            <asp:Parameter Name="original_Timestamp" Type="DateTime" />
            <asp:Parameter Name="original_Description" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Timestamp" Type="DateTime" />
            <asp:Parameter Name="Description" Type="String" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" DefaultValue="1" Name="EntryID" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="Description" Type="String" />
            <asp:Parameter Name="original_EntryID" Type="Int32" />
            <asp:Parameter Name="original_Timestamp" Type="DateTime" />
            <asp:Parameter Name="original_Description" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>
