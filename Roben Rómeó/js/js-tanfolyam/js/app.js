/*
Játék szabályok:

- A játék 2 szereplős és körökre osztott
- Minden egyes körben az adott játékos dob a kockával, ahányszor csak szeretne. A dobások eredménye hozzáadódik a játékos adott körben
  elért pontszámához, ami értelem szerűen minden körben nulláról indul.
- Ha az aktuális játékos 1-et dob, akkor az összes addigi pontja elveszik, és átadja a dobás jogát a következő játékosnak.
- A játékos választhatja a 'Megtartom' gombot is. Ebben az esetben az adott körben elért pontok száma, hozzáadódik a játékos összes
  pontszámához. Majd a dobás joga a másik játékosra száll.
- Az a játékos nyer, aki előbb eléri a 100 pontot.  

*/


var pontszamok, korPontszam, aktivJatekos ;

pontszamok = [0 , 0];
korPontszam = 0;

aktivJatekos  = 0;



//document.querySelector('#current-' + aktivJatekos).textContent = kocka;
//document.querySelector('#current-' + aktivJatekos).textContent = '<u>' + kocka + '</u>';

document.querySelector('.dice').style.display = 'none';

document.querySelector(".btn-roll").addEventListener('click', function(){

var kocka = Math.floor(Math.random() * 6) + 1;
var kockaDOM = document.querySelector('.dice');
kockaDOM.style.display = 'block';
kockaDOM.src = "img/dice-" + kocka + '.png';
if (kocka !== 1) {
        korPontszam += kocka;
        document.querySelector=('#current-')
        korPontszam = 0;
        }
else{
    aktivJatekos === 0? aktivJatekos = 1 : aktivJatekos = 0;
    korPontszam = 0;
}
    
});