import { playComputer } from "./play-computer";
import { createCard } from "./create-card";
import { askCard } from "./ask-card";
import { collectPoints } from "./collect-points";


export const playPlayerX = (deck, playersPoints, playersDivCards, playersPointsHtml, playerTurn) => {

    const card         = askCard( deck ),
          playerPoints = collectPoints(card, playerTurn, playersPoints, playersPointsHtml);

    createCard(card, playerTurn, playersDivCards);

    if (playerPoints > 21) {
        btnAsk.disabled  = true;
        btnStop.disabled = true;
        playComputer(deck, playersPoints, playersDivCards, playersPointsHtml, 0);
    } else if (playerPoints === 21) {
        btnAsk.disabled  = true;
        btnStop.disabled = true;
        playComputer(deck, playersPoints, playersDivCards, playersPointsHtml, playersPoints[0]);
    }
}
