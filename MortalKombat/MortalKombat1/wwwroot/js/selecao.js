document.addEventListener("DOMContentLoaded", function () {
    var checkboxes = document.querySelectorAll(".checkbox");
    var iniciarButton = document.getElementById("iniciar-button");

    function checkCheckboxes() {
        var allChecked = true;
        for (var i = 0; i < checkboxes.length; i++) {
            if (!checkboxes[i].checked) {
                allChecked = false;
                break;
            }
        }

        if (allChecked) {
            iniciarButton.removeAttribute("disabled");
        } else {
            iniciarButton.setAttribute("disabled", "disabled");
        }
    }

    for (var i = 0; i < checkboxes.length; i++) {
        checkboxes[i].addEventListener("click", checkCheckboxes);
    }

    checkboxes.forEach(function (checkbox) {
        checkbox.addEventListener("change", function () {
            var audio = this.nextElementSibling; 
            if (this.checked) {
                audio.play();
            } else {
                audio.pause();
                audio.currentTime = 0; 
            }
        });
    });
});