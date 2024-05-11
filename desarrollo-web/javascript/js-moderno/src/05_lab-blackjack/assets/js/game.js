// //#region Info

/**
 * 2C = Two of Clubs (Tréboles)
 * 2D = Two of Diamons (Diamantes)
 * 2H = Two of Hearts (Corazones)
 * 2S = Two of Spades (Picas)
 */

//#endregion


//#region Properties

const cardTypes = ['C', 'D', 'H', 'S'];
const specialCards = ['A', 'J', 'Q', 'K'];

let deck = [];
let playerPoints = 0;
let pcPoints = 0;

//#endregion


//#region HTML-Refs

const btnAsk     = document.querySelector('#btnAsk');
const btnNewGame = document.querySelector('#btnNewGame');
const btnStop = document.querySelector('#btnStop');

const playerCounterPoints = document.querySelector('#player-counter-points');
const playerDivCards      = document.querySelector('#player-cards');

const pcCounterPoints = document.querySelector('#pc-counter-points');
const pcDivCards      = document.querySelector('#pc-cards');

//#endregion


//#region Functions

const createDeck = () => {

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

    deck = _.shuffle(deck);

    return deck;
}

const askCard = () => {

    if (deck.length === 0) {
        throw 'No more cards in deck';
    }

    const card = deck.pop();

    return card;
}

const getCardValue = (card) => {

    const value = card.substring(0, card.length - 1);
    return  ( isNaN(value) ) ?
            ( value === 'A') ? 11 : 10
            : value * 1;
}

const playPc = ( minimunPoints ) => {
    
    do{
        const card = askCard();
        pcPoints += getCardValue(card);
        pcCounterPoints.textContent = pcPoints;

        const cardImg = document.createElement('img');
        cardImg.classList.add('cards');
        cardImg.src = `assets/cards/${ card }.png`;
        pcDivCards.append(cardImg);

        if (minimunPoints > 21){
            break;
        }

    }while ((minimunPoints < 21) && (pcPoints < minimunPoints)); 
        

    setTimeout(() => {
        
        if(pcPoints === minimunPoints ){
            alert('Empate 🥲');
        }else if (minimunPoints > 21){
            alert('Perdiste ☹️');
        }else if(pcPoints > 21 || minimunPoints > pcPoints){
            alert('Ganaste 😀');
        }else{
            alert('Perdiste ☹️');
        };
    }, 300);
};

//#endregion


//#region Events

btnAsk.addEventListener('click', () => {

    btnStop.disabled = false;

    const card = askCard();
    playerPoints += getCardValue( card);
    playerCounterPoints.textContent = playerPoints;

    const cardImg = document.createElement('img');
    cardImg.classList.add('cards');
    cardImg.src = `assets/cards/${ card }.png`;
    playerDivCards.append(cardImg);

    if(playerPoints > 21){
        console.log('Lo siento mucho, perdiste');
        btnAsk.disabled = true;
        btnStop.disabled = true;
        playPc(playerPoints);
    }else if(playerPoints === 21){
        console.log('21, ganaste!!!');
        btnAsk.disabled = true;
        btnStop.disabled = true;
        playPc(playerPoints);
    }
    
});

btnStop.addEventListener('click', () => {
    btnAsk.disabled = true;
    btnStop.disabled = true;
    playPc(playerPoints);
});


btnNewGame.addEventListener('click', () => {
    createDeck();

    playerPoints = 0;
    playerCounterPoints.textContent = playerPoints;
    
    pcPoints = 0;
    pcCounterPoints.textContent = pcPoints;

    btnAsk.disabled = false;

    playerDivCards.innerHTML = '';
    pcDivCards.innerHTML = '';
});


//#endregion



// Initialization when page loading
btnAsk.disabled = true;
btnStop.disabled = true;
