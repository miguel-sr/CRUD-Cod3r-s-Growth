sap.ui.define(
  [
    "sap/ui/cod3rsgrowth/common/BaseController",
    "sap/ui/model/json/JSONModel",
    "sap/ui/model/Filter",
    "sap/ui/model/FilterOperator",
    "sap/m/MessageBox",
    "sap/ui/cod3rsgrowth/repositorios/RepositorioPeca",
  ],
  function (
    BaseController,
    JSONModel,
    Filter,
    FilterOperator,
    MessageBox,
    RepositorioPeca
  ) {
    "use strict";

    let oResourceBundle;
    let oRouter;

    return BaseController.extend(
      "sap.ui.cod3rsgrowth.controller.TabelaDePecas",
      {
        onInit: function () {
          oResourceBundle = this.carregarRecursoI18n();

          const rotaPaginaPrincipal = "home";

          oRouter = this.getOwnerComponent().getRouter();

          oRouter
            .getRoute(rotaPaginaPrincipal)
            .attachPatternMatched(this._renderizarPecasNaTela, this);
        },

        _renderizarPecasNaTela: async function () {
          try {
            const oModel = new JSONModel();

            const pecas = await RepositorioPeca.obterTodos();

            oModel.setData({ pecas });

            this.getView().setModel(oModel);
          } catch (erro) {
            const mensagemErro = "obterItensTabela";
            MessageBox.error(oResourceBundle.getText(mensagemErro, [erro]));
          }
        },

        aoClicarMostrarDetalhes: async function (oEvent) {
          const id = this._obterIdPeca(oEvent);

          oRouter.navTo(this.rotasDaAplicacao.paginaDetalhes, {
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
          const campoUsadoParaFiltro = "nome";
          const idComponenteTabela = "listaDePecas";
          const listaDePecas = "items";

          let filtro = [];
          let query = oEvent.getParameter("query");

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
          oRouter.navTo(this.rotasDaAplicacao.paginaCadastro);
        },
      }
    );
  }
);
