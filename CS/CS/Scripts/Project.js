var $dialog1;

$(document).ready(function () {

    $('body').on("click", "a.popup", function (e) {
        e.preventDefault();
        var page = $(this).attr('href');
        OpenPopup(page);
    });
});
//open popup  
function OpenPopup(Page) {
    var $pageContent = $('<div/>');
    $pageContent.load(Page);
    $dialog1 = $('<div class="popupWindow" style="overflow:hidden"></div>')
        .html($pageContent)
        .dialog({
            draggable: true,
            autoOpen: false,
            resizable: true,
            model: true,
            //autoResize:true,
            height: 300,
            width: 600,
            close: function () {
                $dialog1.dialog('destroy').remove();
            }
        })
    $dialog1.dialog('open');
}