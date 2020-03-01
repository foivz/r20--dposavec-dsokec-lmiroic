# Inicijalne upute za prijavu projekta iz Programskog inženjerstva

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Programsko inženjerstvo, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak, ukoliko niste odabrali da želite raditi na projektu sa gospodarstvom je **prijaviti vlastiti projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. A sada, vrijeme je da prijavite vaš projekt. Za prijavu vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# Car dealership & service

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Luka Miroić | lmiroic@foi.hr | 0016122996 | lmiroic
Dominik Posavec | dposavec@foi.hr | 0016125407 | dposavec
Dino Šokec | dsokec@foi.hr | 0016123631 | dsokec3110

## Opis domene
U navedenoj aplikaciji "Car dealership & service" baziramo se na upravljanje, evidentiranje i provedbu prodaje automobila i na njihovo servisiranje.

## Specifikacija projekta
Umjesto ovih uputa opišite zahtjeve za funkcionalnošću programskog proizvoda. Pobrojite osnovne funkcionalnosti i za svaku naznačite ime odgovornog člana tima. Opišite buduću arhitekturu programskog proizvoda. Obratite pozornost da bi arhitektura trebala biti višeslojna s odvojenom (dislociranom) bazom podatka. Također uzmite u obzir da bi svaki član tima treba biti odgovorana za otprilike 3 funkcionalnosti, te da bi opterećenje članova tima trebalo biti ujednačeno. Priložite odgovarajuće dijagrame i skice gdje je to prikladno. Funkcionalnosti sustava bobrojite u tablici ispod koristeći predložak koji slijedi:

Oznaka | Naziv | Kratki opis | Odgovorni član tima
 F01 | Log in i registracija zaposlenih, evidentiranje i upravljanje | Korisnik se prijavljuje kao zaposlenik ili administrator. Uloga administratora je dodavanje novih korisnika ili zaposlenika. Uloga zaposlenika je vođenje evidencije o vozilima na skladištu i servisu, brigu o poslovanju poduzeća, vođenje statistike prodaje i servise. | Luka Miroić
 F02 | Ažuriranje, brisanje, pregled i dodavanje podataka | Administrator je u mogućnosti da ažurira, briše, pregledava ili dodanje neke nove podatke u aplikaciju | Luka Miroić
 F03 |Prodaja vozila i rezervnih dijelova, te izdavanje računa |Prilikom prodaje vozila zaposlenik izdaje račun i ostale dokumente prikladne za vozilo. Pri čemu su u računu navedeni određeni atributi kao što su marka vozila, količina, cijena i ukupna suma. Prilikom prodaje vozila potrebno je ažurirati stanje skladišta. | Dino Šokec
 F04 | Izdavanje narudžbenica za vozila | Zaposlenik izdaje narudžbenice za nabavu i kupovinu vozila.  | Dominik Posavec
 F05 | Naručivanje i rezerviranje termina za servis vozila | Zaposlenik izdaje povratnu informaciju klijentu koji je prethodno zatražio servis vlastitog vozila. | Dino Šokec
 F06 | Upravljanje stanjem na skladištu automobila i rezervnih dijelova | Zaposlenik vodi evidenciju stanja skladišta o vozilima i rezervnih dijelova, te samim time brine o naručivanju budućih dijelova koje su na skladištu zabilježene kao manjak. | Dominik Posavec
 F07 | Evidentiranje i obračunavanje poslovanja | Prikaz prodanih količina vozila u aplikaciji. Mogućnost pregleda prijave pojedinih zaposlenika u aplikaciju. | Dino Šokec
 F08 | Kreiranje naprednih PDF izvješća | Administrator ili zaposlenik kmože kreirati razna napredna izvješća o poslovanju poduzeća. | Luka Miroić
 F09 | Korištenje grafova i drugih vizualnih prikaza podataka | Administrator ili zaposlenik može kreirati razne grafove i druge vizualne podatke za što lakši vizualizaciju podataka o stanju poduzeća. | Dominik Posavec
 
## Tehnologije i oprema
Visual studio - alat za razvojno okruženje koji se koristi za izradu softvera, aplikacije, web stranice i slično. Uz to, podržava i različite programske jezike.
Visual Paradigm Community - programsko rješenje koje se koristi za izradu dijagrama.
Draw.io - web aplikacija koja se koristi za izradu jednostavnih dijagrama, arhitekturu aplikacije i slično.
Microsoft Project - alat za izradu gantrograma, projektnog plana, rad s pogledima i izvještajima, dodavanje i rad s resursima i slično.
Troje prijenosnih računala s Windows operacijskim sustavom.
