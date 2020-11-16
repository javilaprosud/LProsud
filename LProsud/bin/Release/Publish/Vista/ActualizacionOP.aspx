<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/NavBar.Master" AutoEventWireup="true" CodeBehind="ActualizacionOP.aspx.cs" Inherits="LProsud.Vista.ActualizacionOP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <div class="container" style="width: 50%;">

        <h2 style="display: unset">Actualización de Precios OP WEB</h2>

        <hr />

        <script type="text/javascript">
            function show_confirm(event) {

                $(document).ready(function () {

                    var ref = $("#ModalDetalle").modal();
                    ref = false;
                    return false;
                });
            };

            jQuery(document).ready(function () {

                jQuery('#ModalDetalle').on('hidden.bs.modal', function (e) {
                    jQuery(this).removeData('bs.modal');
                    jQuery(this).find('.modal-content').empty();
                })

            })
        </script>

        <form class="form-horizontal" runat="server">
            <div style="margin:auto 0px;">

                <asp:Button id="BtnAc"
                    runat="server"
                    Class="btn btn-default"
                    text="Actualizar"
                    OnClick="BtnAc_Click"
                    xmlns:asp="#unknown" />                    
            </div>

            <div class="modal fade" id="ModalDetalle" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document" style="width: 50%">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Cerrar">
                                <span aria-hidden="true">&times;</span>
                            </button>
                            <h3 class="modal-title" id="exampleModalLabel">Información:</h3>
                        </div>

                        <div class="modal-body">
                            <div class="row" style="display: flex; align-items: center; justify-content: center;">
                                <asp:Label ID="LblRespuesta" runat="server" Text="" Font-Size="Large"></asp:Label><br />
                            </div>
                        </div>

                        <div class="modal-footer">
                            <asp:Button ID="BtLimpiar" CssClass="btn btn-secondary" data-dismiss="modal" runat="server" Text="Cerrar" />
                        </div>
                    </div>
                </div>
            </div>

        </form>
    </div>
</asp:Content>
