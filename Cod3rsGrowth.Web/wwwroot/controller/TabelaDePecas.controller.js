sap.ui.define(
  [
    "sap/ui/core/mvc/Controller",
    "sap/ui/model/json/JSONModel",
    "sap/ui/model/Filter",
    "sap/ui/model/FilterOperator",
    "sap/m/MessageToast",
  ],
  /**
   * @param {typeof import('sap/ui/core/mvc/Controller').default} Controller
   * @param {typeof import('sap/ui/model/json/JSONModel').default} JSONModel
   * @param {typeof import('sap/ui/model/Filter').default} Filter
   * @param {typeof import('sap/ui/model/FilterOperator').default} FilterOperator
   *  @param {typeof import('sap/m/MessageToast').default} Dialog
   */
  function (Controller, JSONModel, Filter, FilterOperator, MessageToast) {
    "use strict";

    return Controller.extend("sap.ui.cod3rsgrowth.controller.TabelaDePecas", {
      onInit: async function () {
        try {
          var oModel = new JSONModel();

          var pecas = await (await fetch("http://localhost:5285/pecas")).json();

          oModel.setData({ pecas });

          this.getView().setModel(oModel);
        } catch (error) {
          MessageToast.show("Erro ao obter itens da tabela.");
        }
      },

      aoClicarMostrarDetalhes: async function (oEvent) {},

      aoClicarFiltrarPecas: function (oEvent) {
        var filtro = [];
        var query = oEvent.getParameter("query");

        if (query) {
          filtro.push(new Filter("nome", FilterOperator.Contains, query));
        }

        var tabelaDePecas = this.byId("listaDePecas");
        var binding = tabelaDePecas.getBinding("items");
        binding.filter(filtro);
      },
    });
  }
);
