function applyTheme(theme) {
    document.documentElement.setAttribute('data-theme', theme);
    localStorage.setItem('theme', theme);
}

document.getElementById('theme-toggle').addEventListener('click', function () {
    let currentTheme = localStorage.getItem('theme') || 'light';
    let newTheme = currentTheme === 'light' ? 'dark' : 'light';
    applyTheme(newTheme);
});

(function () {
    let storedTheme = localStorage.getItem('theme') || 'light';
    document.getElementById('theme-toggle').checked = storedTheme === 'dark';
})();
