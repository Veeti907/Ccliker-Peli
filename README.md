# Ccliker-Peli
Pelin tarkoituksena on, että voit klikata keksiä ja ostaa erilaisia päivityksiä parantaakseen klikkausen voimaa ja saada niin paljon keksejä kuin mahdollista

vuokaavio pelistä:
[(https://osekk-my.sharepoint.com/:i:/g/personal/s4bave00_students_osao_fi/EQRf9qKzfQVJl_EhZANSFTIBtVa8DKyskmSiAcAUPsHQUQ?e=XmJK5f)]


kuvat pelistä:
[(https://osekk-my.sharepoint.com/:i:/g/personal/s4bave00_students_osao_fi/Ef-0e6tbGldBmqa5VO4CCp4Bc9WlFKThKJHB-QI63a5l2w?e=dmvuHj)]
Aloitus näyttö mikä näkyy aina kun aukaiset pelin

[(https://osekk-my.sharepoint.com/:i:/g/personal/s4bave00_students_osao_fi/EWTwoikXHepGoFTQfnJkMZgB9CVEjQpeRRgF_KoBZHgPmw?e=b58KFr)]
kauppa näkymä, joka näkyy kun painaa kauppa nappia

[(https://osekk-my.sharepoint.com/:i:/g/personal/s4bave00_students_osao_fi/Eb8eTU_qUClJgc5FboQZCL8BjD_aX-6Pz9CIgXnlPTwu1Q?e=Ubv1ya)]
tallennus painiketta painettu kuva

```
private void pictureBox1_Click(object sender, EventArgs e)
{
    //kun keksiä klikkaa niin tulee yksi keksi lisää
    balance += 1;
    Keksit.Text = "🍪:" + balance;

    //kerroin mekanismi että keksejä tulee 2 yhdellä klikkausella tai 3, 4...
    if (multiplier > 0)
    {
        balance++;
    }

}
```
tämä koodi on keksin painaminen ja että se antaa 1 keksin aina klikkauksella ja katsoo onko kertoimia ostettu
```
private void OnTimedEvent(Object source, ElapsedEventArgs e)
{
    
    //autoclicker antaa 2 keksiä 3 keksiä jne
    balance++;
    if (multiplier > 0)
    {
        balance += multiplier;
    }

    //päivitetään label automaattisesti
    if (Keksit.InvokeRequired)
    {
        Keksit.Invoke(new Action(() => Keksit.Text = "🍪:" + balance.ToString()));
    }
    else
    {
        Keksit.Text = "🍪:" + balance.ToString();
    }
}
```
tämä koodi on pelin halvin päivitys eli autoclicker, ja tämä autoclicker painaa keksiä automaattisesti joka 5 sekuntti

Jatkokehitysideat:
Voisin lisätä peliin hieman enemmän taustaa ja ulkonäköä. Voisin myös keksiä uusia animaatioita kun keksiä klikataan. Voisin myös keksiä uusia päivityksiä peliin
