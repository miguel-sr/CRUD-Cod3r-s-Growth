sap.ui.define(
  [
    "sap/ui/core/routing/History",
    "sap/ui/model/json/JSONModel",
    "sap/ui/cod3rsgrowth/services/ValidarFormulario",
    "sap/ui/core/ValueState",
    "sap/ui/cod3rsgrowth/repositorios/RepositorioPeca",
    "sap/ui/cod3rsgrowth/common/BaseController",
  ],
  function (
    History,
    JSONModel,
    ValidarFormulario,
    ValueState,
    RepositorioPeca,
    BaseController
  ) {
    "use strict";

    let oRouter;

    const idCampoNome = "nome";
    const idCampoCategoria = "categoria";
    const idCampoEstoque = "estoque";
    const idCampoFabricacao = "dataDeFabricacao";

    return BaseController.extend("sap.ui.cod3rsgrowth.controller.Cadastro", {
      onInit: function () {
        oRouter = this.getOwnerComponent().getRouter();

        oRouter
          .getRoute(this.rotasDaAplicacao.paginaCadastro)
          .attachPatternMatched(this._inicializarFormulario, this);
      },

      _inicializarFormulario: function (oEvent) {
        this._criarModeloParaFormulario(oEvent);
        this._definirIntervaloValidoDeDatas();
        this._resetarValidacao();
      },

      _criarModeloParaFormulario: async function (oEvent) {
        const nomeDoModelo = "peca";

        let oModel;

        const idPeca = oEvent.getParameter("arguments").id;

        if (idPeca) {
          const modeloPeca = await RepositorioPeca.obterPorId(idPeca);
          oModel = new JSONModel(modeloPeca);
        } else {
          const stringVazia = "";

          const modeloVazio = {
            categoria: stringVazia,
            nome: stringVazia,
            descricao: stringVazia,
            estoque: stringVazia,
            dataDeFabricacao: stringVazia,
          };

          oModel = new JSONModel(modeloVazio);
        }

        this.getView().setModel(oModel, nomeDoModelo);
      },

      _resetarValidacao: function () {
        const idsCamposComValidacoes = [
          idCampoNome,
          idCampoCategoria,
          idCampoEstoque,
          idCampoFabricacao,
        ];

        idsCamposComValidacoes.forEach((campo) =>
          this.byId(campo).setValueState(ValueState.None)
        );
      },

      _definirIntervaloValidoDeDatas: function () {
        const dataMinima = new Date("1754-01-01T12:00:00.000Z");
        const dataMaxima = new Date();

        const datePicker = this.byId(idCampoFabricacao);

        dataMaxima.setHours(12, 0, 0, 0);

        datePicker.setMinDate(dataMinima);
        datePicker.setMaxDate(dataMaxima);
      },

      aoClicarNavegarParaPaginaAnterior: function () {
        const historico = History.getInstance();
        const paginaAnterior = historico.getPreviousHash();

        paginaAnterior
          ? window.history.go(-1)
          : oRouter.navTo(this.rotasDaAplicacao.paginaPrincipal);
      },

      aoClicarSalvarPeca: async function () {
        try {
          const pecaInvalida = this._validarCampos();

          if (pecaInvalida) {
            const mensagemErro = "formularioInvalido";
            throw new Error(this.carregarRecursoI18n().getText(mensagemErro));
          }

          const peca = this.pegarDadosModeloPeca();

          peca.dataDeFabricacao = new Date(peca.dataDeFabricacao).toISOString();

          let idPeca;

          if (peca.id) {
            idPeca = await RepositorioPeca.atualizarPeca(peca);
          } else {
            idPeca = await RepositorioPeca.criarPeca(peca);
          }

          oRouter.navTo(this.rotasDaAplicacao.paginaDetalhes, {
            id: idPeca,
          });
        } catch (erro) {
          const mensagemErro = "criarPeca";
          throw new Error(
            this.carregarRecursoI18n().getText(mensagemErro, [erro])
          );
        }
      },

      _validarCampos: function () {
        this.processarEvento(() => {
          const validarFormulario = new ValidarFormulario();

          const camposInput = [
            this.byId(idCampoCategoria),
            this.byId(idCampoNome),
            this.byId(idCampoEstoque),
          ];

          const campoData = this.byId(idCampoFabricacao);

          return validarFormulario.validarTodosCampos(camposInput, campoData);
        });
      },

      aoMudarValorCampoInput: function (oEvent) {
        this.processarEvento(() => {
          const validarFormulario = new ValidarFormulario();
          const campoInput = oEvent.getSource();

          validarFormulario.validarCampo(campoInput);
        });
      },

      aoMudarValorCampoData: function (oEvent) {
        this.processarEvento(() => {
          const validarFormulario = new ValidarFormulario();
          const campoData = oEvent.getSource();

          validarFormulario.validarData(campoData);
        });
      },
    });
  }
);
