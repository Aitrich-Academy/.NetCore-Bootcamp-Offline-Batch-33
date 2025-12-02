const btn = document.getElementById("btn");

const emailWarn = document.getElementById("emailwarn");
const passWarn = document.getElementById("passwarn");
const wrongPass = document.getElementById("incorrect");

btn.addEventListener("click", function() {
    const emailValue = document.getElementById("email").value;
    const passValue = document.getElementById("pass").value;
    
    if(emailValue == undefined || emailValue == "") {
        emailWarn.style.display = "block";
    }
    else {
        emailWarn.style.display = "none";
    }
    if(passValue == undefined || passValue == "") {
        passWarn.style.display = "block";
    }
    else {
        passWarn.style.display = "none";
    }
});