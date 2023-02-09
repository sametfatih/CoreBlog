
$('#previewButton').on("click", function () {

    var validationMessage;
    function titleValidate() {
        var result = $("#blogTitle").val();
        if (result.length >= 10) {
            return true;
        } else {
            validationMessage = "*Başlık alanı minimum 10 karakter olmalıdır!";
            return false;
        }
    }
    function imageValidate() {
        var result = $("#blog-image").val();
        if (result != "") {
            return true;
        } else {
            validationMessage = "*Önizleme yapabilmek için bir görsel eklemelisiniz!";
            return false;
        }
    }
    function contentValidate() {
        var result = $("#summernote").val();
        if (result.length >= 100) {
            return true;
        } else {
            validationMessage = "*İçerik alanı minimum 100 karakter olmalıdır!";
            return false;
        }
    }

    if (titleValidate() && imageValidate() && contentValidate()) {
        $('#blogAddForm').attr('action', "/Blog/BlogPreview");
        $('#blogAddForm').attr('target', "_blank").submit();
    } else {
        console.log("error2");

        $('#preview-message').css('color', '#fe7c96');
        $('#preview-message').text(validationMessage);
        $('#preview-message').fadeIn();
        setTimeout(function () {
            $('#preview-message').text('');
        }, 3000);
    }
});