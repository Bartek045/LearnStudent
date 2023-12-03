const meter = document.getElementById("progress--circle");
const meterProgress = document.getElementById("meter--progress");
const ranger = document.getElementById("meter--ranger");
const insideText = document.getElementById("progress--text");

ranger.addEventListener("input", e => {
    const rangeValue = e.target.value;

    meterProgress.innerText = `${rangeValue}%`;
    insideText.textContent = `${rangeValue}%`;
    meter.style.strokeDashoffset = 100 - rangeValue;

    if (rangeValue === "0") {
        meter.style.stroke = "none";
    } else {
        meter.style.stroke = "#28411B";
    }
});

ranger.addEventListener("wheel", e => {
    e.preventDefault();

    const isWheelPositive = () => e.deltaY > 0;

    if (isWheelPositive()) {
        let rangerValue = +ranger.value;
        ranger.value = rangerValue += 1;
    } else {
        ranger.value -= 1;
    }

    // Trigger the above (:6) event listener manually  
    ranger.dispatchEvent(new Event("input"));
});

document.addEventListener("DOMContentLoaded", () => {
    ranger.dispatchEvent(new Event("input"));
});