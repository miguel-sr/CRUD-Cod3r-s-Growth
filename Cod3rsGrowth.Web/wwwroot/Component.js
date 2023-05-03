sap.ui.define(
    ["sap/ui/core/UIComponent", "sap/ui/model/json/JSONModel", "sap/ui/Device"],
    function (UIComponent) {
        "use strict";

        return UIComponent.extend("sap.ui.demo.Cod3rsGrowth.Component", {
            metadata: {
                interfaces: ["sap.ui.core.IAsyncContentCreation"],
                manifest: "json",
            },
            init: function () {
                UIComponent.prototype.init.apply(this, arguments);
            }
        });
    }
);
