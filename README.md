# Ccliker-Peli
Pelin tarkoituksena on, että voit klikata keksiä ja ostaa erilaisia päivityksiä parantaakseen klikkausen voimaa ja saada niin paljon keksejä kuin mahdollista

vuokaavio pelistä:
[(https://osekk-my.sharepoint.com/:i:/g/personal/s4bave00_students_osao_fi/EQRf9qKzfQVJl_EhZANSFTIBtVa8DKyskmSiAcAUPsHQUQ?e=XmJK5f)]



    Aloitusnäyttö
Aloitus näyttö mikä näkyy aina kun aukaiset pelin
![cclicker1](https://github.com/user-attachments/assets/e24d1d48-9a0f-4ed0-a36e-acc7b3863134)


    Kauppanäkymä
kauppa näkymä, joka näkyy kun painaa kauppa nappia
![cclicker2](https://github.com/user-attachments/assets/87b37450-cbd4-4afc-bbdb-b2dcec8db60e)

kauppa näkymä, joka näkyy kun painaa kauppa nappia


    Tallennusnäkymä
tallennus painiketta painettu kuva
![cclicker3](https://github.com/user-attachments/assets/94073d0d-6153-4c49-b267-f67a2d8f04b3)



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
