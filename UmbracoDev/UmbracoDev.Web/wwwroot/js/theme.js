
(function () {
    let storedTheme = localStorage.getItem('theme') || 'light';
    document.documentElement.setAttribute('data-theme', storedTheme);
    localStorage.setItem('theme', storedTheme);
})();