sap.ui.define(
  ["sap/ui/core/mvc/Controller", "sap/m/MessageBox"],
  function (Controller, MessageBox) {
    "use strict";

    return Controller.extend("sap.ui.cod3rsgrowth.common.BaseController", {
      pegarDadosModeloPeca: function () {
        const nomeDoModelo = "peca";
        const peca = this.getView().getModel(nomeDoModelo).getData();

        return peca;
      },

      carregarRecursoI18n: function () {
        const oResourceBundle = this.getOwnerComponent()
          .getModel("i18n")
          .getResourceBundle();

        return oResourceBundle;
      },

      processarEvento: function (action) {
        const tipoDaPromise = "catch";
        const tipoBuscado = "function";

        try {
          let promise = action();

          if (promise && typeof promise[tipoDaPromise] == tipoBuscado) {
            promise.catch((error) => MessageBox.error(error.message));
          }

          return promise;
        } catch (error) {
          MessageBox.error(error.message);
        }
      },

      rotasDaAplicacao: {
        paginaPrincipal: "home",
        paginaCadastro: "cadastro",
        paginaDetalhes: "detalhes",
      },
    });
  }
);
