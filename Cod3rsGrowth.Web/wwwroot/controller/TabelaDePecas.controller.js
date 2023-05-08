sap.ui.define(
  [
    "sap/ui/core/mvc/Controller",
    "sap/ui/model/json/JSONModel",
    "sap/ui/model/Filter",
    "sap/ui/model/FilterOperator",
  ],
  /**
   * @param {typeof import('sap/ui/core/mvc/Controller').default} Controller
   * @param {typeof import('sap/ui/model/json/JSONModel').default} JSONModel
   * @param {typeof import('sap/ui/model/Filter').default} Filter
   * @param {typeof import('sap/ui/model/FilterOperator').default} FilterOperator
   */
  function (Controller, JSONModel, Filter, FilterOperator) {
    "use strict";

    return Controller.extend("sap.ui.cod3rsgrowth.controller.TabelaDePecas", {
      onInit: async function () {
        var oModel = new JSONModel();

        var pecas = await (await fetch("http://localhost:5285/pecas")).json();

        oModel.setData({ pecas });

        this.getView().setModel(oModel);
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
