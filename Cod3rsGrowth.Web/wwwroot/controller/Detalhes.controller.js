sap.ui.define(
  [
    "sap/ui/core/mvc/Controller",
    "sap/ui/core/routing/History",
    "sap/ui/model/json/JSONModel",
    "sap/m/MessageToast",
  ],
  /**
   * @param {typeof import('sap/ui/core/mvc/Controller').default} Controller
   * @param {typeof import('sap/ui/core/routing/History').default} History
   * @param {typeof import('sap/ui/model/json/JSONModel').default} JSONModel
   * @param {typeof import('sap/m/MessageToast').default} MessageToast
   */
  function (Controller, History, JSONModel, MessageToast) {
    "use strict";

    return Controller.extend("sap.ui.cod3rsgrowth.controller.Detalhes", {
      onInit: async function () {
        var oRouter = this.getOwnerComponent().getRouter();

        oRouter
          .getRoute("detalhes")
          .attachPatternMatched(this._carregarPeca, this);
      },

      _carregarPeca: async function () {
        try {
          var id = window.location.href.split("/")[5];

          var oModel = new JSONModel();

          var oResourceBundle = this.getView()
            .getModel("i18n")
            .getResourceBundle();

          var resposta = await fetch(`http://localhost:5285/pecas/${id}`);

          if (resposta.status == 404) {
            this.byId("HeaderPeca").setVisible(false);
            throw oResourceBundle.getText("pecaNaoEncontrada", [id]);
          }

          if (resposta.status == 400) {
            this.byId("HeaderPeca").setVisible(false);
            throw oResourceBundle.getText("idPecaInvalido");
          }

          var peca = await resposta.json();
          oModel.setData(peca);
          this.getView().setModel(oModel);
        } catch (erro) {
          MessageToast.show(erro);
        }
      },

      aoClicarRetornaPraHome: function (oEvent) {
        var historico = History.getInstance();
        var paginaAnterior = historico.getPreviousHash();

        if (paginaAnterior !== undefined) {
          window.history.go(-1);
          return;
        }

        var oRouter = this.getOwnerComponent().getRouter();
        oRouter.navTo("home", {}, {}, true);
      },
    });
  }
);
