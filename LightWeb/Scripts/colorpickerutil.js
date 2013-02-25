/// <reference path="../Content/colorpicker/js/colorpicker.js" />
/// <reference path="../Content/colorpicker/js/utils.js" />
/// <reference path="../Content/colorpicker/js/eye.js" />
/// <reference path="../Content/colorpicker/js/jquery.js" />
/// <reference path="../Content/colorpicker/js/layout.js" />



$('#colorpickerHolder').ColorPicker(
{
    flat: true,
    color: '#0000ff',
    onShow: function (colpkr) {
        $(colpkr).fadeIn(500);
        return false;
    },
    onSubmit: function (hsb, hex, rgb) {
        $.ajax(
        {
            type: "GET",
            url: "/Home/ColorPick",
            data: rgb,
            success:
            function () {
            }
        });
    }
});


$(document).ready(function () {
    $("a").click(function () {
        $.ajax(
        {
            type: "GET",
            url: "/Home/Fade",
            data: "",
            success:
            function () {
            }
        });
    });

});

