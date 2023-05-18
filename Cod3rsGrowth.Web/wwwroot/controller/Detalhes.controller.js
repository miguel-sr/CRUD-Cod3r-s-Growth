sap.ui.define(
  [
    "sap/ui/cod3rsgrowth/common/BaseController",
    "sap/ui/core/routing/History",
    "sap/ui/model/json/JSONModel",
    "sap/m/MessageBox",
    "sap/ui/cod3rsgrowth/repositorios/RepositorioPeca",
  ],
  function (BaseController, History, JSONModel, MessageBox, RepositorioPeca) {
    "use strict";

    let oResourceBundle;
    let oRouter;
    let _idPeca;

    return BaseController.extend("sap.ui.cod3rsgrowth.controller.Detalhes", {
      onInit: function () {
        oResourceBundle = this.carregarRecursoI18n();

        oRouter = this.pegarRouter();

        oRouter
          .getRoute(this.rotasDaAplicacao.paginaDetalhes)
          .attachPatternMatched(this._renderizarPecaNaTela, this);
      },

      _renderizarPecaNaTela: function (oEvent) {
        _idPeca = oEvent.getParameter("arguments").id;

        this.processarEvento(async () => {
          try {
            const idComponentePeca = "HeaderPeca";

            this.byId(idComponentePeca).setVisible(false);

            let oModel = new JSONModel();

            const peca = await RepositorioPeca.obterPorId(_idPeca);

            this.byId(idComponentePeca).setVisible(true);

            oModel.setData(peca);

            this.getView().setModel(oModel);
          } catch (erro) {
            const mensagemErro = "obterPeca";
            throw new Error(oResourceBundle.getText(mensagemErro, [erro]));
          }
        });
      },

      aoClicarNavegarParaPaginaAnterior: function () {
        this.processarEvento(() => {
          const historico = History.getInstance();
          const paginaAnterior = historico.getPreviousHash();

          paginaAnterior
            ? window.history.go(-1)
            : oRouter.navTo(this.rotasDaAplicacao.paginaPrincipal);
        });
      },

      aoClicarNavegarParaCadastro: function () {
        this.processarEvento(() => {
          oRouter.navTo(this.rotasDaAplicacao.paginaCadastro, {
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
              this.processarEvento(this._apagarPeca);
            }
          },
        });
      },

      _apagarPeca: async function () {
        try {
          RepositorioPeca.apagarPeca(_idPeca);

          oRouter.navTo(this.rotasDaAplicacao.paginaPrincipal);
        } catch (erro) {
          const mensagemErro = "deletarPeca";
          throw new Error(oResourceBundle.getText(mensagemErro, [erro]));
        }
      },
    });
  }
);
