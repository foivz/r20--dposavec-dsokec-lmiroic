# PI20-023 Car dealership & service

Mentor: Doc.dr.sc. Zlatko Stapić

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Luka Miroić | lmiroic@foi.hr | 0016122996 | lmiroic
Dominik Posavec | dposavec@foi.hr | 0016125407 | dposavec
Dino Šokec | dsokec@foi.hr | 0016123631 | dsokec3110

## Opis domene
U navedenoj aplikaciji "Car dealership & service" baziramo se na upravljanje, evidentiranje i provedbu prodaje automobila i na njihovo servisiranje.

## Specifikacija projekta

![Visedretvenost](https://i.imgur.com/nd04YPb.jpg)

Arhitektura sustava temeljit će se na centraliziranoj bazi podataka na koju će se moći spajati jedna ili više aplikacija istovremeno, odnosno da se ne dogodi pogreška ili kolizija podataka tijekom procesa naručivanja termina od strane korisnika u aplikaciji.

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | ------------------- 
F01 | Log in i registracija zaposlenih, evidentiranje i upravljanje | Korisnik se prijavljuje kao zaposlenik ili administrator. Uloga administratora je dodavanje novih korisnika ili zaposlenika. Uloga zaposlenika je vođenje evidencije o vozilima na skladištu i servisu, brigu o poslovanju poduzeća, vođenje statistike prodaje i servise. Prilikom sklapanja ugovora sa drugim poslovnim subjektima kreiran im je administrativni račun u aplikaciji koji upravlja podacima svojeg područja i svrhe. | Luka Miroić
F02 | Ažuriranje, brisanje, pregled i dodavanje podataka | Administrator je u mogućnosti da ažurira, briše, pregledava ili dodanje neke nove podatke u aplikaciju | Luka Miroić
F03 |Prodaja vozila i rezervnih dijelova, te izdavanje računa |Prilikom prodaje vozila zaposlenik izdaje račun i ostale dokumente prikladne za vozilo. Pri čemu su u računu navedeni određeni atributi kao što su marka vozila, količina, cijena i ukupna suma. Prilikom prodaje vozila potrebno je ažurirati stanje skladišta. | Dino Šokec
F04 | Izdavanje narudžbenica za vozila | Zaposlenik izdaje narudžbenice za nabavu i kupovinu vozila.  | Dominik Posavec
F05 | Naručivanje i rezerviranje termina za servis vozila | Zaposlenik izdaje povratnu informaciju klijentu koji je prethodno zatražio servis vlastitog vozila. | Dino Šokec
F06 | Upravljanje stanjem na skladištu automobila i rezervnih dijelova | Zaposlenik vodi evidenciju stanja skladišta o vozilima i rezervnih dijelova, te samim time brine o naručivanju budućih dijelova koje su na skladištu zabilježene kao manjak. Implementacija algoritma predviđanja potrošnje zaliha unaprijed, te samim time automatsko naručivanje artikla koji će nestati za N dana temeljem potrošnje u prijašnjim prethodnim intervalima.  | Dominik Posavec
F07 | Evidentiranje i obračunavanje poslovanja | Prikaz prodanih količina vozila u aplikaciji. Mogućnost pregleda prijave pojedinih zaposlenika u aplikaciju. | Dino Šokec
F08 | Kreiranje naprednih PDF izvješća | Administrator ili zaposlenik može kreirati razna napredna izvješća o poslovanju poduzeća. Samim time, mailom se šalju podaci u PDF obliku poput računa kupcu ili narudžbenice dobavljaču. | Luka Miroić
F09 | Korištenje grafova i drugih vizualnih prikaza podataka | Administrator ili zaposlenik može kreirati razne grafove i druge vizualne podatke za što lakši vizualizaciju podataka o stanju poduzeća. Kreiranje obavjesti za poduzeće, ali i za samog kupca. | Dominik Posavec
 
## Tehnologije i oprema
Visual studio - alat za razvojno okruženje koji se koristi za izradu softvera, aplikacije, web stranice i slično. Uz to, podržava i različite programske jezike.

Visual Paradigm Community - programsko rješenje koje se koristi za izradu dijagrama.

Draw.io - web aplikacija koja se koristi za izradu jednostavnih dijagrama, arhitekturu aplikacije i slično.

Microsoft Project - alat za izradu gantrograma, projektnog plana, rad s pogledima i izvještajima, dodavanje i rad s resursima i slično.
Troje prijenosnih računala s Windows operacijskim sustavom.
