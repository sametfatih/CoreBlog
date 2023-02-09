

var supportedExt = [".jpg", ".jpeg", ".png"];

$('#upload-file').on("change", function () {
    
    var files = $('#upload-file').prop('files');
    for (let i = 0; i < files.length; i++) {

        var ext = files[i].name.substring(files[i].name.lastIndexOf("."), files[i].name.length);

        for (let j = 0; j < supportedExt.length; j++) {

            if (supportedExt[j] == ext) {
                UploadImage2(files[i])
            } else {
                $('#upload-message').css('color', '#fe7c96')
                $('#upload-message').text('*Desteklenen dosya uzantıları .jpg, .jpeg ve .png uzantılarıdır.');
                $('#upload-message').fadeIn();

                setTimeout(function () {
                    $('#upload-message').text('');

                }, 5000);
            }
        }
    }
});

function UploadImage2(file) {

    var url = "/Image/UploadBlogImage";

    formData = new FormData();
    formData.append("uploadedFile", file);
    $.ajax({
        type: 'POST',
        url: url,
        data: formData,
        cache: false,
        contentType: false,
        processData: false,
        success: function (FileUrl) {

            $('#blog-image').val(FileUrl);

            $('#upload-message').css('color', '#1bcfb4')
            $('#upload-message').text('*Resim yüklendi.');
            $('#upload-message').fadeIn();

        },
        error: function (e) {
            console.log(e);
            $('#upload-message').css('color', '#fe7c96')
            $('#upload-message').text('*Resim yüklenemedi lütfen tekrar deneyin.');
            $('#upload-message').fadeIn();

            setTimeout(function () {
                $('#upload-message').text('');

            }, 5000);
        }
    });
}