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
    overlay?.classList.remove('show');
    document.body?.classList.remove('sidebar-open');
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
      document.body?.classList.remove('sidebar-open');
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
      setTimeout(() => {
        profileCard.scrollIntoView({ behavior: 'smooth', block: 'start' });
      }, 200);
    }
  };
}

// Save profile
const saveProfileBtn = document.getElementById("saveProfile");
if (saveProfileBtn) {
  saveProfileBtn.onclick = () => {
    const profileCard = document.getElementById("profileCard");
    if (!profileCard) return;

    const nameInput = profileCard.querySelector("input[type='text']");
    const summaryInput = profileCard.querySelector("textarea");
    
    if (!nameInput || !summaryInput) {
      alert("Form fields not found");
      return;
    }
    
    const name = nameInput.value.trim();
    const summary = summaryInput.value.trim();

    // Validate inputs
    if(name === ""){
      alert("Please enter a profile name");
      return;
    }

    if(summary === ""){
      alert("Please enter a profile summary");
      return;
    }

    createProfileCard(name, summary);
    alert("Profile added successfully!");
    profileCard.style.display = "none";
    nameInput.value = "";
    summaryInput.value = "";
  };
}

// DATA CONTAINER
const profileContainer = document.querySelector(".main");

// Generate new profile card function with TWO CARDS
function createProfileCard(name, summary) {
  if (!profileContainer) {
    alert("Profile container not found");
    return;
  }

  const container = document.createElement("div");
  container.style.display = "flex";
  container.style.gap = "20px";
  container.style.justifyContent = "center";
  container.style.flexWrap = "wrap";
  container.style.margin = "20px 0";

  // FIRST CARD - User's profile
  const card1 = document.createElement("div");
  card1.className = "profile-box";
  card1.style.cssText = `
    background:white; 
    border-radius:20px; 
    padding:20px; 
    width:350px;
    box-shadow:0 4px 12px rgba(0,0,0,.1);
  `;
  card1.innerHTML = `
    <h5 style="background:#007bff;color:white;padding:12px;border-radius:8px;text-align:center;">
      .Net Developer
    </h5>
    <p>${name}</p>
    <p>${summary}</p>
    <button class="btn btn-success w-100 mb-3 viewBtn">View Profile</button>
    <label class="fw-semibold">Choose Resume file</label>
    <input type="file" class="form-control mb-3">
    <button class="btn btn-primary w-100">Upload Resume</button>
  `;

  // SECOND CARD - Default DevOps profile
  const card2 = document.createElement("div");
  card2.className = "profile-box";
  card2.style.cssText = `
    background:white; 
    border-radius:20px; 
    padding:20px; 
    width:350px;
    box-shadow:0 4px 12px rgba(0,0,0,.1);
  `;
  card2.innerHTML = `
    <h5 style="background:#007bff;color:white;padding:12px;border-radius:8px;text-align:center;">
      DevOps Engineer
    </h5>
    <p>${name}</p>
    <p>${summary}</p>
    <button class="btn btn-success w-100 mb-3 viewBtn">View Profile</button>
    <label class="fw-semibold">Choose Resume file</label>
    <input type="file" class="form-control mb-3">
    <button class="btn btn-primary w-100">Upload Resume</button>
  `;

  container.appendChild(card1);
  container.appendChild(card2);
  profileContainer.appendChild(container);
}