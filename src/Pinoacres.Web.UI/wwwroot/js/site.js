$().ready(function () {
    $('.dialog-div').dialog({
        autoOpen: false,
        width: '800', // overcomes width:'auto' and maxWidth bug
        maxWidth: 800,
        height: 'auto',
        modal: true,
        fluid: true, //new option
        resizable: false,
        open: function (event, ui) {
            fluidDialog(); // needed when autoOpen is set to true in this codepen
        }
    });

    $('.dialog-box').click(function () {
        var divName = $($(this)[0]).data('div-id');
        var dialogDiv = $('#' + divName);

        $(dialogDiv).dialog('open');
    });

    $('.img-thumbnail').click(function (sender, e) {
        var thumbImage = $(this);

        var imgSrc = thumbImage.attr('src');
        var imgAlt = thumbImage.attr('alt');

        var imageDiv = $('#image-dialog-div');
        imageDiv.dialog('option', 'title', imgAlt);

        var imageTag = $('#image-tag');
        imageTag.attr('src', imgSrc);
        imageTag.attr('alt', imgAlt);

        $(imageDiv).dialog('open');

    });

    $('.dialog-div').click(function () {
        $(this).dialog('close');
    });


});

// on window resize run function
$(window).resize(function () {
    fluidDialog();
});

// catch dialog if opened within a viewport smaller than the dialog width
$(document).on("dialogopen", ".ui-dialog", function (event, ui) {
    fluidDialog();
});

function fluidDialog() {
    var $visible = $(".ui-dialog:visible");
    // each open dialog
    $visible.each(function () {
        var $this = $(this);
        var dialog = $this.find(".ui-dialog-content").data("ui-dialog");
        // if fluid option == true
        if (dialog.options.fluid) {
            var wWidth = $(window).width();
            // check window width against dialog width
            if (wWidth < (parseInt(dialog.options.maxWidth) + 50)) {
                // keep dialog from filling entire screen
                $this.css("max-width", "90%");
            } else {
                // fix maxWidth bug
                $this.css("max-width", dialog.options.maxWidth + "px");
            }
            //reposition dialog
            dialog.option("position", dialog.options.position);
        }
    });

}