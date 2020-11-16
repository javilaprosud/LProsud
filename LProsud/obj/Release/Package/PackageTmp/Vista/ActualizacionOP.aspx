<%@ Page Title="" Language="C#" MasterPageFile="~/Vista/NavBar.Master" AutoEventWireup="true" CodeBehind="ActualizacionOP.aspx.cs" Inherits="LProsud.Vista.ActualizacionOP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        #load {
            width: 100%;
            height: 100%;
            position: fixed;
            z-index: 99999;
            background: url("../Gif/load.gif") no-repeat center center rgba(255,255,255,255);
        }
    </style>
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

        //document.onreadystatechange=function(){
        //    var state = document.readyState
        //    if (state == 'interactive') {
        //        document.getElementById('contents').style.visibility = "hidden";
        //    }else if (state == 'complete'){
        //        setTimeout(function () {
        //            document.getElementById('interactive');
        //            document.getElementById('load').style, visibility = "hidden";
        //            document.getElementById('contents').style.visibility = "visible";
        //        }, 2000);
        //    }
        }
    </script>

    <div class="container" style="width: 50%;">
        <h2 style="display: unset">Actualización de Precios OP WEB</h2>
        <hr />
<%--        <div id="load"></div>
        <div id="contents">--%>
            <form class="form-horizontal" runat="server">

                <div style="margin: auto 0px;">

                    <asp:Button runat="server" id="BtnAc" class="btn btn-default"
                        text="Actualizar" onclick="BtnAc_Click" xmlns:asp="#unknown"/>
                    <%--<asp:button id="BtnAc"
                        runat="server"
                        class="btn btn-default"
                        text="Actualizar"
                        onclick="BtnAc_Click"
                        xmlns:asp="#unknown" />--%>
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
    <%--</div>--%>
    

</asp:Content>
