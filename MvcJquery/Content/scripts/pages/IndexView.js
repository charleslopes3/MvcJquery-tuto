/*
* ===================================================================================
* Este código é distribuído sob os termos da licença  MS-LPL.
* ===================================================================================
*/

$(document).ready(function () {
    IndexView.PageLoad();
});

var IndexView = {

    PageLoad: function () {

        this.ConfiguraControles();

    },


    ConfiguraControles: function () {

        this.HabilitaAcoes();
    },

    HabilitaAcoes: function ()
    {
        $(".btn-create").click(function () {
            $("#modal").load("/clientes/create").attr("title", "Adicionar cliente").dialog();                
        });
   
        $(".btn-details").click(function () {
            var codigo = $(this).attr("data-codigo");
            $("#modal").load("/clientes/details/" + codigo).attr("title", "Dados do cliente").dialog();
        });
   
        $(".btn-edit").click(function () {
            var codigo = $(this).attr("data-codigo");
            $("#modal").load("/clientes/edit/" + codigo).attr("title", "Editar cliente").dialog();
        });
   
        $(".btn-delete").click(function () {
            var codigo = $(this).attr("data-codigo");
            $("#modal").load("/clientes/delete/" + codigo).attr("title", "Excluir cliente").dialog();
        });       

    }

};

