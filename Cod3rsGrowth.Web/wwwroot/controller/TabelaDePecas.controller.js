sap.ui.define(
  [
    "sap/ui/core/mvc/Controller",
    "sap/ui/model/json/JSONModel",
    "sap/ui/model/Filter",
    "sap/ui/model/FilterOperator",
    "sap/m/MessageToast",
  ],
  /**
   * @param {typeof import('sap/ui/core/mvc/Controller').default} Controller
   * @param {typeof import('sap/ui/model/json/JSONModel').default} JSONModel
   * @param {typeof import('sap/ui/model/Filter').default} Filter
   * @param {typeof import('sap/ui/model/FilterOperator').default} FilterOperator
   * @param {typeof import('sap/m/MessageToast').default} MessageToast
   */
  function (Controller, JSONModel, Filter, FilterOperator, MessageToast) {
    "use strict";

    let oResourceBundle;

    return Controller.extend("sap.ui.cod3rsgrowth.controller.TabelaDePecas", {
      onInit: function () {
        oResourceBundle = this.getOwnerComponent()
          .getModel("i18n")
          .getResourceBundle();

        this._carregarPecas();
      },

      _carregarPecas: async function () {
        const httpStatusOk = 200;
        const mensagemErro = "obterItensTabela";

        try {
          let oModel = new JSONModel();

          let resposta = await fetch("http://localhost:5285/pecas");

          if (resposta.status !== httpStatusOk) {
            throw resposta.statusText;
          }

          let pecas = await resposta.json();

          oModel.setData({ pecas });

          this.getView().setModel(oModel);
        } catch (error) {
          MessageToast.show(oResourceBundle.getText(mensagemErro, [error]));
        }
      },

      aoClicarMostrarDetalhes: async function (oEvent) {
        const rotaPaginaDetalhes = "detalhes";
        const id = this._obterIdPeca(oEvent);

        let oRouter = this.getOwnerComponent().getRouter();

        oRouter.navTo(rotaPaginaDetalhes, {
          id: id,
        });
      },

      _obterIdPeca: function (oEvent) {
        const parametroIdUri = "/id";
        let uriDaPeca = oEvent.getSource().getBindingContext().getPath();

        return this.getView()
          .getModel()
          .getProperty(uriDaPeca + parametroIdUri);
      },

      aoClicarFiltrarPecas: function (oEvent) {
        const parametroEvento = "query";
        const campoUsadoParaFiltro = "nome";
        const idComponenteTabela = "listaDePecas";
        const listaDePecas = "items";

        let filtro = [];
        let query = oEvent.getParameter(parametroEvento);

        if (query) {
          filtro.push(
            new Filter(campoUsadoParaFiltro, FilterOperator.Contains, query)
          );
        }

        let tabelaDePecas = this.byId(idComponenteTabela);
        let binding = tabelaDePecas.getBinding(listaDePecas);
        binding.filter(filtro);
      },
    });
  }
);
