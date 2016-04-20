$(document).ready(function () {

    var input2 = $("#inputbox-2"),
    radioSin = document.getElementById("radioSin"),
    radioSquare = document.getElementById("radioSquare");

    $('input').on("click", function () {
        
        (radioSin.checked || radioSquare.checked) ? input2.hide() : input2.show();

    });


});