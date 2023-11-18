var pontszamok, korpontszam, aktivJatekos;
pontszamok = [0,0];
korpontszam = 0;
aktivJatekos = 0;
document.querySelector('.dice').style.display = 'none';
document.getElementById('score-0').textContent = '0';
document.getElementById('current-0').textContent = '0';
document.getElementById('score-1').textContent = '0';
document.getElementById('current-1').textContent = '0';
document.querySelector('.btn-roll').addEventListener('click', function() 
{
  var kocka = Math.floor(Math.random() * 6) + 1;
  var kockaDOM = document.querySelector('.dice');
  kockaDOM.style.display = 'block';
  kockaDOM.src = 'img/dice-' + kocka + '.png';
  if (kocka !== 1) 
  {
      korpontszam += kocka;
      document.querySelector('#current-' + aktivJatekos).textContent = korpontszam;
  }
  else 
  {
      kovetkezoJatekos();
  }
});
document.querySelector('.btn-hold').addEventListener('click', function() 
{
    pontszamok[aktivJatekos] += korpontszam;
    if (pontszamok[aktivJatekos] >= 20) 
    {
        document.querySelector('#name-' + aktivJatekos).textContent = 'Győztes!';
        document.querySelector('#name-' + aktivJatekos + '-panel').classList.add('winner');
        document.querySelector('#name-' + aktivJatekos + '-panel').classList.remove('active');
    }
    else 
    {
        kovetkezoJatekos();
    }
});
function kovetkezoJatekos() 
{
    aktivJatekos === 0 ? aktivJatekos = 1 : aktivJatekos = 0;
    korpontszam = 0;
    document.getElementById('current-0').textContent = '0';
    document.getElementById('current-1').textContent = '0';
    document.getElementById('.player-0-panel').classList.toggle('active');
    document.getElementById('.player-1-panel').classList.toggle('active'); 
    document.querySelector('.dice').style.display = 'none';
}