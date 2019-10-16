$('[name="mostrar_mensagem"]').click(
    function () {
        var nome = $('[name="nome"]').val();
        alert(nome ? 'Seja bem vindo ' + nome : 'Digite seu nome');
    })