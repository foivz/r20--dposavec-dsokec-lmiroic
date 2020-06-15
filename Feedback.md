## UVID U PROJEKT

## Projektna dokumentacija
* Metodika razvoja: Vodopadni model, referenca na izvor nije priložena.
* Projektni plan: Usuglašen sa odabranim modelom. Kod provedbe se kasni. Gantogram nema nazive aktivnosti s lijeve strane te je u ovom obliku malo uporabljiv.
* Izračun troškova -> Ok. Jeste li u cijenu uključili samo trošak rada ili i druge troškove?
* Ponuda naručitelju -> Ok
* Praćenje provedbe -> Metrike nisu definirane.

## Tehnička dokumentacija
* Poglavlje specifikacije zahtjeva staviti na početak tehničke dokumentacije.
* SRS: Pohvalno je što ste tražili i pokušali primijeniti predloške / primjere dobre prakse u raspisu dokumentacije. Pri korištenju predložaka treba biti oprezan, jer ako poglavlja i teme koje se navode a nisu važne za vaš projekt možete ih izostaviti ili grupirati. Time bi se izbjegla rascjepkanost dokumenta u mnošvo poglavlja od po jednu-dvije rečenice. Isto tako postoje poglavlja koja se po svojoj prirodi mogu spojiti. Možda vam može pomoći da vidite još par primjera dokumentacije. Evo jednoga: https://www.perforce.com/blog/alm/how-write-software-requirements-specification-srs-document

* Model podataka: Nije ispravan. Promjena cijene artikla će izmijeniti podatke o već izdanim dokumentima. U bazu potrebno uključiti temporalnu komponentu.
* Klase: Sintaksički ispravno. Semantiku ćemo provjeriti na obrani.
* Use Case - sintaksički ispravno uz izuzetak da sam primijetio da se pojavljuju slučajevi korištenja kao imenice u nominativu. To nije dobro.
* AD: Sintaksički ispravni. 
* SD: Provjerite stereotipe objekata. Obično se stereotip "Sustav" koristi samo u interakciji korisnika i aplikaciji, a ostali objekti su drugačije stereotipizirani.
* SDS kao poglavlje nije definirano. Isto tako predlažem koristiti prmjere dobre prakse te u to poglavlje uključiti sve što do sada imate, ali malo restrukturirano. Npr., sadržaj ste grupirali po tipu informacija a ne po funkcionalnostima ili drugim aspektima važnim za projekt ili za tim. Stoga, moj prijedlog je da se taj dio restrukturira te da sav sdržaj bude smješten u ono poglavlje na koje se odnosi to jest ovisno o funkcionalnim ili nefunkcionalnim zahtjevima. Ta poglavlja bi u sebi sadržavala sve što je važno za taj zahtjev (od detaljne specifikacije slučaja korištenja, dijela modela podataka, skice sučelja, integracije i interakcije s drugim funkcionalnostima opisane dijagramima aktivnosti, slijeda i slično). Ovu promjenu nije teško napraviti jer većinu tih artefakata već imate. I za ovaj dokument možete pronaći primjere dobre prakse.
* Semantiku i usklađenost svih dijagama s kodom ćemo provjeravati na obrani.
* Svaki kreirani artefakt (npr. poglavlje treba imati potpisanog autora to jest odgovornog studenta). 
* U dokumentaciju dodati poglavlje s uputama za podešavanje razvojne i produkcijske okoline te s podacima o testiranju programa (npr. korisnička imena i lozinke).

## Implementacija
* Objektno orijentirano programiranje -> Ok.
* Arhitektura -> Troslojna. Bravo.
* Struktura projekta -> Ok. Nastavite koristiti imenska područja (namespaces, mape). 
* Razmislite o korištenju cijelog zaslona u dizajnu vaših formi. Pomoću sidra (anchor) možete podesiti da aplikacija iskorištava cijeli dostupni prostor. Isto tako, razmislite o korištenju MDI pristupa. Jednu formu proglasite MDI formom, a ostale proglasite MDI djecom. To vam u mnogočemu olakšava.
* Implementirane funkcionalnosti - Zadovoljava. Implementiran backbone. Većina klasa prazne.
* Verzioniranje - Dobro ste odvojili dokumentaciju i razvoj na dvije odvojene grane. Nastavite razvoj raditi isključivo na development grani u koju ćete spajati svaku funkcionalnost kada je gotova. Nakon što se integracija (na development grani) istestira i nakon što je sve u redu, tek onda se kod spaja na master (produkcijsku granu). Vezano za workflow razvoja (ne vezano za dokumentaciju) pokušajte primijeniti feature-branch workflow koji je opisan ovdje: https://www.atlassian.com/git/tutorials/comparing-workflows/feature-branch-workflow. Više pozornosti usmjerite na pripremu dokumenata za verziju (staging) i na kvalitetne komentare kod verzija. 
* .gitignore: nije dobar. Molim vas da osigurate da se odmah nakon povlačenja repozitorija programski kod može kompajlirati i pokrenuti, a da se pri tome ne zaprlja repozitorij. To znači da morate verzionirati sve fajlove koje Visual Studio ne kreira sam, a one koje kreira sam morate ignorirati pomoću odgovarajuće .gitignore datoteke.


## Ostalo
* U dokumentaciji bi bilo dobro složiti da se klikom na sliku ista slika otvori u full screen prikazu.  
  Markup je: ```[ ![](image.jpg) ](image.jpg)```
* Pazite na minimalne zahtjeve za programske proizvode prije nego što pristupite obrani (npr. izdvajanje jednog dijela projekta u dll, kontekstualna pomoć i slično).

## Bodovi
P1: 9 bodova

---
---



## Opća povratna informacija
Izvrsna projektna prijava. Prihvaćam ju, a sitne dopune koje navodim u nastavku su više moja želja da projekt bude još bolji. Projektna ideja je u skladu sa zahtjevima kolegija. Implementacijom konačnog seta funkcionalnosti studenti će moći postići sve ishode učenja na kolegiju. Molim vas da temeljem napomena ispod sami dopunite vašu projektnu prijavu.

## Arhitektura u odnosu na bazu podataka
Također molim da arhitektura sustava bude temeljena na centraliziranoj bazi podataka na koju će se spajati jedna ili više aplikacija istovremeno. Ovaj zahtjev treba uzeti u obzir kao aspekt kroz dizajn i implementaciju ostalih funkcionalnosti (npr. da više korisnika može raditi naručivanje termina, a da pri tome ne dođe do pogreške ili prepisivanja podataka jedne predbilježbe preko druge).

## Predložene dopune
3. Omogućiti korištenje ove aplikacije od strane više odvojenih poslovnih subjekata. Svakom subjektu se pri ugovoru o korištenju kreira jedan administrativni račun koji onda dalje upravlja podacima/računima svoga objekta kako je sada prijavljeno.
2. Dodati slanje relevantnih podataka mailom kod prikladnih funkcionalnosti (npr. račun za uslugu kao PDF kupcu, narudžbenica kao PDF dobavljaču...)
3. Kod F06 dodati algoritam predviđanja potrošnje zalih unaprijed te automatsko naručivanje artikla koji će nestati za N dana (7 do 30) temeljem potrošnje u nekom prethodnom intervalu od M dana (60 do 365).
4. Kreirati obavijest (notifikaciju kod poduzeća i e-mail kod kupaca) kod funkcionalnosti gdje je prikladno.. 

Uistinu sam uživao čitati vašu projektnu prijavu i baš se radujem suradnji s vama n aovom projektu.
