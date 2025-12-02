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

// Close sidebar on overlay click
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