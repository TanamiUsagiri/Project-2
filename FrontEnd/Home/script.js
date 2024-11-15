document.addEventListener("DOMContentLoaded", () => {
    const startButton = document.querySelector(".start-btn");
    const introContainer = document.querySelector(".intro-container");
    const mainContent = document.getElementById("content");

    // Hiệu ứng intro khi bấm nút "Enter"
    startButton.addEventListener("click", () => {
        introContainer.style.opacity = "0";
        setTimeout(() => {
            introContainer.classList.add("d-none");
            mainContent.classList.remove("d-none");
            mainContent.style.opacity = "1";
        }, 1000); // Thời gian trùng với transition của intro
    });
});
