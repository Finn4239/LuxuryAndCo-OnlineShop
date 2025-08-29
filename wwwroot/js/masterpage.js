const onToggleLanguage = (currentLang) => {
    window.location.href = currentLang === 'en' ? '/de' : '/';
    
    const toggleFlagButton = document.getElementById('flag-toggle');
    toggleFlagButton.setAttribute('data-language', currentLang);
    languageFlag.className = currentLang === 'en' ? "fi fi-gb" : "fi fi-de";
}