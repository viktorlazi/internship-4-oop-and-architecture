OOP i Arhitektura Domaći:
Radimo dungeon-crawler igricu! Vaš avanturistički igrač prolazit će kroz misteriozni zamak
gdje će se susresti sa raznim čudovištima na putu do tajnog blaga skrivenog unutar!
Igrica funkcionira na iduci nacin:
Svakim pokretanjem igrač unosi podatke njegovog heroja
Naš Heroj ima:
- Ime
- Health Points (HP) koji predstavlja koliko može primiti štete od čudovišta prije nego
umre i igrica je gotova. Igrač, ako želi, može sam postaviti ovu vrijednost pri početku ili
mu igrica dodijeli neku prikladnu količinu ovisno o vrsti heroja
- Experience (XP), koje se povećava svaki put kad poražava čudovište. Kreće od 0 i
nakon što igrač prikupi neku određenu količinu experience bodova, “level-upa” te mu
poraste HP i damage, ai XP mu krene od početka sa prenesnim viškom bodova. Recimo
da je imao 80/100 xp i dobije 30 xp. Tada mu porastu health i damage za recimo 15 i 5
bodova, a xp mu je sad 10
- Damage, mjera koliko štete radi čudovištima, određuje se isto kao health
- Mogućnost da napada neko čudovište (razjašnjeno tokom doca)
- I pripada jednoj od idućih vrsta koja se bira pri pokretanjem igre
- Warrior
- Ima najveći HP i najmanji Damage
- Kada napada čudovište, može napadati iz bijesa, tada za utrošak npr.
15% ukupnih životnih bodova radi dupli damage
- Mage
- Ima najmanji HP i najveći damage
- Ima dodatno svojstvo Mana, količina magične snage koja mu je ostala i
obnovi se nakon svake bitke. Mana se takoder poveća level-upovima
- Kada se bori, troši manu, te kada nema više mane ne iduću rundu koju
osvoji ne napada nego mu se samo ona obnovi, a može kada ima pravo
poteza umjesto napada utrošiti neku količinu mane da si obnovi životne
bodove.
- Ima mogućnost da se jednom vrati iz mrtvih, tj. Smije jednom umrijeti i
nastaviti dalje igru sasvim obnovljen
- Ranger
- Ima umjeren HP i damage
- Ima dodatno svojstvo Critical Chance - vjerojatnost da ozbiljno našteti
čudovištu i Stun chance - vjerojatnost da ošamuti čudovište. Oboje rastu
sa level-upanjem
- Svaki put kad napada, ovisno o postotku Critical Chance, postoji
vjerojatnost da napravi dupli damage. Također, u ovisnosti o Stun
Chance, postoji šansa da ošamuti čudovište, tada čudovište automatski
gubi iduću rundu (runde opisane ispod)
Kada igrač kreira svog heroja, ići će sekvencijalno u borbu sa 10 unaprijed nasumično
generiranih čudovišta.
- Svako čudovište ima nekom kvazi-random metodom generirani HP i Damage, te koliko
vrijedi Experiencea ako se porazi
- Postoje 3 vrste čudovišta
- Goblin
- Velika vjerojatnost da se generira
- Malo HPa i damagea
- Ništa posebno, šugavi goblin
- Brute
- Manje vjerojatan
- Velik HPa i solidan damage
- Postoji vjerojatnost da kad napada da napadne tako jako da
oduzme igraču postotak života umjesto fiksni broj
- Witch
- Najrjeđi neprijatelj
- Kad ju se porazi, stvori 2 nova čudovišta koje treba poraziti
nakon nje
- Ima specijalnu moć đumbus gdje neku rundu koju dobije umjesto
napada svima koji imaju Health ga postavi na neku nasumičnu
vrijednost, dakle i heroju i svim čudovištima, čak i onima koji tek
dolaze
- Kada igrač stupi u sukob sa čudovištom, nastupa nova runda te sudionici imaju izbor
između tri akcije (Kamen, škare, papir metoda):
- Direktan napad (Kamen)
- Napad s boka (Škare)
- Protunapad (Papir)
- Čudovište će također, slučajnim odabirom, napraviti jednu od te tri akcije
- Ishod je idući
- Direktan napad pobijedi napad s boka
- Napad s boka pobijedi protunapad...
- Protunapad pobijedi direktan napad...
- Ako su obe strane odobrale isto, ništa se ne dogodi
- Strana koja pobjedi ima pravo poteza, te postupa po svojoj logici i može
uraditi aktivnosti koje su specifične za nju, npr.
- Ako je igrač pobijedio, onda on ima pravo poteza i primjenjuje se
logika vrste heroja kojoj pripada. Dakle warrior ima opciju samo
obično napasti kao svi, tj. primjeniti svoj damage nad čudovištem
ili bijesno napasti. Čudovište tada ništa ne radi
- Ako je čudovište pobijedilo, onda ono napada po svojim opcijama
koje samo nasumično odabere, a igrač ne radi ništa tu rundu
- Runde se ponavljuju dok netko ne umre
- Ako igrač porazi čudovište, dobija količinu XP-a koju definira čudovište
- Tokom borbe igraču se prikazuje stanje svih navedenih informacija da zna kako
napreduje borba
- Ako pobijedi, obnovi mu se 25% ukupnih životnih bodova i ide u borbu sa idućim
čudovištem.
- Može prije iduće bitke utrošiti pola Experienca da obnovi sve životne bodove
- Ako pobijedi 10 čudovišta, pobijedio je! :)
- Ako izgubi, promptaj korisnika želi li pokušati ponovno
SAMI ODREĐUJETE specifične raspone vrijednosti i vjerojatnosti kako bi igrica funkcionirala
odnosno bila pobjediva, ali ne prelagano :D
Velik dio ovih zahtjeva može se jednostavno, čak trivijalno implementirati, ali ovdje vrednujemo
vaše inžinjersko umijeće kako ćete napraviti najelegantije rješenja upotrebom tehnika koje smo
usvojili na predavanju, tako da se potiče upotreba svega od nasjljeđivanje do interfacea.
Napravite arhitekturu u tri sloja: Presentation, Domain i Data.
Repozitorij treba imenovati ovako: internship-4-oop-and-architecture
Rok: Nedjelja, 13.12.2020. u 23:59