function validarSesion() {
    var inicioUsuario = $('#emailTxt').val();
    var inicioContrasena = $('#passwordTxt').val();

    if (inicioUsuario == null || inicioUsuario.lenght == 0) {
        $("#TextoInicio").text("Ingresa un usuario");
        //visualizaMimensaje();

    } else if (inicioContrasena == null || inicioContrasena.lenght == 0) {
        $("#TextoInicio").text("Ingresa una contraseña");
        //visualizaMimensaje();
    } else {
        var url = '/Usuario/Login/';
        var $form = $(document.createElement('form')).css({ display: 'none' }).attr("method", "POST").attr("action", url);

        var $inicioUsuario = $(document.createElement('input')).attr('name', 'emailTxt').val(inicioUsuario);
        var $inicioContrasena = $(document.createElement('input')).attr('name', 'passwordTxt').val(inicioContrasena);
        $form.append($inicioUsuario);
        $form.append($inicioContrasena);

        $("body").append($form);
        $form.submit();
    }
}