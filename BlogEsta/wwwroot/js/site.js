function GenerateUrl() {
    $("#Titulo").keyup(function () {
        let UrlBase = "http://www.localhost/";
        var Url = LimparTitulo($("#Titulo").val());
        
        $("#Url").val(UrlBase + Url);
    });
}

function LimparTitulo(title) {
    return title.normalize('NFD').replace(/[\u0300-\u036f]/g, '') // Remove acentos
        .replace(/([^\w]+|\s+)/g, '-') // Substitui espaço e outros caracteres por hífen
        .replace(/\-\-+/g, '-')	// Substitui multiplos hífens por um único hífen
        .replace(/(^-+|-+$)/, '').toLowerCase(); // Remove hífens extras do final ou do inicio da string
}