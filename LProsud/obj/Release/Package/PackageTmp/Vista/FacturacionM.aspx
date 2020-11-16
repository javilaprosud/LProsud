<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/NavBar.Master" AutoEventWireup="true" CodeBehind="FacturacionM.aspx.cs" Inherits="LProsud.Vista.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <div class="container" style="width: 90%;">

        <h2 style="display: unset">Facturación Masiva</h2>
        <hr />


        <script type="text/javascript">
            function show_confirm(event) {

                $(document).ready(function () {

                    var ref = $("#ModelDetalle").modal();
                    ref = false;
                    return false;
                });
            };

            $(document).ready(function () {
                $(".modal").on("hidden.bs.modal", function () {
                    $(".modal-body").html("Procesando...");
                    $(this).removeData();
                });
            });

        </script>

        <form class="form-horizontal" id="form1" runat="server">
            <div class="form-group">

                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Buscar" />

            </div>

            <div class="form-group">

                <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-bordered table-hover" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" EmptyDataText="sin resultados">

                    <Columns>

                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:CheckBox ID="Checkbox_sel" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:BoundField DataField="rut" HeaderText="Rut" SortExpression="rut" >
                        <HeaderStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="razon_social" HeaderText="Razon Social" SortExpression="razon_social" >
                        <HeaderStyle Width="300px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="folio" HeaderText="Folio" SortExpression="folio" />
                        <asp:BoundField DataField="fecha" HeaderText="Fecha" SortExpression="fecha" />
                        <asp:BoundField DataField="fecha_recepcion" HeaderText="Fecha recepcion" SortExpression="fecha_recepcion" >
                        <HeaderStyle Width="180px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="fecha_acuse" HeaderText="Fecha acuse" SortExpression="fecha_acuse" >
                        <HeaderStyle Width="180px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="exento" HeaderText="Exento" SortExpression="exento" />
                        <asp:BoundField DataField="neto" HeaderText="Neto" SortExpression="neto" />
                        <asp:BoundField DataField="iva" HeaderText="Iva" SortExpression="iva" />
                        <asp:BoundField DataField="total" HeaderText="Total" SortExpression="total" />
                        <asp:BoundField DataField="dte" HeaderText="Tipo de Doc" SortExpression="dte" />

                    </Columns>
                </asp:GridView>

<%--                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:procesadorabd_desarrolloConnectionString %>" SelectCommand="SELECT [rut], [razon_social], [folio], [fecha], [fecha_recepcion], [fecha_acuse], [exento], [neto], [iva], [total], [dte] FROM [DTERecibidoSII] WHERE (([rut] LIKE '%' + @rut + '%') or ([razon_social] LIKE '%' + @razon_social + '%') or ([folio] LIKE '%' + @folio + '%') or ([fecha] LIKE '%' + @fecha + '%') or ([fecha_acuse] LIKE '%' + @fecha_acuse + '%') or ([fecha_recepcion] LIKE '%' + @fecha_recepcion + '%') or ([exento] LIKE '%' + @exento + '%') or ([neto] LIKE '%' + @neto + '%') or ([iva] LIKE '%' + @iva + '%') or ([total] LIKE '%' + @total + '%')) and fecha &gt;= '2020-08-17' and ESTADO ='PENDIENTE' and dte between 33 and 34 ORDER BY [fecha] desc">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="rut" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="razon_social" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="folio" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="fecha" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="fecha_acuse" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="fecha_recepcion" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="exento" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="neto" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="iva" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="total" PropertyName="Text" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>--%>

                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:procesadorabdConnectionString2 %>" SelectCommand="SELECT [rut], [razon_social], [folio], [fecha], [fecha_recepcion], [fecha_acuse], [exento], [neto], [iva], [total], [dte] FROM [DTERecibidoSII] WHERE (([rut] LIKE '%' + @rut + '%') or ([razon_social] LIKE '%' + @razon_social + '%') or ([folio] LIKE '%' + @folio + '%') or ([fecha] LIKE '%' + @fecha + '%') or ([fecha_acuse] LIKE '%' + @fecha_acuse + '%') or ([fecha_recepcion] LIKE '%' + @fecha_recepcion + '%') or ([exento] LIKE '%' + @exento + '%') or ([neto] LIKE '%' + @neto + '%') or ([iva] LIKE '%' + @iva + '%') or ([total] LIKE '%' + @total + '%')) and fecha &gt;= '2020-08-17' and ESTADO ='PENDIENTE' and dte between 33 and 34 ORDER BY [fecha] desc">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="rut" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="razon_social" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="folio" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="fecha" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="fecha_acuse" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="fecha_recepcion" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="exento" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="neto" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="iva" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox1" DefaultValue=" " Name="total" PropertyName="Text" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>

            </div>

            <div style="float: right;">
                <asp:button id="CargarArchivo"
                    class="btn btn-default"
                    runat="server"
                    text="Procesar"
                    onclick="proce"
                    onserverclick="proce"
                    onclientclick="return show_confirm(event)"
                    data-toggle="modal" data-target="#ModelDetalle"
                    xmlns:asp="#unknown" />
            </div>


            <div class="modal fade" id="ModelDetalle" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h3 class="modal-title" id="exampleModalLabel">Detalle del Proceso</h3>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Cerrar">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <asp:Label ID="prueba" runat="server" Text=""></asp:Label>

                          <div>
                                <asp:GridView ID="GridView2" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
                                    runat="server" AutoGenerateColumns="false" CssClass="table table-striped table-bordered table-hover">
                                    <Columns>                                        
                                        <asp:BoundField DataField="folio" HeaderText="Folio" />
                                        <asp:BoundField DataField="detalle" HeaderText="Detalle" />
                                        <asp:ImageField DataImageUrlField="estado" HeaderText="Estado" ControlStyle-Width="20px"/>
                                    </Columns>
                                </asp:GridView>
                            </div>

                        </div>
                        <div class="modal-footer">
                            <asp:Button runat="server" ID="btnCancelar" CssClass="btn btn-secondary" Text="Cerrar" data-dismiss="modal"></asp:Button>
                            <%--<asp:Button runat="server" ID="btnConfirmar" CssClass="btn btn-primary" Text="Confirmar"></asp:Button>--%>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </div>
</asp:Content>
