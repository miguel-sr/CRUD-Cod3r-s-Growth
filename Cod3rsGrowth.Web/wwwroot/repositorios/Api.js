sap.ui.define(
  ["sap/ui/core/mvc/Controller", "sap/ui/core/format/DateFormat"],
  function (Controller, DateFormat) {
    "use strict";

    let oResourceBundle;

    return Controller.extend("sap.ui.cod3rsgrowth.repositorios.Api", {
      onInit: function () {
        oResourceBundle = this.getOwnerComponent()
          .getModel("i18n")
          .getResourceBundle();
      },

      carregarPecas: async function () {
        try {
          const httpStatusOk = 200;

          const pecas = await fetch("http://localhost:5285/pecas").then(
            (response) => {
              if (response.status !== httpStatusOk) throw response.statusText;

              return response.json();
            }
          );

          return pecas;
        } catch (erro) {
          const mensagemErro = "obterPeca";
          throw new Error(oResourceBundle.getText(mensagemErro, [erro]));
        }
      },

      carregarPecaComId: async function (id) {
        try {
          const httpStatusOk = 200;

          let peca = await fetch(`http://localhost:5285/pecas/${id}`).then(
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

      salvarPeca: async function (peca) {
        try {
          const httpStatusCreated = 201;
          const httpStatusNoContent = 204;

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

          return idPeca;
        } catch (erro) {
          const mensagemErro = "criarPeca";
          throw new Error(oResourceBundle.getText(mensagemErro, [erro]));
        }
      },

      apagarPeca: async function (id) {
        try {
          const httpStatusNoContent = 204;

          const response = await fetch(`http://localhost:5285/pecas/${id}`, {
            method: "DELETE",
          });

          if (response.status !== httpStatusNoContent)
            throw response.statusText;
        } catch (erro) {
          const mensagemErro = "deletarPeca";
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
    });
  }
);
