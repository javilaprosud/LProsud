<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/NavBar.Master" AutoEventWireup="true" CodeBehind="PaletizadosVidaUtil.aspx.cs" Inherits="LProsud.Vista.PaletizadosVidaUtil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <div class="container" style="width: 50%;">

        <h2 style="display: unset">Paletizado - Vida Útil</h2>

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

            <style type="text/css">
    #UpdatePanel1, #UpdatePanel2, #UpdateProgress1 { 
      border-right: gray 1px solid; border-top: gray 1px solid; 
      border-left: gray 1px solid; border-bottom: gray 1px solid;
    }
    #UpdatePanel1, #UpdatePanel2 { 
      width:200px; height:200px; position: relative;
      float: left; margin-left: 10px; margin-top: 10px;
     }
     #UpdateProgress1 {
      width: 400px; background-color: #FFC080; 
      bottom: 0%; left: 0px; position: absolute;
     }
    </style>


        <form class="form-horizontal" runat="server">


            <div class="panel panel-default">
                <div class="panel-heading">Archivo Datos Palletizados</div>
                <div class="panel-body">
                    <asp:fileupload id="FileUploadPalletizados" runat="server" xmlns:asp="#unknown" required />
                </div>
            </div>

            <div class="panel panel-default">
                <div class="panel-heading">Archivo Vida Util</div>
                <div class="panel-body">
                    <asp:fileupload id="FileUploadVidaUtil" runat="server" xmlns:asp="#unknown" required />
                </div>
            </div>

                <asp:ScriptManager ID="ScriptManager1" runat="server" />
    

            <div style="float: right;">

                <asp:button id="CargarArchivo"
                    class="btn btn-default"
                    runat="server"
                    text="Procesar"
                    onclick="cargarPalletizadosVidaUtil"
                    onserverclick="cargarPalletizadosVidaUtil"
                    xmlns:asp="#unknown" />

            </div>
        
            
            <div class="modal fade" id="ModelDetalle" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document" style="width: 800px">
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


        </form>
    </div>
</asp:Content>
