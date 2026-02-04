let slider;
let scrollStep = 1;
let intervalTime = 20;

function autoSlide() {
    if (!slider) return;

    slider.scrollLeft += scrollStep;

    // When it reaches the end, start again
    if (slider.scrollLeft >= slider.scrollWidth - slider.clientWidth) {
        slider.scrollLeft = 0;
    }
}

// Make sure the page loads first
window.onload = () => {
    slider = document.getElementById("productSlider");

    if (slider) {
        setInterval(autoSlide, intervalTime);
    } else {
        console.log("Slider element not found!");
    }
};
