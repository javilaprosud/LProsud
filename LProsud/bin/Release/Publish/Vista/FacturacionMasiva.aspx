<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/NavBar.Master" AutoEventWireup="true" CodeBehind="FacturacionMasiva.aspx.cs" Inherits="LProsud.Vista.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">



    <form id="form1" runat="server">
        <p>
            b</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" OnClientClick="Button1_click" />
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmprCod,TdocCodigo,EquivCod" DataSourceID="SqlDataSource1" EmptyDataText="No se encontraron resultados">
                <Columns>
                    <asp:BoundField DataField="EmprCod" HeaderText="EmprCod" ReadOnly="True" SortExpression="EmprCod" />
                    <asp:BoundField DataField="TdocCodigo" HeaderText="TdocCodigo" ReadOnly="True" SortExpression="TdocCodigo" />
                    <asp:BoundField DataField="EquivCod" HeaderText="EquivCod" ReadOnly="True" SortExpression="EquivCod" />
                    <asp:BoundField DataField="EquivElec" HeaderText="EquivElec" SortExpression="EquivElec" />
                    <asp:BoundField DataField="TdocNombre" HeaderText="TdocNombre" SortExpression="TdocNombre" />
                    <asp:BoundField DataField="EquivNombre" HeaderText="EquivNombre" SortExpression="EquivNombre" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:procesadorabdConnectionString %>" SelectCommand="SELECT * FROM [EquivTiposDocto] WHERE (([EquivNombre] = @EquivNombre) AND ([TdocCodigo] = @TdocCodigo))">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" Name="EquivNombre" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" Name="TdocCodigo" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </p>
    </form>



</asp:Content>
