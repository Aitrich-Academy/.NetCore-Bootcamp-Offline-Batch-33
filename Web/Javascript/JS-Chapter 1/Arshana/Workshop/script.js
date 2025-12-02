document.getElementById("updateBtn").addEventListener("click", function () {

    let fullName = document.getElementById("fullname").value;
    let userName = document.getElementById("username").value;
    let email = document.getElementById("email").value;
    let phone = document.getElementById("phone").value;

    document.getElementById("display").innerHTML = `
        <b>${fullName}</b><br><br>
        UserName: ${userName}<br>
        Email: ${email}<br>
        Phone: ${phone}
    `;

    document.getElementById("popup").style.display = "block";
    document.getElementById("overlay").style.display = "block";
});

document.getElementById("closeBtn").addEventListener("click", function () {
    document.getElementById("popup").style.display = "none";
    document.getElementById("overlay").style.display = "none";
});
