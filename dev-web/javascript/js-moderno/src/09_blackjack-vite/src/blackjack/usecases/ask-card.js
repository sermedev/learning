/**
 * This function returns a card of a deck and make pop
 * @param {Array<String>} deck is array of string. Example ['7S', '8C', 'KS', '5S', 'QS', '5C', '8H', '2C', '10C', '8S', '6S', 'AD', '10S', 'QC', '10D', 'KH', '3S', '2D', 'KC', '4H', 'AC', '5D', '2S', '4D', '5H', '9C', '3H', '4S', '10H', 'JH', 'JD', 'QH', '2H', '3D', '8D', 'QD', '6C', '6D', '9D', '7C', 'AS', '4C', '7D', '6H', '3C', 'JS', 'JC', '7H', 'KD', '9H', '9S', 'AH']
 * @returns {String} returns a card of deck
 */
export const askCard = (deck) => {

    if (!deck || deck.length === 0) {
        throw 'No more cards in deck';
    }

    return deck.pop();
}