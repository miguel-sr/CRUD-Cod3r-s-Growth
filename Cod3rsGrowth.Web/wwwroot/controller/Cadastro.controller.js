sap.ui.define(
  [
    "sap/ui/core/mvc/Controller",
    "sap/ui/core/routing/History",
    "sap/m/MessageToast",
    "sap/ui/model/json/JSONModel",
  ],
  function (Controller, History, MessageToast, JSONModel) {
    "use strict";

    let oResourceBundle;
    let oRouter;

    return Controller.extend("sap.ui.cod3rsgrowth.controller.Cadastro", {
      onInit: function () {
        oResourceBundle = this.getOwnerComponent()
          .getModel("i18n")
          .getResourceBundle();

        oRouter = this.getOwnerComponent().getRouter();

        const stringVazia = "";

        let oModel = new JSONModel({
          categoria: stringVazia,
          nome: stringVazia,
          descricao: stringVazia,
          estoque: stringVazia,
          dataDeFabricacao: stringVazia,
        });

        this.getView().setModel(oModel, "peca");
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
        try {
          let peca = this.getView().getModel("peca").getData();

          peca.dataDeFabricacao = new Date(peca.dataDeFabricacao).toISOString();

          const response = await fetch("http://localhost:5285/pecas", {
            method: "POST",
            headers: {
              "Content-Type": "application/json",
            },
            body: JSON.stringify(peca),
          });

          let pecaCriada = await response.json();

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
