sap.ui.define(
  [
    "sap/ui/core/mvc/Controller",
    "sap/ui/core/routing/History",
    "sap/ui/model/json/JSONModel",
    "sap/m/MessageBox",
  ],
  function (Controller, History, JSONModel, MessageBox) {
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

          let peca = await fetch(`http://localhost:5285/pecas/${id}`).then(
            (response) => {
              if (response.status !== httpStatusOk) throw response.statusText;

              return response.json();
            }
          );

          this.byId(idComponentePeca).setVisible(true);

          oModel.setData(peca);

          this.getView().setModel(oModel);
        } catch (erro) {
          const mensagemErro = "obterPeca";
          MessageBox.error(oResourceBundle.getText(mensagemErro, [erro]), {
            onClose: function () {
              const rotaPaginaPrincipal = "home";
              oRouter.navTo(rotaPaginaPrincipal);
            },
          });
        }
      },

      aoClicarNavegarParaHome: function () {
        const rotaPaginaPrincipal = "home";

        const historico = History.getInstance();
        const paginaAnterior = historico.getPreviousHash();

        if (paginaAnterior) {
          window.history.go(-1);
          return;
        }

        paginaAnterior
          ? window.history.go(-1)
          : oRouter.navTo(rotaPaginaPrincipal);
      },

      aoClicarNavegarParaCadastro: function () {
        const rotaPaginaCadastro = "cadastro";

        const id = this.getView().getModel().getData().id;

        oRouter.navTo(rotaPaginaCadastro, {
          id: id,
        });
      },
    });
  }
);
