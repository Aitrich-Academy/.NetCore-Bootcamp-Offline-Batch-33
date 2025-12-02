function openChat(name, img) {
  document.getElementById("chatName").innerText = name;
  document.getElementById("chatPic").src = img;

  document.querySelectorAll('.msg-person').forEach(el => el.classList.remove("active-chat"));
  event.currentTarget.classList.add("active-chat");

  document.getElementById("chatBox").innerHTML = `
      <div class="chat-message left">Hi ${name.split(" ")[0]}, how can I help you?</div>
      <div class="chat-message right">Just checking the status of my application.</div>
  `;
}

function sendMessage() {
  let input = document.getElementById("chatInput");
  let msg = input.value.trim();
  if (msg === "") return;

  let bubble = `<div class="chat-message right">${msg}</div>`;

  document.getElementById("chatBox").innerHTML += bubble;
  input.value = "";
  input.focus();

  let box = document.getElementById("chatBox");
  box.scrollTop = box.scrollHeight;
}

const sidebar = document.querySelector('.sidebar');
const toggle = document.querySelector('.menu-toggle');
const headerTitle = document.querySelector('.headerTitle');
const overlay = document.querySelector('.overlay');
const menuItems = document.querySelectorAll('.menu-item, .menu-item1');

// Toggle sidebar open
if (toggle) {
  toggle.onclick = () => {
    sidebar?.classList.toggle('show');
    overlay?.classList.toggle('show');
    document.body.classList.toggle('sidebar-open');
  };
}

if (overlay) {
  overlay.onclick = () => {
    sidebar?.classList.remove('show');
    overlay.classList.remove('show');
    document.body.classList.remove('sidebar-open');
  };
}

// Menu item click behavior
menuItems.forEach(item => {
  item.onclick = () => {
    menuItems.forEach(i => i.classList.remove('active'));
    item.classList.add('active');
    
    if (headerTitle) {
      headerTitle.textContent = item.dataset.title;
    }

    if(window.innerWidth < 992){
      sidebar?.classList.remove('show');
      overlay?.classList.remove('show');
      document.body.classList.remove('sidebar-open');
    }
  };
});

// Navigation handlers
document.getElementById("applyJobBtn")?.addEventListener('click', () => {
  window.location.href = "apply jobs.html";
});

document.getElementById("allJob")?.addEventListener('click', () => {
  window.location.href = "all jobs.html";
});

document.getElementById("myApplication")?.addEventListener('click', () => {
  window.location.href = "my application.html";
});

document.getElementById("messages")?.addEventListener('click', () => {
  window.location.href = "messages.html";
});

document.getElementById("myProfile")?.addEventListener('click', () => {
  window.location.href = "my profile.html";
});

document.getElementById("settings")?.addEventListener('click', () => {
  window.location.href = "settings.html";
});

// Show profile card on Add New Profile click
const addNewBtn = document.querySelector(".add-new-btn");
if (addNewBtn) {
  addNewBtn.onclick = () => {
    const profileCard = document.getElementById("profileCard");
    if (profileCard) {
      profileCard.style.display = "block";
      window.scrollTo({ top: profileCard.offsetTop - 20, behavior: "smooth" });
    }
  };
}

// Save profile
const saveProfileBtn = document.getElementById("saveProfile");
if (saveProfileBtn) {
  saveProfileBtn.onclick = () => {
    alert("Profile added successfully!");
    const profileCard = document.getElementById("profileCard");
    if (profileCard) {
      profileCard.style.display = "none";
    }
  };
}