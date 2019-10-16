$(document).ready(function () {
    var moeda, valorreal, cambio, resultado, valortext;
    valorkwanza = $('input[name="valor_kwanza"]').val();
    cambio = $('input[name="cambio"]').val();
    valortext = $('input[name="valor"]').val();
    moeda = $('input[type="radio"][name="moeda"]:checked').val();
    $('input[name=converte]').click(function () {

        if (moeda == 1) {
            alert("Opção não activada para efeito de calculos");
        }
        else
            if (moeda == 2) {

                resultado = valorkwanza / cambio;
                document.conversor_moeda.valor.value = resultado;
            }
            else
                if (moeda == 3) {
                    alert("Opção não activada para efeito de calculos");
                }
                else
                    if (moeda == 4) {
                        alert("Opção não activada para efeito de calculos");
                    }
    })