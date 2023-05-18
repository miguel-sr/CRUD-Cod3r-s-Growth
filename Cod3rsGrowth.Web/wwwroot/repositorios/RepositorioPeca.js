sap.ui.define([], function () {
  "use strict";

  const urlApi = "http://localhost:5285/pecas";

  const httpStatusOk = 200;
  const httpStatusCreated = 201;
  const httpStatusNoContent = 204;

  return {
    obterTodos: async function () {
      const pecas = await fetch(urlApi).then((response) => {
        if (response.status !== httpStatusOk) throw response.statusText;

        return response.json();
      });

      return pecas;
    },

    obterPorId: async function (id) {
      const peca = await fetch(`${urlApi}/${id}`).then((response) => {
        if (response.status !== httpStatusOk) throw response.statusText;

        return response.json();
      });

      return peca;
    },

    criarPeca: async function (peca) {
      const pecaCriada = await fetch(urlApi, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(peca),
      }).then(async (response) => {
        if (response.status != httpStatusCreated) throw response.statusText;

        return response.json();
      });

      return pecaCriada.id;
    },

    atualizarPeca: async function (peca) {
      const idPeca = await fetch(urlApi, {
        method: "PATCH",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(peca),
      }).then(async (response) => {
        if (response.status == httpStatusNoContent) return peca.id;

        throw response.statusText;
      });

      return idPeca;
    },

    apagarPeca: async function (id) {
      const response = await fetch(`${urlApi}/${id}`, {
        method: "DELETE",
      });

      if (response.status !== httpStatusNoContent) throw response.statusText;
    },
  };
});
