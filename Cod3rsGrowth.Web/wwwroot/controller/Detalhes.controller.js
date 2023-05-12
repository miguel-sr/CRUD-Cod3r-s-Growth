sap.ui.define(
  [
    "sap/ui/core/mvc/Controller",
    "sap/ui/core/routing/History",
    "sap/ui/model/json/JSONModel",
    "sap/m/MessageToast",
  ],
  function (Controller, History, JSONModel, MessageToast) {
    "use strict";

    let oResourceBundle;
    let oRouter;

    return Controller.extend("sap.ui.cod3rsgrowth.controller.Detalhes", {
      onInit: function () {
        oResourceBundle = this.getOwnerComponent()
          .getModel("i18n")
          .getResourceBundle();

        const rotaPaginaDetalhes = "detalhes";

        oRouter = this.getOwnerComponent().getRouter();

        oRouter
          .getRoute(rotaPaginaDetalhes)
          .attachPatternMatched(this._carregarPeca, this);
      },

      _carregarPeca: async function (oEvent) {
        const httpStatusOk = 200;
        const idComponentePeca = "HeaderPeca";
        const parametroEvento = "arguments";

        try {
          let id = oEvent.getParameter(parametroEvento).id;

          this.byId(idComponentePeca).setVisible(false);

          let oModel = new JSONModel();

          let resposta = await fetch(`http://localhost:5285/pecas/${id}`);

          if (resposta.status !== httpStatusOk) {
            throw resposta.statusText;
          }

          this.byId(idComponentePeca).setVisible(true);
          let peca = await resposta.json();

          oModel.setData(peca);

          this.getView().setModel(oModel);
        } catch (erro) {
          const mensagemErro = "obterPeca";
          MessageToast.show(oResourceBundle.getText(mensagemErro, [id, erro]));
        }
      },

      aoClicarRetornaPraHome: function () {
        const rotaPaginaPrincipal = "home";

        let historico = History.getInstance();
        let paginaAnterior = historico.getPreviousHash();

        if (paginaAnterior) {
          window.history.go(-1);
          return;
        }

        oRouter.navTo(rotaPaginaPrincipal, {}, {}, true);
      },
    });
  }
);
