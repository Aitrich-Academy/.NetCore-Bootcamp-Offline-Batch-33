const buttons = document.querySelectorAll(".btn");

buttons.forEach(function(button) {
  button.addEventListener("click", function() {

    // popup
    const popup = document.createElement("div");
    popup.style.width = "250px";
    popup.style.backgroundColor = "white";
    popup.style.border = "2px solid black";
    popup.style.padding = "20px";
    popup.style.textAlign = "center";
    popup.style.position = "relative";
    popup.style.left = "570px";

    // message
    const message = document.createElement("p");
    message.innerText = "Are you sure you want to book?";
    popup.appendChild(message);

    // confirmation button
    const confirmBtn = document.createElement("button");
    confirmBtn.innerText = "Confirm";
    confirmBtn.style.backgroundColor = "red";
    confirmBtn.style.color = "white";
    confirmBtn.style.border = "none";
    confirmBtn.style.padding = "10px 20px";
    confirmBtn.style.cursor = "pointer";
    confirmBtn.style.marginTop = "10px";

    // Change color on click
    confirmBtn.addEventListener("click", function () {
      confirmBtn.style.backgroundColor = "green";
      confirmBtn.innerText = "Booked";
    });

    popup.appendChild(confirmBtn);
    document.body.appendChild(popup);
  });
});