sap.ui.define(
  [
    "sap/ui/core/mvc/Controller",
    "sap/ui/model/json/JSONModel",
    "sap/ui/model/Filter",
    "sap/ui/model/FilterOperator",
    "sap/m/MessageBox",
  ],
  function (Controller, JSONModel, Filter, FilterOperator, MessageBox) {
    "use strict";

    let oResourceBundle;
    let oRouter;

    return Controller.extend("sap.ui.cod3rsgrowth.controller.TabelaDePecas", {
      onInit: function () {
        oResourceBundle = this.getOwnerComponent()
          .getModel("i18n")
          .getResourceBundle();

        const rotaPaginaPrincipal = "home";

        oRouter = this.getOwnerComponent().getRouter();

        oRouter
          .getRoute(rotaPaginaPrincipal)
          .attachPatternMatched(this._carregarPecas, this);
      },

      _carregarPecas: async function () {
        const httpStatusOk = 200;

        try {
          let oModel = new JSONModel();

          let pecas = await fetch(`http://localhost:5285/pecass`).then(
            (response) => {
              if (response.status !== httpStatusOk) throw response.statusText;

              return response.json();
            }
          );

          oModel.setData({ pecas });

          this.getView().setModel(oModel);
        } catch (erro) {
          const mensagemErro = "obterItensTabela";
          MessageBox.error(oResourceBundle.getText(mensagemErro, [erro]));
        }
      },

      aoClicarMostrarDetalhes: async function (oEvent) {
        const rotaPaginaDetalhes = "detalhes";
        const id = this._obterIdPeca(oEvent);

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

      aoClicarNavegarParaCadastro: function () {
        const rotaPaginaCadastro = "cadastro";

        oRouter.navTo(rotaPaginaCadastro);
      },
    });
  }
);
