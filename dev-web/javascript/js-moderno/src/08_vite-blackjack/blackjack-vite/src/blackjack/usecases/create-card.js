export const createCard = (card, turn, playersDivCards) => {
    const cardImg = document.createElement('img');
    cardImg.classList.add('cards');
    cardImg.src = `assets/cards/${card}.png`;

    playersDivCards[turn].append(cardImg);
}
