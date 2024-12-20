export const defineWhoWins = ( playersPoints ) => {

    const [minimunPoints, computerPoints] = playersPoints;

    setTimeout(() => {

        if (computerPoints === minimunPoints) {
            alert('Empate 🤝');
        } else if (minimunPoints > 21) {
            alert('Perdiste ☠️');
        } else if (computerPoints > 21 || minimunPoints > computerPoints) {
            alert('Ganaste 🏆');
        } else {
            alert('Perdiste ☹️');
        };
    }, 300);
}
