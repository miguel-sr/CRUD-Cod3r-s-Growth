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
   * @param {typeof import('sap/m/MessageToast').default} MessageToast
   */
  function (Controller, JSONModel, Filter, FilterOperator, MessageToast) {
    "use strict";

    var oResourceBundle;

    return Controller.extend("sap.ui.cod3rsgrowth.controller.TabelaDePecas", {
      onInit: function () {
        oResourceBundle = this.getOwnerComponent()
          .getModel("i18n")
          .getResourceBundle();

        this._carregarPecas();
      },

      _carregarPecas: async function () {
        try {
          var oModel = new JSONModel();

          var resposta = await fetch("http://localhost:5285/pecas");

          if (resposta.status !== 200) {
            throw resposta.statusText;
          }

          var pecas = await resposta.json();

          oModel.setData({ pecas });

          this.getView().setModel(oModel);
        } catch (error) {
          MessageToast.show(
            oResourceBundle.getText("obterItensTabela", [error])
          );
        }
      },

      aoClicarMostrarDetalhes: async function (oEvent) {
        var uriDaPeca = oEvent.getSource().getBindingContext().getPath();

        var id = this.getView()
          .getModel()
          .getProperty(uriDaPeca + "/id");

        var oRouter = this.getOwnerComponent().getRouter();

        oRouter.navTo("detalhes", {
          id,
        });
      },

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
