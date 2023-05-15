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
        campo.setValueState(ValueState.None);

        let erros = "";
        let valorDoCampo = campo.getValue();

        if (!valorDoCampo.trim()) {
          erros = erros.concat("Este campo é obrigatório. \n");
        } else {
          switch (campo.getType()) {
            case InputType.Number:
              if (!IsNumber.validate(valorDoCampo)) {
                erros = erros.concat("Este campo aceita apenas números. \n,");
              }

              const quantidadeMinimaAceita = 1;

              if (Number.parseInt(valorDoCampo) < quantidadeMinimaAceita) {
                erros = erros.concat("Valor mínimo de 1 unidade. \n,");
              }
              break;

            case InputType.Text:
              let regex = /^[\w\s]+$/;

              if (!regex.test(valorDoCampo)) {
                erros = erros.concat(
                  "Este campo não aceita caracteres especiais. \n"
                );
              }
              break;
          }
        }

        if (erros) {
          campo.setValueState(ValueState.Error);
          campo.setValueStateText(erros);
        }

        return erros;
      },

      ValidarData: function (campo) {
        campo.setValueState(ValueState.None);

        let erros = "";
        let data = new Date(campo.getValue());

        if (data == null) {
          erros = erros.concat("Este campo é obrigatório. \n");
        } else {
          let dataMinima = campo.getMinDate();
          let dataMaxima = campo.getMaxDate();

          if (!(data >= dataMinima && data <= dataMaxima)) {
            erros = erros.concat(
              `A data deve estar entre as datas ${dataMinima.toLocaleDateString()} e ${dataMaxima.toLocaleDateString()}\n`
            );
          }
        }

        if (erros) {
          campo.setValueState(ValueState.Error);
          campo.setValueStateText(erros);
        }

        return erros;
      },

      ValidarTodosCampos(campos) {
        let formularioInvalido;

        campos.forEach((campo) => {
          try {
            if (this.ValidarCampo(campo)) {
              formularioInvalido = true;
            }
          } catch (erro) {
            if (this.ValidarData(campo)) {
              formularioInvalido = true;
            }
          }
        });

        return formularioInvalido;
      },
    });
  }
);
