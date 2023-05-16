sap.ui.define(
  [
    "sap/ui/core/mvc/Controller",
    "sap/ui/integration/designtime/baseEditor/validator/IsNumber",
    "sap/ui/core/ValueState",
    "sap/m/InputType",
  ],
  function (Controller, IsNumber, ValueState, InputType) {
    "use strict";

    return Controller.extend("sap.ui.cod3rsgrowth.services.ValidarFormulario", {
      ValidarCampo: function (campo) {
        let erros = "";
        const valorDoCampo = campo.getValue().trim();

        if (!valorDoCampo) {
          erros += "Este campo é obrigatório. \n";
        } else {
          switch (campo.getType()) {
            case InputType.Number:
              if (!IsNumber.validate(valorDoCampo)) {
                erros += "Este campo aceita apenas números. \n";
              }

              const quantidadeMinimaAceita = 1;

              if (Number.parseInt(valorDoCampo) < quantidadeMinimaAceita) {
                erros += "Valor mínimo de 1 unidade. \n";
              }

              const tamanhoMaximoDoCampo = 5;

              if (valorDoCampo.length > tamanhoMaximoDoCampo) {
                erros += `O máximo de caracteres permitido é ${tamanhoMaximoDoCampo}. \n`;
                const stringVazia = "";
                campo.setValue(stringVazia);
              }
              break;

            case InputType.Text:
              let regex = /^[\w\sÀ-ú]+$/;

              if (!regex.test(valorDoCampo)) {
                erros += "Este campo não aceita caracteres especiais. \n";
              }
              break;
          }
        }

        campo.setValueState(erros ? ValueState.Error : ValueState.None);
        campo.setValueStateText(erros);

        return erros;
      },

      ValidarData: function (campo) {
        const data = campo.getValue();
        const dataValida = campo.isValidValue();
        const stringVazia = "";

        let erros = "";

        if (data == stringVazia || data == null) {
          erros += "Este campo é obrigatório. \n";
        } else {
          const dataMinima = campo.getMinDate().toLocaleDateString();
          const dataMaxima = campo.getMaxDate().toLocaleDateString();

          if (dataValida == stringVazia || dataValida == null) {
            erros += `A data deve estar entre as datas ${dataMinima} e ${dataMaxima}\n`;
          }
        }

        campo.setValueState(erros ? ValueState.Error : ValueState.None);
        campo.setValueStateText(erros);

        return erros;
      },

      ValidarTodosCampos: function (camposInput, campoData) {
        let erros = "";

        camposInput.forEach((campo) => {
          erros += this.ValidarCampo(campo);
        });

        erros += this.ValidarData(campoData);

        return erros;
      },
    });
  }
);
