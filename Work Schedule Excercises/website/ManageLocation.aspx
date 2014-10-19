<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManageLocation.aspx.cs" Inherits="ManageLocation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Manage Locations</h1>
    <asp:ListView ID="ListView1" runat="server" DataSourceID="LocationODS" InsertItemPosition="FirstItem" DataKeyNames="LocationID">       
        <EditItemTemplate>
            <tr class="table table-bordered">            
                <td>
                    <asp:LinkButton ID="UpdateButton" runat="server" CommandName="Update" Text="Edit" />
                    <asp:LinkButton ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                </td>
                <td>
                    <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                </td>
                <td>
                    <asp:TextBox ID="StreetTextBox" runat="server" Text='<%# Bind("Street") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ProvinceTextBox" runat="server" Text='<%# Bind("Province") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ContactTextBox" runat="server" Text='<%# Bind("Contact") %>' />
                </td>
                <td>
                    <asp:TextBox ID="PhoneTextBox" runat="server" Text='<%# Bind("Phone") %>' />
                </td>
                
                <td>
                    <asp:CheckBox ID="ActiveCheckBox" runat="server" Checked='<%# Bind("Active") %>' />
                </td>
            </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <tr style="">
                <td>
                    <asp:LinkButton ID="InsertButton" runat="server" CommandName="Insert" Text="Add" />
                </td>
                <td>
                    <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                </td>
                <td>
                    <asp:TextBox ID="StreetTextBox" runat="server" Text='<%# Bind("Street") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ProvinceTextBox" runat="server" Text='<%# Bind("Province") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ContactTextBox" runat="server" Text='<%# Bind("Contact") %>' />
                </td>
                <td>
                    <asp:TextBox ID="PhoneTextBox" runat="server" Text='<%# Bind("Phone") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="ActiveCheckBox" runat="server" Checked='<%# Bind("Active") %>' />
                </td>
            </tr>
        </InsertItemTemplate>
        <ItemTemplate>
            <tr style="">
                <td>
                    <asp:LinkButton ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>               
                <td>
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                </td>
                <td>
                    <asp:Label ID="StreetLabel" runat="server" Text='<%# Eval("Street") %>' />
                </td>
                <td>
                    <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                </td>
                <td>
                    <asp:Label ID="ProvinceLabel" runat="server" Text='<%# Eval("Province") %>' />
                </td>
                <td>
                    <asp:Label ID="ContactLabel" runat="server" Text='<%# Eval("Contact") %>' />
                </td>
                <td>
                    <asp:Label ID="PhoneLabel" runat="server" Text='<%# Eval("Phone") %>' />
                </td>
               
                <td>
                    <asp:CheckBox ID="ActiveCheckBox" runat="server" Checked='<%# Eval("Active") %>' Enabled="false" />
                </td>
            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                            <tr runat="server" style="">
                                <th runat="server"></th>
                                <th runat="server">Name</th>
                                <th runat="server">Street</th>
                                <th runat="server">City</th>
                                <th runat="server">Province</th>
                                <th runat="server">Contact</th>
                                <th runat="server">Phone</th>
                                <th runat="server">Active</th>
                            </tr>
                            <tr runat="server" id="itemPlaceholder">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="">
                        <asp:DataPager ID="DataPager1" runat="server">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                            </Fields>
                        </asp:DataPager>
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
             
    </asp:ListView>
    <asp:ObjectDataSource ID="LocationODS" runat="server" DataObjectTypeName="WorkSchedule.Entities.Location" InsertMethod="AddLocation" OldValuesParameterFormatString="original_{0}" SelectMethod="ListAllLocations" TypeName="WorkSchedule.BLL.LocationController" UpdateMethod="UpdateLocation"></asp:ObjectDataSource>
</asp:Content>

