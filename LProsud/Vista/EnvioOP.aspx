<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/NavBar.Master" AutoEventWireup="true" CodeBehind="EnvioOP.aspx.cs" Inherits="LProsud.Vista.EnvioOP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div class="container" style="width: 50%;">

        <h2 style="display: unset">Envío de OP</h2>

        <hr />

        <script type="text/javascript">
            function show_confirm(event) {

                $(document).ready(function () {

                    var ref = $("#ModelPedido").modal();
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


            jQuery(document).ready(function () {

                jQuery('#ModelPedido').on('hidden.bs.modal', function (e) {
                    jQuery(this).removeData('bs.modal');
                    jQuery(this).find('.modal-content').empty();
                })

            })
        </script>
        <form class="form-horizontal" runat="server">

            <label>Mes:</label>
            <div style="width: 200px;">
                <select runat="server" id="mes" name="mes" class="form-control">
                    <option accesskey="1" value="1">Enero</option>
                    <option accesskey="2" value="2">Febrero</option>
                    <option accesskey="3" value="3">Marzo</option>
                    <option accesskey="4" value="4">Abril</option>
                    <option accesskey="5" value="5">Mayo</option>
                    <option accesskey="6" value="6">Junio</option>
                    <option accesskey="7" value="7">Julio</option>
                    <option accesskey="8" value="8">Agosto</option>
                    <option accesskey="9" value="9">Septiembre</option>
                    <option accesskey="10" value="10">Octubre</option>
                    <option accesskey="11" value="11">Noviembre</option>
                    <option accesskey="12" value="12">Diciembre</option>
                </select>
            </div>
            <div style="width: 200px;">
                <label>Numero OP:</label>
                <input type="text" runat="server" required="required" class="form-control" id="nOP"><br />
            </div>
            <div style="float: right;">

                <asp:button id="CargarArchivo"
                    class="btn btn-default"
                    runat="server"
                    text="Buscar OP"
                    onclick="AnalisisOP"
                    onserverclick="AnalisisOP"
                    xmlns:asp="#unknown" />

            </div>

            <div class="modal fade" id="ModelDetalle" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document" style="width: 50%">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Cerrar">
                                <span aria-hidden="true">&times;</span>
                            </button>
                            <h3 class="modal-title" id="exampleModalLabel">Estado:</h3>
                        </div>

                        <div class="modal-body">
                            <div class="row" style="display: flex; align-items: center; justify-content: center;">
                                <asp:Image runat="server" ID="img" ControlStyle-Width="20px" ControlStyle-Height="20px" />&nbsp;
                                <asp:Label ID="LblRespuesta" runat="server" Text=""></asp:Label><br />
                            </div>
                        </div>

                        <div class="modal-footer">
                            <asp:Button ID="BtLimpiar" CssClass="btn btn-secondary" data-dismiss="modal" runat="server" Text="Cerrar" />
                        </div>
                    </div>
                </div>
            </div>


            <div class="modal fade" id="ModelPedido" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document" style="width: 100%">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Cerrar">
                                <span aria-hidden="true">&times;</span>
                            </button>
                            <h3 class="modal-title" id="modalped">Pedido:</h3>
                        </div>

                        <div class="modal-body">

                            <div class="row" style="padding: 15px;">
                                <asp:Label class="h4" ID="IDKey" runat="server" Text="">IDKey:</asp:Label><br />
                                <asp:Label class="h4" ID="Cliente" runat="server" Text="">Cliente:</asp:Label><br />
                                <asp:Label class="h4" ID="Documento" runat="server" Text="">Documento:</asp:Label><br />
                                <asp:Label class="h4" ID="FechaPedido" runat="server" Text="">Fecha Pedido:</asp:Label><br />
                                <asp:Label class="h4" ID="FechaDespacho" runat="server" Text="">Fecha Despacho:</asp:Label><br />
                                <asp:Label class="h4" ID="NombreCli" runat="server" Text="">Nombre Cliente:</asp:Label><br />
                                <asp:Label class="h4" ID="DireccionCli" runat="server" Text="">Direccion Cliente:</asp:Label><br />
                                <asp:Label class="h4" ID="ComunaCli" runat="server" Text="">Comuna Cliente:</asp:Label><br />
                                <asp:Label class="h4" ID="RutCli" runat="server" Text="">Rut Cliente:</asp:Label><br />
                                <asp:Label class="h4" ID="TotalPosiciones" runat="server" Text="">Total Posiciones:</asp:Label><asp:TextBox ID="txtTotalPosi" TextMode="Number" runat="server" ></asp:TextBox> <asp:Button ID="BtnUPDTotales" runat="server" Text="Modificar" OnClick="BtnUPDTotales_Click"/><br />
                                <asp:Label class="h4" ID="AliasBodega" runat="server" Text="">Alias Bodega:</asp:Label><br />
                                <asp:Label class="h4" ID="Observacion" runat="server" Text="">Observacion:</asp:Label>
                            </div>
                            <hr />

                            <div>
                                <asp:GridView ID="GridItems"
                                    runat="server" AutoGenerateColumns="false" CssClass="table table-striped table-bordered table-hover" OnRowDeleting="GridItems_RowDeleting" AutoGenerateDeleteButton="true">
                                    <Columns>

                                        <asp:TemplateField>
                                            <HeaderTemplate>
                                                <asp:Label ID="lblposi" runat="server" Text="Posicion"></asp:Label>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtPosi" TextMode="Number" runat="server" Text='<%#Eval("Posi")%>'></asp:TextBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField>
                                            <HeaderTemplate>
                                                <asp:Label ID="lblHeaderSKU" runat="server" Text="SKU"></asp:Label>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtSKU" runat="server" Text='<%#Eval("Sku")%>'></asp:TextBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField>
                                            <HeaderTemplate>
                                                <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion"></asp:Label>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtDesc" runat="server" Text='<%#Eval("Desc")%>'></asp:TextBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>

                                            <HeaderTemplate>
                                                <asp:Label ID="lclCantidad" runat="server" Text="Cantidad"></asp:Label>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtCantidad" runat="server" Text='<%#Eval("Cant")%>'></asp:TextBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>

                                            <HeaderTemplate>
                                                <asp:Label ID="lblUnidad" runat="server" Text="Unidad"></asp:Label>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtUnidad" runat="server" Text='<%#Eval("Uni")%>'></asp:TextBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>

                                            <HeaderTemplate>
                                                <asp:Label ID="lblEsp" runat="server" Text="Especial"></asp:Label>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtEspecial" runat="server" Text='<%#Eval("Esp")%>'></asp:TextBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <asp:Button ID="BtnEnviar" CssClass="btn btn-secondary" runat="server" Text="Enviar" OnClick="EnvioPedido" />
                            <asp:Button ID="btnCerrar" CssClass="btn btn-secondary" data-dismiss="modal" runat="server" Text="Cerrar" />
                        </div>
                    </div>
                </div>
            </div>


        </form>
    </div>
</asp:Content>
