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

    var oResourceBundle;
    const httpStatus_OK = 200;

    return Controller.extend("sap.ui.cod3rsgrowth.controller.Detalhes", {
      onInit: function () {
        var oRouter = this.getOwnerComponent().getRouter();

        oResourceBundle = this.getOwnerComponent()
          .getModel("i18n")
          .getResourceBundle();

        oRouter
          .getRoute("detalhes")
          .attachPatternMatched(this._carregarPeca, this);
      },

      _carregarPeca: async function (oEvent) {
        try {
          var id = oEvent.getParameter("arguments").id;

          this.byId("HeaderPeca").setVisible(false);

          var oModel = new JSONModel();

          var resposta = await fetch(`http://localhost:5285/pecas/${id}`);

          if (resposta.status !== httpStatus_OK) {
            throw resposta.statusText;
          }

          this.byId("HeaderPeca").setVisible(true);
          var peca = await resposta.json();
          oModel.setData(peca);
          this.getView().setModel(oModel);
        } catch (erro) {
          MessageToast.show(oResourceBundle.getText("obterPeca", [id, erro]));
        }
      },

      aoClicarRetornaPraHome: function (oEvent) {
        var historico = History.getInstance();
        var paginaAnterior = historico.getPreviousHash();

        if (paginaAnterior) {
          window.history.go(-1);
          return;
        }

        var oRouter = this.getOwnerComponent().getRouter();
        oRouter.navTo("home", {}, {}, true);
      },
    });
  }
);
