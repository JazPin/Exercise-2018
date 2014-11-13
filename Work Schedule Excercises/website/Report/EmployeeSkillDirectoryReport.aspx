<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EmployeeSkillDirectoryReport.aspx.cs" Inherits="Report_EmployeeSkillDirectoryReport" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Height="462px" Width="958px" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
        <LocalReport ReportPath="Report\EmployeeSkillDirectoryReport.rdlc">
            <DataSources>
                <rsweb:ReportDataSource Name="EmployeeSkillDirectoryDataSet" DataSourceId="EmployeeSkillDirectoryODS"></rsweb:ReportDataSource>
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
    <asp:ObjectDataSource runat="server" ID="EmployeeSkillDirectoryODS" OldValuesParameterFormatString="original_{0}" SelectMethod="GetEmployeeSkillDirectory" TypeName="WorkSchedule.BLL.EmployeeSkillDirectoryReport"></asp:ObjectDataSource>
</asp:Content>

