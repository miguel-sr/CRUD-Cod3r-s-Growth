sap.ui.define(
  [
    "sap/ui/core/mvc/Controller",
    "sap/ui/core/routing/History",
    "sap/ui/model/json/JSONModel",
    "sap/ui/cod3rsgrowth/services/ValidarFormulario",
    "sap/ui/core/ValueState",
    "sap/ui/core/format/DateFormat",
    "sap/m/MessageBox",
  ],
  function (
    Controller,
    History,
    JSONModel,
    ValidarFormulario,
    ValueState,
    DateFormat,
    MessageBox
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
          const modeloPeca = await this._carregarPeca();
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

          const httpStatusCreated = 201;
          const httpStatusNoContent = 204;

          const peca = this.getView().getModel("peca").getData();

          peca.dataDeFabricacao = new Date(peca.dataDeFabricacao).toISOString();

          const idPeca = await fetch(
            "http://localhost:5285/pecas",
            this._retornaConfiguracaoFetch(peca)
          ).then(async (response) => {
            if (response.status == httpStatusCreated) {
              const pecaCriada = await response.json();
              return pecaCriada.id;
            }

            if (response.status == httpStatusNoContent) return peca.id;

            throw response.statusText;
          });

          const rotaPaginaDetalhes = "detalhes";

          oRouter.navTo(rotaPaginaDetalhes, {
            id: idPeca,
          });
        } catch (erro) {
          const mensagemErro = "criarPeca";
          throw new Error(oResourceBundle.getText(mensagemErro, [erro]));
        }
      },

      _retornaConfiguracaoFetch: function (peca) {
        let configuracaoFetch = {
          headers: {
            "Content-Type": "application/json",
          },
          body: JSON.stringify(peca),
        };

        const metodoCriar = "POST";
        const metodoAtualizar = "PATCH";

        configuracaoFetch.method = peca.id ? metodoAtualizar : metodoCriar;

        return configuracaoFetch;
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

      _carregarPeca: async function () {
        try {
          const httpStatusOk = 200;

          const id = oRouter.oHashChanger.hash.split("/")[1];

          let peca = await fetch(`http://localhost:5285/psecas/${id}`).then(
            (response) => {
              if (response.status !== httpStatusOk) throw response.statusText;

              return response.json();
            }
          );

          peca.dataDeFabricacao = DateFormat.getDateInstance({
            pattern: "yyyy-MM-dd",
          }).format(new Date(peca.dataDeFabricacao));

          return peca;
        } catch (erro) {
          const mensagemErro = "obterPeca";
          throw new Error(oResourceBundle.getText(mensagemErro, [erro]));
        }
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
