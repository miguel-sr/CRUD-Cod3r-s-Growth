sap.ui.define(
  ["sap/ui/core/mvc/Controller", "sap/m/MessageBox"],
  function (Controller, MessageBox) {
    "use strict";

    return Controller.extend("sap.ui.cod3rsgrowth.common.BaseController", {
      obterDadosModelo: function (nomeModelo) {
        const modelo = this.getView().getModel(nomeModelo).getData();

        return modelo;
      },

      obterRouter: function () {
        const router = this.getOwnerComponent().getRouter();
        return router;
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
    });
  }
);
