
$('#summernote').summernote({
    height: 500,
    minHeight: 300,
    maxHeight: null,
    callbacks: {
        onImageUpload: function (files) {
            for (let i = 0; i < files.length; i++) {
                UploadImage(files[i]);
            }
        },
        onPaste: function (e) {
            var bufferText = ((e.originalEvent || e).clipboardData || window.clipboardData).getData('Text');
            e.preventDefault();
            document.execCommand('insertText', false, bufferText);
        }
    },
    toolbar: [
        ['style', ['style']],
        ['font', ['bold', 'underline']],
        ['color', ['color']],
        ['para', ['ul', 'ol', 'paragraph']],
        ['insert', ['link', 'picture']],
        ['view', ['fullscreen'/*, 'codeview'*/]],
    ],
    styleTags: ['p', 'h4'],
    fontNames: ['Poppins'],
    fontNamesIgnoreCheck: ['Poppins'],
    addDefaultFonts: false,

});
$('#summernote').summernote('Poppins', 'sans-serif')


function UploadImage(file) {

    var url = '@Url.Action("UploadBlogImage", "Image")';

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
            // alert(FileUrl);
            var imgNode = document.createElement('img');
            imgNode.src = FileUrl;
            $('#summernote').summernote('insertNode', imgNode);
        },
        error: function (data) {
            alert(data.responseText);
        }
    });
}