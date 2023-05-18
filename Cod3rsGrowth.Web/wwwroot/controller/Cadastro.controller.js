sap.ui.define(
  [
    "sap/ui/core/mvc/Controller",
    "sap/ui/core/routing/History",
    "sap/ui/model/json/JSONModel",
    "sap/ui/cod3rsgrowth/services/ValidarFormulario",
    "sap/ui/core/ValueState",
    "sap/m/MessageBox",
    "sap/ui/cod3rsgrowth/repositorios/Api",
  ],
  function (
    Controller,
    History,
    JSONModel,
    ValidarFormulario,
    ValueState,
    MessageBox,
    Api
  ) {
    "use strict";

    let oResourceBundle;
    let oRouter;

    const idCampoNome = "nome";
    const idCampoCategoria = "categoria";
    const idCampoEstoque = "estoque";
    const idCampoFabricacao = "dataDeFabricacao";

    return Controller.extend("sap.ui.cod3rsgrowth.controller.Cadastro", {
      onInit: function () {
        oResourceBundle = this.getOwnerComponent()
          .getModel("i18n")
          .getResourceBundle();

        oRouter = this.getOwnerComponent().getRouter();

        this._api = new Api();

        const rotaPaginaCadastro = "cadastro";

        oRouter
          .getRoute(rotaPaginaCadastro)
          .attachPatternMatched(this._inicializarFormulario, this);
      },

      _inicializarFormulario: function () {
        this._criarModeloParaFormulario();
        this._definirIntervaloValidoDeDatas();
        this._resetarValidacao();
      },

      _criarModeloParaFormulario: async function () {
        const nomeDoModelo = "peca";

        let oModel;

        const id = oRouter.oHashChanger.hash.split("/")[1];

        if (id) {
          const modeloPeca = await this._api.carregarPecaComId(id);
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
        const idCampoFabricacao = "dataDeFabricacao";
        const dataMinima = new Date("1754-01-01T12:00:00.000Z");
        const dataMaxima = new Date();

        const datePicker = this.byId(idCampoFabricacao);

        dataMaxima.setHours(12, 0, 0, 0);

        datePicker.setMinDate(dataMinima);
        datePicker.setMaxDate(dataMaxima);
      },

      aoClicarNavegarParaHome: function () {
        const rotaPaginaPrincipal = "home";

        const historico = History.getInstance();
        const paginaAnterior = historico.getPreviousHash();

        paginaAnterior
          ? window.history.go(-1)
          : oRouter.navTo(rotaPaginaPrincipal);
      },

      aoClicarSalvarPeca: async function () {
        try {
          const pecaInvalida = this._validarCampos();

          if (pecaInvalida) {
            const mensagemErro = "formularioInvalido";
            throw new Error(oResourceBundle.getText(mensagemErro));
          }

          const peca = this.getView().getModel("peca").getData();

          peca.dataDeFabricacao = new Date(peca.dataDeFabricacao).toISOString();

          const idPeca = await this._api.salvarPeca(peca);

          const rotaPaginaDetalhes = "detalhes";

          oRouter.navTo(rotaPaginaDetalhes, {
            id: idPeca,
          });
        } catch (erro) {
          const mensagemErro = "criarPeca";
          throw new Error(oResourceBundle.getText(mensagemErro, [erro]));
        }
      },

      _validarCampos: function () {
        this._processarEvento(() => {
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
        this._processarEvento(() => {
          const validarFormulario = new ValidarFormulario();
          const campoInput = oEvent.getSource();

          validarFormulario.validarCampo(campoInput);
        });
      },

      aoMudarValorCampoData: function (oEvent) {
        this._processarEvento(() => {
          const validarFormulario = new ValidarFormulario();
          const campoData = oEvent.getSource();

          validarFormulario.validarData(campoData);
        });
      },

      _processarEvento: function (action) {
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
