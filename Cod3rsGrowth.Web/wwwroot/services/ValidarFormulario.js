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
      Campo: function (campo) {
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

              if (Number.parseInt(valorDoCampo) < 1) {
                erros = erros.concat("Valor mínimo de 1 unidade. \n,");
              }
              break;

            case InputType.Text:
              let regex = /@^\w|\s([p{L}])$/;

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
      Data: function (campo) {
        campo.setValueState(ValueState.None);

        let erros = "";
        let data = campo.getDateValue();

        if (!data) {
          erros = erros.concat("Este campo é obrigatório. \n");
        } else {
          let dataMinima = campo.getMinDate();
          let dataMaxima = campo.getMaxDate();

          if (data > dataMaxima) {
            erros = erros.concat(
              `A data não pode exceder a data ${dataMaxima.toLocaleDateString()}\n`
            );
          }

          if (data < dataMinima) {
            erros = erros.concat(
              `A data não ser menor que a data ${dataMinima.toLocaleDateString()}\n`
            );
          }
        }

        if (erros) {
          campo.setValueState(ValueState.Error);
          campo.setValueStateText(erros);
        }

        return erros;
      },
      TodosCampos(campos) {
        var formularioInvalido;

        campos.forEach((campo) => {
          try {
            if (this.Campo(campo)) {
              formularioInvalido = true;
            }
          } catch (erro) {
            if (this.Data(campo)) {
              formularioInvalido = true;
            }
          }
        });

        return formularioInvalido;
      },
    });
  }
);
