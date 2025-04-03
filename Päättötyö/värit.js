// Valitaan elementit
const colorButtons = document.querySelectorAll('.col-sm');
const surfaces = document.querySelectorAll('.test-surface');
const clearButton = document.getElementById('clear-btn');

let selectedSurfaceIndex = 0; // 0 = Pinta 1, 1 = Pinta 2

// Kuunnellaan värin valintaa
colorButtons.forEach(button => {
    button.addEventListener('click', () => {
        const selectedColor = button.style.backgroundColor;

        // Vaihda valitun pinnan väriä
        surfaces[selectedSurfaceIndex].style.backgroundColor = selectedColor;

        // Vaihda seuraavaan pintaan
        selectedSurfaceIndex = (selectedSurfaceIndex + 1) % surfaces.length;
    });
});

// Tyhjennä värit
clearButton.addEventListener('click', () => {
    surfaces.forEach(surface => {
        surface.style.backgroundColor = ''; // Tyhjä arvo poistaa värin
    });
    selectedSurfaceIndex = 0; // Palautetaan valinta ensimmäiseen pintaan
});