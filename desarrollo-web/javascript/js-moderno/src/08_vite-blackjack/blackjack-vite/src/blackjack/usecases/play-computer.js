import { min } from "underscore";
import { askCard } from "./ask-card";
import { collectPoints } from "./collect-points";
import { createCard } from "./create-card";
import { defineWhoWins } from "./define-who-wins";


export const playComputer = (deck, playersPoints, playersDivCards, playersPointsHtml, minimunPoints = 0) => {

    if (!deck || deck.length === 0) throw 'No more cards in deck';

    let computerPoints = 0,
        computerTurn   = playersPoints.length - 1;

    do {
        const card     = askCard(deck);
        computerPoints = collectPoints(card, computerTurn, playersPoints, playersPointsHtml );
        createCard(card, computerTurn, playersDivCards );

        if (minimunPoints > 21) {
            break;
        }

    } while ((minimunPoints < 21) && (computerPoints < minimunPoints));

    defineWhoWins( playersPoints );
};

