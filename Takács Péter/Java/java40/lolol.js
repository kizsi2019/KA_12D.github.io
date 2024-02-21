/*var odon = {
    nev: 'Ödön',
    kor: 45,
    foglalkozás: 'csillagász',
    udvozlet: function(stilus, napszakasz){
        if (stilus==='hivatalos'){
            console.log('Üdvözlöm, jó ' + napszakasz + ' kivánok! ' + this.nev +' vagyok ');
        }
        else if(stilus==='baráti'){
            console.log('Szia, jó ' + napszakasz + ' ! ');
        }
    }
}

odon.udvozlet('hivatalos', 'hajnalt');
odon.udvozlet('baráti','estét');

var bela = {
    nev: 'Béla',
    kor: 62,
    foglalkozás: 'portás'
}

odon.udvozlet.call(bela, 'baráti', 'estét');
odon.udvozlet.apply(bela,['baráti', 'reggelt']);

var odonBarati = odon.udvozlet.bind(odon, 'baráti');
odonBarati('napot');
odonBarati('estét');

var belaHivatalos = odon.udvozlet.bind(bela, 'hivatalos');
var belaHivatalosReggeli = odon.udvozlet.bind(bela, 'hivatalos', 'reggelt');

belaHivatalos('estét');
belaHivatalosReggeli();*/
var evek = [1954,1990,1963,2000,2010]
function tombMuvelet(tomb, fv){
    var eredmeny=[];
    for(var i=0;i<tomb.lenght;i++){
        eredmeny.push(fv(tomb[i]));
    }
    return eredmeny;
}
function korszamitas(elem){
    return 2024 - elem;
}
function felnott(korhatar, elem){
    return elem>=korhatar;
}
var korok = tombMuvelet(evek, korszamitas);
console.log(evek);
console.log(korok);

var felnottkorJapanban = tombMuvelet(korok, felnott.bind(this, 20));
console.log(felnottkorJapanban);