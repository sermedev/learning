import _ from 'underscore';
import{ createDeck, playComputer, playPlayerX} from './usecases'

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

  const initializeGame = (playersCount = 2) => {
    deck          = createDeck(cardTypes, specialCards);
    playersPoints = [];

    for (let i = 0; i < playersCount; i++) {
        playersPoints.push(0);
    }

    playersPointsHtml.forEach(p => p.innerText = 0);
    playersDivCards.forEach(d => d.innerHTML = '');

    btnAsk.disabled = false;
}


  //#region Events

  btnNewGame.addEventListener('click', () => {
      initializeGame(2, deck, cardTypes, specialCards, playersPoints, playersPointsHtml, playersDivCards, btnAsk);
  });

  btnAsk.addEventListener('click', () => {
      btnStop.disabled = false;
      playPlayerX( deck, playersPoints, playersDivCards, playersPointsHtml, 0);
  });

  btnStop.addEventListener('click', () => {
      btnAsk.disabled = true;
      btnStop.disabled = true;
      playComputer( deck, playersPoints, playersDivCards, playersPointsHtml, playersPoints[0]);
  });

  //#endregion
  

  return {
      newGame: initializeGame()
  };

})();