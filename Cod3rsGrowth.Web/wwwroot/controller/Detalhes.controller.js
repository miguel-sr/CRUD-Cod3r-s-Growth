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

      _carregarPeca: function () {
        try {
          var id = window.location.href.split("/")[5];

          var oModel = new JSONModel();

          this.byId("HeaderPeca").setVisible(false);

          fetch(`http://localhost:5285/pecas/${id}`).then((resposta) => {
            if (resposta.status == 404) {
              MessageToast.show(`Peça não encontrada com ID ${id}.`);
              return;
            }

            if (resposta.status == 400) {
              MessageToast.show("ID inválido.");
              return;
            }

            this.byId("HeaderPeca").setVisible(true);
            resposta.json().then((peca) => oModel.setData(peca));
            this.getView().setModel(oModel);
          });
        } catch (erro) {
          MessageToast.show(`Erro ao obter peça. ${erro}`);
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
