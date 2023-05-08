sap.ui.define(
  [
    "sap/ui/core/mvc/Controller",
    "sap/ui/core/routing/History",
    "sap/ui/model/json/JSONModel",
  ],
  /**
   * @param {typeof import('sap/ui/core/mvc/Controller').default} Controller
   * @param {typeof import('sap/ui/core/routing/History').default} History
   * @param {typeof import('sap/ui/model/json/JSONModel').default} JSONModel
   */
  function (Controller, History, JSONModel) {
    "use strict";

    return Controller.extend("sap.ui.cod3rsgrowth.controller.Detalhes", {
      onInit: async function () {
        var oRouter = this.getOwnerComponent().getRouter();

        oRouter
          .getRoute("detalhes")
          .attachPatternMatched(this._carregarPeca, this);
      },

      _carregarPeca: function () {
        var id = window.location.href.split("/")[5];

        var oModel = new JSONModel();

        fetch(`http://localhost:5285/pecas/${id}`).then((item) =>
          item.json().then((peca) => oModel.setData(peca))
        );

        this.getView().setModel(oModel);
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
