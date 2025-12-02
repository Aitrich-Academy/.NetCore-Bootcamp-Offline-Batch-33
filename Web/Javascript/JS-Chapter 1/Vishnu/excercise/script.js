// Select elements
const form = document.getElementById("loginForm");
const emailInput = document.getElementById("email");
const passwordInput = document.getElementById("password");
const emailError = document.getElementById("emailError");
const passwordError = document.getElementById("passwordError");
const togglePasswordBtn = document.getElementById("togglePassword");


function isValidEmail(email) {
  const pattern = /^[^@\s]+@[^@\s]+\.[^@\s]+$/;
  return pattern.test(email);
}


function isValidPassword(password) {
  return password.length >= 8;
}


function clearErrors() {
  emailError.textContent = "";
  passwordError.textContent = "";
  emailInput.classList.remove("invalid");
  passwordInput.classList.remove("invalid");
}


form.addEventListener("submit", function (e) {
  e.preventDefault(); // prevent real submit

  clearErrors();

  let hasError = false;

  if (emailInput.value.trim() === "") {
    emailError.textContent = "Email is required.";
    emailInput.classList.add("invalid");
    hasError = true;
  } else if (!isValidEmail(emailInput.value.trim())) {
    emailError.textContent = "Please enter a valid email (e.g. user@example.com).";
    emailInput.classList.add("invalid");
    hasError = true;
  }


  if (passwordInput.value.trim() === "") {
    passwordError.textContent = "Password is required.";
    passwordInput.classList.add("invalid");
    hasError = true;
  } else if (!isValidPassword(passwordInput.value.trim())) {
    passwordError.textContent = "Password must be at least 8 characters.";
    passwordInput.classList.add("invalid");
    hasError = true;
  }


  if (!hasError) {
    alert("Login successful! ");

  }
});

