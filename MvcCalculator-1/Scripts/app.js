$(document).ready(function () {

    var input2 = $("#inputbox-2"),
    radioSin = document.getElementById("radioSin"),
    radioSquare = document.getElementById("radioSquare");

    checkChecked();

    $('input').on("click", function () {
        
        checkChecked();

    });

    function checkChecked() 
    {
        (radioSin.checked || radioSquare.checked) ? input2.hide() : input2.show();
    }


});