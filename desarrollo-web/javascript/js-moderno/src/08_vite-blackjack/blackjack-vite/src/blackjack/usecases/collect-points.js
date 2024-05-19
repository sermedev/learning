import { getCardValue } from "./get-card-value";

/**
 * 
 * @param {String} card 
 * @param {Number} turn 
 * @param {String<Number>} playersPoints 
 * @param {HTMLElement} playersPointsHtml 
 * @returns 
 */
export const collectPoints = (card, turn, playersPoints, playersPointsHtml) => {
    const p = getCardValue(card);
    playersPoints[turn] += p;
    playersPointsHtml[turn].innerText = playersPoints[turn];
    
    return playersPoints[turn];
}

