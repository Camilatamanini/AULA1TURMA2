$("#cep").focusout(function () {
    //In�cio do Comando AJAX
    $.ajax({
        //O campo URL diz o caminho de onde vir� os dados
        //� importante concatenar o valor digitado no CEP
        url: 'https://viacep.com.br/ws/' + $(this).val() + '/38402100/json/',
        //Aqui voc� deve preencher o tipo de dados que ser� lido,
        //no caso, estamos lendo JSON.
        dataType: 'json',
        //SUCESS � referente a fun��o que ser� executada caso
        //ele consiga ler a fonte de dados com sucesso.
        //O par�metro dentro da fun��o se refere ao nome da vari�vel
        //que voc� vai dar para ler esse objeto.
        success: function (resposta) {
            //Agora basta definir os valores que voc� deseja preencher
            //automaticamente nos campos acima.
            $("#logradouro").val(resposta.logradouro);
            $("#complemento").val(resposta.complemento);
            $("#bairro").val(resposta.bairro);
            $("#cidade").val(resposta.localidade);
            $("#uf").val(resposta.uf);
            //Vamos incluir para que o N�mero seja focado automaticamente
            //melhorando a experi�ncia do usu�rio
            $("#numero").focus();
        }
    });
});