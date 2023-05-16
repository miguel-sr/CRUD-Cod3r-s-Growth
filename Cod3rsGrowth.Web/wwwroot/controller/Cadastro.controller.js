sap.ui.define(
  [
    "sap/ui/core/mvc/Controller",
    "sap/ui/core/routing/History",
    "sap/m/MessageToast",
    "sap/ui/model/json/JSONModel",
    "sap/ui/cod3rsgrowth/services/ValidarFormulario",
    "sap/ui/core/ValueState",
  ],
  function (
    Controller,
    History,
    MessageToast,
    JSONModel,
    ValidarFormulario,
    ValueState
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

      _criarModeloParaFormulario: function () {
        const stringVazia = "";
        const nomeDoModelo = "peca";

        const oModel = new JSONModel({
          categoria: stringVazia,
          nome: stringVazia,
          descricao: stringVazia,
          estoque: stringVazia,
          dataDeFabricacao: stringVazia,
        });

        this.getView().setModel(oModel, nomeDoModelo);
      },

      _resetarValidacao: function () {
        const camposComValidacoes = [
          idCampoNome,
          idCampoCategoria,
          idCampoEstoque,
          idCampoFabricacao,
        ];

        camposComValidacoes.forEach((campo) => {
          this.byId(campo).setValueState(ValueState.None);
        });
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

      aoClicarRetornaPraHome: function () {
        const rotaPaginaPrincipal = "home";

        const historico = History.getInstance();
        const paginaAnterior = historico.getPreviousHash();

        if (paginaAnterior) {
          window.history.go(-1);
          return;
        }

        oRouter.navTo(rotaPaginaPrincipal, {}, {}, true);
      },

      aoClicarSalvarPeca: async function () {
        try {
          const httpStatusCreated = 201;

          const peca = this.getView().getModel("peca").getData();

          if (this._aoSalvarExecutarTodasValidacoes()) {
            const mensagemErro = "formularioInvalido";
            throw oResourceBundle.getText(mensagemErro);
          }

          peca.dataDeFabricacao = new Date(peca.dataDeFabricacao).toISOString();

          const pecaCriada = await fetch("http://localhost:5285/pecas", {
            method: "POST",
            headers: {
              "Content-Type": "application/json",
            },
            body: JSON.stringify(peca),
          }).then((response) => {
            if (response.status !== httpStatusCreated)
              throw response.statusText;

            return response.json();
          });

          const rotaPaginaDetalhes = "detalhes";

          oRouter.navTo(rotaPaginaDetalhes, {
            id: pecaCriada.id,
          });
        } catch (erro) {
          const mensagemErro = "criarPeca";
          MessageToast.show(oResourceBundle.getText(mensagemErro, [erro]));
        }
      },

      _aoSalvarExecutarTodasValidacoes: function () {
        const validarFormulario = new ValidarFormulario();

        const camposInput = [
          this.byId(idCampoCategoria),
          this.byId(idCampoNome),
          this.byId(idCampoEstoque),
        ];

        const campoData = this.byId(idCampoFabricacao);

        return validarFormulario.ValidarTodosCampos(camposInput, campoData);
      },

      aoMudarValorCampoInput: function (oEvent) {
        const validarFormulario = new ValidarFormulario();

        validarFormulario.ValidarCampo(oEvent.getSource());
      },

      aoMudarValorCampoData: function (oEvent) {
        const validarFormulario = new ValidarFormulario();

        validarFormulario.ValidarData(oEvent.getSource());
      },
    });
  }
);
