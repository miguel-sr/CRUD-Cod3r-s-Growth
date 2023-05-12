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

    return Controller.extend("sap.ui.cod3rsgrowth.controller.Cadastro", {
      onInit: function () {
        oResourceBundle = this.getOwnerComponent()
          .getModel("i18n")
          .getResourceBundle();

        oRouter = this.getOwnerComponent().getRouter();

        const rotaPaginaCadastro = "cadastro";

        this._configurarDatePicker();

        oRouter
          .getRoute(rotaPaginaCadastro)
          .attachPatternMatched(this._inicializarFormulario, this);
      },
      _inicializarFormulario: function () {
        const stringVazia = "";

        let oModel = new JSONModel({
          categoria: stringVazia,
          nome: stringVazia,
          descricao: stringVazia,
          estoque: stringVazia,
          dataDeFabricacao: stringVazia,
        });

        this.getView().setModel(oModel, "peca");

        let camposComValidacoes = ["nome", "estoque", "dataDeFabricacao"];

        camposComValidacoes.forEach((campo) => {
          this.byId(campo).setValueState(ValueState.None);
        });
      },
      _configurarDatePicker: function () {
        const idCampoFabricacao = "dataDeFabricacao";
        let datePicker = this.byId(idCampoFabricacao);
        let dataMinima = new Date("1754-01-01T12:00:20.031Z");

        datePicker.setMinDate(dataMinima);
        datePicker.setMaxDate(new Date());
      },
      aoClicarRetornaPraHome: function () {
        const rotaPaginaPrincipal = "home";

        let historico = History.getInstance();
        let paginaAnterior = historico.getPreviousHash();

        if (paginaAnterior) {
          window.history.go(-1);
          return;
        }

        oRouter.navTo(rotaPaginaPrincipal, {}, {}, true);
      },

      aoClicarSalvarPeca: async function () {
        const httpStatusCreated = 201;

        try {
          let peca = this.getView().getModel("peca").getData();

          if (this._validarTodosCampos()) {
            const mensagemErro = "formularioInvalido";
            throw oResourceBundle.getText(mensagemErro);
          }

          peca.dataDeFabricacao = new Date(peca.dataDeFabricacao).toISOString();

          let pecaCriada = await fetch("http://localhost:5285/pecas", {
            method: "POST",
            headers: {
              "Content-Type": "application/json",
            },
            body: JSON.stringify(peca),
          }).then(async (response) => {
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
      _validarTodosCampos: function () {
        const validarFormulario = new ValidarFormulario();

        const idCampoNome = "nome";
        const idCampoCategoria = "categoria";
        const idCampoEstoque = "estoque";
        const idCampoFabricacao = "dataDeFabricacao";

        var campos = [
          this.byId(idCampoNome),
          this.byId(idCampoCategoria),
          this.byId(idCampoEstoque),
          this.byId(idCampoFabricacao),
        ];

        return validarFormulario.TodosCampos(campos);
      },
      validarCampo: function (oEvent) {
        const validarFormulario = new ValidarFormulario();

        validarFormulario.Campo(oEvent.getSource());
      },
      validarCampoData: function () {
        const validarFormulario = new ValidarFormulario();

        const idCampoFabricacao = "dataDeFabricacao";

        validarFormulario.Data(this.byId(idCampoFabricacao));
      },
    });
  }
);