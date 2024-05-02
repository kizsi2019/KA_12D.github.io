// let, const
// ES5
/*
var nev5 = 'Vicc Elek';
var kor5 = 40;

nev5 = 'Abbanapillanatban Debrüi'

console.log(nev5);

function nyelvVizsga5(siker) {
    if (siker) {
        var keresztnev = 'Gizi';
        var szuletesiEv = 1980;
        console.log(keresztnev + '(születési év: ' + szuletesiEv + ') sikeres volt a vizsga');
    }
}
nyelvVizsga5(true);


// ES6

const nev6 = 'Fing Ottam';
let kor6 = 40;

// nev6 = 'Kiss Pista'; // Hibát dob
// console.log(nev6);

function nyelvVizsga6(siker) {
    if (siker) {
        var keresztnev = 'Trottyos';
        const szuletesiEv = 1985;
        console.log(keresztnev + '(születési év: ' + szuletesiEv + ') sikeres volt a vizsga');
    }
}
nyelvVizsga6(true);


let i = 9;
for (let i = 0; i < 5; i++) {
    console.log(i);
}
console.log(i);

var i = 9;
for (var i = 0; i < 5; i++) {
    console.log(i);
}
console.log(i);


////////////////////////////////////////////////////////////////
// Blokkok és IIFE
// ES6

{
    const a = 1;
    let b = 2;
    // var c = 3;
}
// console.log(a + b);

// ES5

(function() {
    let c = 3;
    console.log(c);
})();
console.log(c);

*/
////////////////////////////////////////////////////////////////
// Sztringek ES6-ban

let vezetekNev = 'Micc';
let keresztNev = 'Elek';

const szuletesiEv = 1970;

function korszamitas(ev) {
    return 2024 - ev;
}

// ES5
console.log(vezetekNev + ' ' + keresztNev + ' ' + szuletesiEv + '-ben született. Most ' + korszamitas(szuletesiEv) + ' éves.');

// ES6
console.log(`${vezetekNev} ${keresztNev}, született ${szuletesiEv}-ben. Most ${korszamitas(szuletesiEv)} éves.`);

const nev = `${vezetekNev} ${keresztNev}`;

console.log(nev.startsWith('M'));
console.log(nev.endsWith('ek'));
console.log(nev.includes('icc'));
console.log(vezetekNev.repeat(3));
console.log(`${vezetekNev} `.repeat(3));