sap.ui.define(
  ["sap/ui/core/UIComponent", "sap/ui/model/resource/ResourceModel"],
  /**
   * @param {typeof import('sap/ui/core/UIComponent').default} UIComponent
   * @param {typeof import('sap/ui/model/resource/ResourceModel').default} ResourceModel
   */
  function (UIComponent, ResourceModel) {
    "use strict";

    return UIComponent.extend("sap.ui.cod3rsgrowth.Component", {
      metadata: {
        interfaces: ["sap.ui.core.IAsyncContentCreation"],
        manifest: "json",
      },

      init: function () {
        UIComponent.prototype.init.apply(this, arguments);

        var i18n = new ResourceModel({
          bundleName: "sap.ui.cod3rsgrowth.i18n.i18n",
        });

        this.setModel(i18n, "i18n");

        this.getRouter().initialize();
      },
    });
  }
);
