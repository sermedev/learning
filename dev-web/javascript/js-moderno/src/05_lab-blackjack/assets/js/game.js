const blackJackModule = (() => {
    'use strict'


    //#region Properties

    const cardTypes    = ['C', 'D', 'H', 'S'],
          specialCards = ['A', 'J', 'Q', 'K'];

    let deck          = [],
        playersPoints = [];

    //#endregion


    //#region HTML-Refs

    const btnAsk   = document.querySelector('#btnAsk'),
        btnNewGame = document.querySelector('#btnNewGame'),
        btnStop    = document.querySelector('#btnStop');

    const playersPointsHtml = document.querySelectorAll('small'),
        playersDivCards     = document.querySelectorAll('.divCards');

    //#endregion


    //#region Functions

    const initializeGame = (playersCount = 2) => {
        deck          = createDeck();
        playersPoints = [];

        for (let i = 0; i < playersCount; i++) {
            playersPoints.push(0);
        }

        playersPointsHtml.forEach(p => p.innerText = 0);
        playersDivCards.forEach(d => d.innerHTML = '');

        btnAsk.disabled = false;
    }

    const createDeck = () => {
        deck = [];

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

    const askCard = () => {

        if (deck.length === 0) {
            throw 'No more cards in deck';
        }

        return deck.pop();
    }

    const getCardValue = (card) => {

        const value = card.substring(0, card.length - 1);
        return (isNaN(value)) ?
            (value === 'A') ? 11 : 10
            : value * 1;
    }

    // Turn: 0 = firt player and last one = computer
    const collectPoints = (card, turn) => {
        const p = getCardValue(card);
        playersPoints[turn] += p;
        playersPointsHtml[turn].innerText = playersPoints[turn];

        return playersPoints[turn];
    }

    const createCard = (card, turn) => {
        const cardImg = document.createElement('img');
        cardImg.classList.add('cards');
        cardImg.src = `assets/cards/${card}.png`;

        playersDivCards[turn].append(cardImg);
    }

    const playComputer = (minimunPoints) => {

        let computerPoints = 0,
            computerTurn   = playersPoints.length - 1;

        do {
            const card           = askCard();
            computerPoints = collectPoints(card, computerTurn);
            createCard(card, computerTurn);

            if (minimunPoints > 21) {
                break;
            }

        } while ((minimunPoints < 21) && (computerPoints < minimunPoints));


        defineWhoWins();
    };

    const defineWhoWins = () => {

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

    const playPlayerX = (playerTurn) => {

        const card         = askCard(),
              playerPoints = collectPoints(card, playerTurn);

        createCard(card, playerTurn);

        if (playerPoints > 21) {
            btnAsk.disabled  = true;
            btnStop.disabled = true;
            playComputer(playerPoints);

        } else if (playerPoints === 21) {
            btnAsk.disabled  = true;
            btnStop.disabled = true;
            playComputer(playerPoints);
        }
    }

    //#endregion


    //#region Events

    btnNewGame.addEventListener('click', () => {
        initializeGame();
    });

    btnAsk.addEventListener('click', () => {
        btnStop.disabled = false;
        playPlayerX(0);
    });

    btnStop.addEventListener('click', () => {
        btnAsk.disabled = true;
        btnStop.disabled = true;
        playComputer(playersPoints[0]);
    });

    //#endregion
    

    return {
        newGame: initializeGame
    };

})();