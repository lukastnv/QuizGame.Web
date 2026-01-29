document.addEventListener("DOMContentLoaded", function () {

    const timerText = document.getElementById("timer-text");
    const timerCircle = document.getElementById("timer-circle");
    const form = document.getElementById("questionForm");
    const page = document.getElementById("page"); // agora só existe no Layout
    const scoreEl = document.getElementById("score");

    if (!timerText || !timerCircle || !form || !page) return;

    /* TIMER */
    let totalTime = parseInt(timerText.innerText);
    let timeLeft = totalTime;

    const radius = 40;
    const circumference = 2 * Math.PI * radius;

    timerCircle.style.strokeDasharray = circumference;
    timerCircle.style.strokeDashoffset = 0;

    /* SONS */
    const correctSound = new Audio("/sounds/correct.mp3");
    const wrongSound = new Audio("/sounds/wrong.mp3");

    /* CONTADOR */
    const interval = setInterval(() => {
        timeLeft--;
        timerText.innerText = timeLeft;

        const offset =
            circumference - (timeLeft / totalTime) * circumference;

        timerCircle.style.strokeDashoffset = offset;

        if (timeLeft <= 5) {
            timerCircle.style.stroke = "#dc3545";
        }

        if (timeLeft <= 0) {
            clearInterval(interval);
            fadeAndSubmit(form, page);
        }
    }, 1000);

    /* CLICK NA RESPOSTA */
    document.querySelectorAll(".answer-option").forEach(option => {
        option.addEventListener("click", () => {
            option.querySelector("input").checked = true;

            document.querySelectorAll(".answer-option")
                .forEach(o => o.classList.remove("selected"));

            option.classList.add("selected");
        });
    });

    /* SUBMIT */
    form.addEventListener("submit", function (e) {
        e.preventDefault();
        clearInterval(interval);

        const answers = document.querySelectorAll(".answer-option");
        const selected = document.querySelector("input[name='selectedAnswerId']:checked");

        if (!selected) return;

        let isCorrect = selected.dataset.correct === "True";

        answers.forEach(option => {
            const input = option.querySelector("input");

            if (input.dataset.correct === "True") {
                option.classList.add("answer-correct");
            }

            if (input === selected && !isCorrect) {
                option.classList.add("answer-wrong");
            }
        });

        if (isCorrect) {
            correctSound.play().catch(() => { });
            scoreEl?.classList.add("score-pop");
            setTimeout(() => scoreEl?.classList.remove("score-pop"), 300);
        } else {
            wrongSound.play().catch(() => { });
            page.classList.add("shake");
            setTimeout(() => page.classList.remove("shake"), 300);
        }

        showFeedback(isCorrect);
        setTimeout(() => fadeAndSubmit(form, page), 900);
    });
});

/* FEEDBACK RÁPIDO */
function showFeedback(isCorrect) {
    const overlay = document.createElement("div");
    overlay.className = `question-feedback ${isCorrect ? "correct" : "wrong"}`;
    overlay.innerText = isCorrect ? "✔ CERTO!" : "✖ ERRO!";

    document.body.appendChild(overlay);
    setTimeout(() => overlay.remove(), 700);
}

/* TRANSIÇÃO */
function fadeAndSubmit(form, page) {
    page.classList.add("fade-out");
    setTimeout(() => form.submit(), 400);
}
