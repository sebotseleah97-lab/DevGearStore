const slider = document.getElementById("productSlider");

let scrollStep = 1;
let maxScroll = slider.scrollWidth - slider.clientWidth;

function autoSlide() {
    slider.scrollLeft += scrollStep;

    if (slider.scrollLeft >= maxScroll) {
        slider.scrollLeft = 0;
    }
}

setInterval(autoSlide, 20); // smaller = smoother
