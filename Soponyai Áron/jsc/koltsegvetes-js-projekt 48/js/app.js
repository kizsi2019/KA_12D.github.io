//Koltsegvetesvezerlo
var koltsegvetesvezerlo = (function(){
    
})();
//feluletvezerlo
var feluletvezerlo = (function(){
    var DOMElemek = {
        inputTipus: '.hozzaad__tipus',
        inputLeiras: '.hozzaad__leiras',
        inputErtek: '.hozzaad__ertek',
        inputGomb: '.hozzaad__gomb'
    }
    return {
        getInput: function(){
            return{
                tipus: document.querySelector(DOMElemek.inputTipus).value,
                leiras: document.querySelector(DOMElemek.inputLeiras).value,
                ertek: document.querySelector(DOMElemek.inputErtek).value
            }

        },
        getDOMElemek: function(){
            return DOMElemek;
        }
    }

})();

// alkalmazasvezerlo
var vezerlo = (function(koltsegvetesvez, feluletvez){
var DOM = feluletvezerlo.getDOMElemek();
vezTetelHozzaadas = function(){
    // 1. bevitt adatok megszerzese 
    var input = feluletvezerlo.getInput();
    console.log(input);
    
    // 2. adatok atadasa a koltsegvetesvezerlo modulnak
    
    // 3. megjelenites ui-n
    
    // 4. koltsegvetes ujraszamolasa

    // 5. osszeg megjelenitese a feluleten
}
document.querySelector(DOM.inputGomb).addEventListener('click', vezTetelHozzaadas);


   


document.addEventListener('keydown', function(event){
    if (event.key !== undefined && event.key === 'Enter'){
        vezTetelHozzaadas();
    }
    else if (event.keyCode !== undefined && event.keyCode === 13){
        vezTetelHozzaadas();
    }

})

})(koltsegvetesvezerlo, feluletvezerlo);



