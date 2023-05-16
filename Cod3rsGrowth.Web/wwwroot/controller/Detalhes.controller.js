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

    const rotaPaginaPrincipal = "home";

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
              oRouter.navTo(rotaPaginaPrincipal);
            },
          });
        }
      },

      aoClicarNavegarParaHome: function () {
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

      aoClicarAbrirConfirmacaoDeRemocao: function () {
        const mensagemConfirmacao = "confirmacaoApagar";
        const tituloConfirmacao = "tituloModalApagar";

        MessageBox.confirm(oResourceBundle.getText(mensagemConfirmacao), {
          icon: MessageBox.Icon.WARNING,
          title: oResourceBundle.getText(tituloConfirmacao),
          actions: [MessageBox.Action.YES, MessageBox.Action.CANCEL],
          onClose: (oAction) => {
            if (oAction == MessageBox.Action.YES) this._apagarPeca();
          },
        });
      },

      _apagarPeca: async function () {
        try {
          const httpStatusNoContent = 204;
          const id = this.getView().getModel().getData().id;

          const response = await fetch(`http://localhost:5285/pecas/${id}`, {
            method: "DELETE",
          });

          if (response.status !== httpStatusNoContent)
            throw response.statusText;

          oRouter.navTo(rotaPaginaPrincipal);
        } catch (erro) {
          const mensagemErro = "deletarPeca";
          MessageBox.error(oResourceBundle.getText(mensagemErro, [erro]));
        }
      },
    });
  }
);
