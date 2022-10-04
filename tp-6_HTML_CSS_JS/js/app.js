const aditional = document.getElementById("aditional");
const age = document.getElementById("age");
const nameForm = document.getElementById("name");
const lastNameForm = document.getElementById("lastName");
const errorName = document.getElementById("errorName");
const errorLastName = document.getElementById("errorLastName");
errorName.style.color = "white";
errorLastName.style.color = "white";
errorName.style.fontSize = "11px";
errorLastName.style.fontSize = "11px";

function sendForm() {
  let msgName = [];
  let msgLastName = [];

  if (nameForm.value === null || nameForm.value === "") {
    msgName.push("Ingrese su nombre...");
  }

  if (lastNameForm.value === null || lastNameForm.value === "") {
    msgLastName.push("Ingrese su apellido...");
  }
  errorName.innerHTML = msgName.join(", ");
  errorLastName.innerHTML = msgLastName.join(", ");
  return false;
}

function deleteForm() {
  nameForm.value = "";
  lastNameForm.value = "";
  age.value = "";
  aditional.value = "";
}
