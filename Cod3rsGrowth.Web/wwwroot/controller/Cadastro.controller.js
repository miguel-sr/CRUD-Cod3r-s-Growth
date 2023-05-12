sap.ui.define(
  [
    "sap/ui/core/mvc/Controller",
    "sap/ui/core/routing/History",
    "sap/m/MessageToast",
  ],
  /**
   * @param {typeof import('sap/ui/core/mvc/Controller').default} Controller
   * @param {typeof import('sap/ui/core/routing/History').default} History
   * @param {typeof import('sap/m/MessageToast').default} MessageToast
   */
  function (Controller, History, MessageToast) {
    "use strict";

    let oResourceBundle;
    let oRouter;

    return Controller.extend("sap.ui.cod3rsgrowth.controller.Cadastro", {
      onInit: function () {
        oResourceBundle = this.getOwnerComponent()
          .getModel("i18n")
          .getResourceBundle();

        oRouter = this.getOwnerComponent().getRouter();
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

      aoClicarSalvarPeca: async function () {
        const idCampoCategoria = "categoria";
        const idCampoNome = "nome";
        const idCampoDescricao = "descricao";
        const idCampoEstoque = "estoque";
        const idCampoData = "dataDeFabricacao";

        try {
          let peca = JSON.stringify({
            categoria: this.byId(idCampoCategoria).getValue(),
            nome: this.byId(idCampoNome).getValue(),
            descricao: this.byId(idCampoDescricao).getValue(),
            estoque: this.byId(idCampoEstoque).getValue(),
            dataDeFabricacao: new Date(
              this.byId(idCampoData).getDateValue()
            ).toISOString(),
          });

          const response = await fetch("http://localhost:5285/pecas", {
            method: "POST",
            headers: {
              "Content-Type": "application/json",
            },
            body: peca,
          });

          var pecaCriada = await response.json();

          const rotaPaginaDetalhes = "detalhes";

          oRouter.navTo(rotaPaginaDetalhes, {
            id: pecaCriada.id,
          });
        } catch (erro) {
          const mensagemErro = "criarPeca";
          MessageToast.show(oResourceBundle.getText(mensagemErro, [erro]));
        }
      },
    });
  }
);
