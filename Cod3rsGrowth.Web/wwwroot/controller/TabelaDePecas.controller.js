sap.ui.define(
  ["sap/ui/core/mvc/Controller", "sap/m/MessageToast"],
  /**
   * @param {typeof import('sap/ui/core/mvc/Controller').default} Controller
   * @param {typeof import('sap/m/MessageToast').default} MessageToast
   */
  function (Controller, MessageToast) {
    "use strict";

    return Controller.extend("sap.ui.cod3rsgrowth.controller.TabelaDePecas", {
      async onInit() {
        var teste = await fetch("http://localhost:5285/pecas");
      },
    });
  }
);
