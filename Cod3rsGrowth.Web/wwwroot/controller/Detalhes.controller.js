sap.ui.define(
  [
    "sap/ui/core/mvc/Controller",
    "sap/ui/core/routing/History",
    "sap/ui/model/json/JSONModel",
    "sap/m/MessageBox",
    "sap/ui/cod3rsgrowth/repositorios/Api",
  ],
  function (Controller, History, JSONModel, MessageBox, Api) {
    "use strict";

    let oResourceBundle;
    let oRouter;
    let _idPeca;

    const rotaPaginaPrincipal = "home";

    return Controller.extend("sap.ui.cod3rsgrowth.controller.Detalhes", {
      onInit: function () {
        oResourceBundle = this.getOwnerComponent()
          .getModel("i18n")
          .getResourceBundle();

        const rotaPaginaDetalhes = "detalhes";

        this._api = new Api();

        oRouter = this.getOwnerComponent().getRouter();

        oRouter
          .getRoute(rotaPaginaDetalhes)
          .attachPatternMatched(this._renderizarPecaNaTela, this);
      },

      _renderizarPecaNaTela: function (oEvent) {
        _idPeca = oEvent.getParameter("arguments").id;

        this._processarEvento(async () => {
          try {
            const idComponentePeca = "HeaderPeca";

            this.byId(idComponentePeca).setVisible(false);

            let oModel = new JSONModel();

            const peca = await this._api.carregarPecaComId(_idPeca);

            this.byId(idComponentePeca).setVisible(true);

            oModel.setData(peca);

            this.getView().setModel(oModel);
          } catch (erro) {
            const mensagemErro = "obterPeca";
            throw new Error(oResourceBundle.getText(mensagemErro, [erro]));
          }
        });
      },

      aoClicarNavegarParaHome: function () {
        this._processarEvento(() => {
          const historico = History.getInstance();
          const paginaAnterior = historico.getPreviousHash();

          paginaAnterior
            ? window.history.go(-1)
            : oRouter.navTo(rotaPaginaPrincipal);
        });
      },

      aoClicarNavegarParaCadastro: function () {
        this._processarEvento(() => {
          const rotaPaginaCadastro = "cadastro";

          oRouter.navTo(rotaPaginaCadastro, {
            id: _idPeca,
          });
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
            if (oAction == MessageBox.Action.YES) {
              this._processarEvento(this._apagarPeca);
            }
          },
        });
      },

      _apagarPeca: async function () {
        try {
          this._api.apagarPeca(_idPeca);

          oRouter.navTo(rotaPaginaPrincipal);
        } catch (erro) {
          const mensagemErro = "deletarPeca";
          throw new Error(oResourceBundle.getText(mensagemErro, [erro]));
        }
      },

      _processarEvento: function (action) {
        const tipoDaPromise = "catch";
        const tipoBuscado = "function";

        try {
          let promise = action();
          if (promise && typeof promise[tipoDaPromise] == tipoBuscado) {
            promise.catch((error) => MessageBox.error(error.message));
          }
        } catch (error) {
          MessageBox.error(error.message);
        }
      },
    });
  }
);
