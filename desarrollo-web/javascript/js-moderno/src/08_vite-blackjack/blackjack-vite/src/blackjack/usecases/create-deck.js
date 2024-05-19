import _ from 'underscore';

/**
 * This function create a new deck
 * @param {Array<String>} cardTypes Example: ['C', 'D', 'H', 'S']
 * @param {Array<String>} specialCards Example: ['A', 'J', 'Q', 'K']
 * @returns {Array<String>}  returns a new deck. Example ['7S', '8C', 'KS', '5S', 'QS', '5C', '8H', '2C', '10C', '8S', '6S', 'AD', '10S', 'QC', '10D', 'KH', '3S', '2D', 'KC', '4H', 'AC', '5D', '2S', '4D', '5H', '9C', '3H', '4S', '10H', 'JH', 'JD', 'QH', '2H', '3D', '8D', 'QD', '6C', '6D', '9D', '7C', 'AS', '4C', '7D', '6H', '3C', 'JS', 'JC', '7H', 'KD', '9H', '9S', 'AH']
 */
export const createDeck = ( cardTypes, specialCards) => {

    if(!cardTypes || cardTypes.length === 0) 
        throw new Error('cardTypes is required');
    if(!specialCards || specialCards.length === 0) 
        throw new Error('specialCards is required');

    var deck = [];

    for (let i = 2; i <= 10; i++) {
        for (let type of cardTypes) {
            deck.push(i + type);
        }
    }

    for (let type of cardTypes) {
        for (let special of specialCards) {
            deck.push(special + type);
        }
    }

    return _.shuffle(deck);
}