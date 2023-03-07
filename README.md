# PetVet

## Model rada na projektu
(1) Nastavak rada na projektu iz kolegija "Razvoj programskih proizvoda"

## Opis projekta
### Naziv projekta:
PetVet Desktop aplikacija
### Domena / Tema projekta:
Problemska domena kojom se ova Desktop aplikacija bavi ponajprije je praćenje zdravstvenog stanja ljubimca te radnih aktivnosti veterinara u virtualnom okruženju. Postojeći dokument obuhvaća određene specifikacije potrebne za implementiranje desktop aplikativnog rješenja u svrhu učinkovitijeg vođenja zdravstvenog života korisnikovog ljubimca u digitalnom obliku te radnih aktivnosti veterinara putem digitaliziranog kalendara aktivnosti. Naime, dokument prikazuje potrebne funkcionalnosti samog budućeg desktop aplikativnog rješenja koje bi trebale biti implementirane u isti pri čemu bi svaki sudionik kreiranja aplikacije bio upućen u potrebne modularnosti.
### Kolegij na kojem je započet projekt:
Razvoj programskih proizvoda
### Tehnologije koje su prethodno korištene:
Tehnologije i opreme koje se koriste za implementaciju desktop aplikativnog rješenja su sljedeće: računalo, DBMS i SQL Server Management Studio za izradu baze podataka, Visual Studio za izradu programskog koda, git i GitHub za verzioniranje programskog koda, GitHub Wiki za pisanje tehničke i projektne dokumentacije, GitHub projects za planiranje i praćenje projektnih zadataka. Projekt se razvijao i dalje će se razvijati koristeći .Net Framework razvojni okvir te vrstu projekta u WinForms obliku.

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Lucija Grzelj | lgrzelj@student.foi.hr | 0016145583 | lgrzelj
Ivana Belinić | ibelinic20@student.foi.hr | 0016147210 | ibelinic
Iva Plavšić | iplavsic20@student.foi.hr | 0016146806 | iplavsic20

## Specifikacija projekta

Dokumentom se želi postići jasna i detaljna specifikacija korisnikovih zahtjeva na temelju kojih bi se implementirala sama desktop aplikacija. Desktop aplikativno rješenje trebalo bi moći ostvariti sve zahtjeve korisnika te osigurati potrebu za korištenjem istog, odnosno potrebu za digitaliziranim načinom upotrebe dosadašnjeg ručnog praćenja zdravstvenih obaveza ljubimca te radnih aktivnosti veterinara u obliku dokumentiranih prikaza. Ovim projektom digitalizirao bi se cjelokupni način praćenja zdravstvenog života ljubimca putem vlasnika i veterinara uz pomoć desktop aplikacije koja bi sadržavala bitne i potrebne podatke, ali i aktivnosti. Arhitektura programskog proizvoda Desktop aplikacije PetVet višeslojna je s odvojenom, odnosno dislociranom bazom podataka. Osnovu spomenute arhitekture predstavlja sustav koji nudi gotova rješenja i funkcionalnosti kako bi se ubrzao proces razvoja aplikacije.

### Funkcionalnosti sustava:
Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Registracija/prijava uz mogućnost odjave korisnika | Korisnik se treba registrirati ili prijaviti u aplikaciju kako bi imao pristup svim funkcionalnostima iste, također se može i odjaviti te prilikom prijave ima mogućnost promjene lozinke ukoliko je zaboravljena. | Lucija Grzelj
F02 | Izrada/brisanje profila | Korisnik ima mogućnost izrade profila vlastitim ljubimcima te ima i mogućnost brisanja istih. | Ivana Belinić
F03 | Digitalni karton | Korisnik u ulozi veterinara ima mogućnost otvaranja novog digitalnog kartona ljubimca. | Iva Plavšić
F04 | Popunjavanje rasporeda unutar kalendara |  Korisnik u ulozi veterinara ima mogućnost popunjavanja kaledara vlastitim aktivnostima prema rasporedu. | Lucija Grzelj
F05 | Pregled dostupnih veterinara unutar kalendara | Korisnik u ulozi vlasnika ima mogućnost pregleda slobodnih termina s obzirom na raspored veterinara. | Ivana Belinić
F06 | Prijava/odjava odabranog termina | Korisnik u ulozi vlasnika ima mogućnost odabira jednog od slobodnih termina unutar prikazanog kalendara te odjavu istog. | Iva Plavšić
F07 | Izrada izvještaja digitalnog kartona | Korisnik u obje uloge ima mogućnost izrade izvještaja digitalnog kartona ljubimaca. | Lucija Grzelj
F08 | Evidentiranje određenih tretmana kartona ljubimca | Korisnik u ulozi veterinara ima mogućnost popunjavanja digitalnog kartona o ljubimcima. | Ivana Belinić
F09 | Pretraživanje korisnika i njihovih ljubimaca | Korisnik u ulozi vlasnika ima mogućnost pretraživanja ostalih korisnika i njihovih ljubimaca. | Iva Plavšić

### Funkcionalni zahtjevi
Identifikator | Zahtjev | Obrazloženje | Način provjere | Prioritet [1-5] | Izvor/Porijeklo
------------- | ------- | ------------ | -------------- | --------------- | ---------------
FZ-1 | Registracija/prijava uz mogućnost odjave korisnika | Korisnik se treba registrirati ili prijaviti u aplikaciju kako bi imao pristup svim funkcionalnostima iste, također se može i odjaviti te prilikom prijave ima mogućnost promjene lozinke ukoliko je zaboravljena. | Korisnik prilikom prvog ulaska u sustav mora ispuniti potrebne podatke koje će mu omogućiti upotrebu aplikativnog sustava. Korisnik tijekom prijave ispunjava potrebne podatke, odnosno korisničko ime i lozinku, kako bi pristupio sustavu s prethodno kreiranim računom. Korisnik se u svakom trenutku unutar aplikacije može odjaviti iz samog sustava. | 1 | Potrebni zahtjevi za funkcioniranjem PetVet sustava prema potrebama korisnika
FZ-2 | Izrada/brisanje profila | Korisnik ima mogućnost izrade profila vlastitim ljubimcima te ima i mogućnost brisanja istih. | Unutar korisničkog sučelja u ulozi vlasnika, korisnik će imati mogućnost izraditi profil vlastitom ljubimcu ili ljubimcima pri čemu će morati ispuniti potrebne podatke koji se od njega zahtijevaju. Također, iste te kreirane profile, korisnik će moći i obrisati u bilo kojem trenutku. | 2 | Potrebni zahtjevi za funkcioniranjem PetVet sustava prema potrebama korisnika
FZ-3 | Digitalni karton | Korisnik u ulozi veterinara ima mogućnost otvaranja novog digitalnog kartona ljubimca. | Veterinar kada otvori digitalni karton ima mogućnost upisivanja podataka te nakon spremanja ima mogućnost pregleda digitalnog kartona. | 1 | Potrebni zahtjevi za funkcioniranjem PetVet sustava prema potrebama korisnika
FZ-4 | Popunjavanje rasporeda unutar kalendara | Korisnik u ulozi veterinara ima mogućnost popunjavanja kalendara vlastitim aktivnostima prema rasporedu. | Korisnik u ulozi veterinara imat će mogućnost popunjavati kalendar sa datumom, zadacima i vremenom, koji će predstavljati njegove zakazane termine. | 2 | Potrebni zahtjevi za funkcioniranjem PetVet sustava prema potrebama korisnika
FZ-5 | Pregled dostupnih veterinara unutar kalendara | Korisnik u ulozi vlasnika ima mogućnost pregleda slobodnih termina s obzirom na raspored veterinara. | Korisnik kao vlasnik u svakom će trenutku imati omogućen pregled dostupnih veterinara za pojedini odabrani dan, odnosno kada korisnik odabere određeni dan unutar kalendara pojavljuje mu se popis slobodnih veterinara za odabrani dan te njihove termine dostupnosti. | 2 | Potrebni zahtjevi za funkcioniranjem PetVet sustava prema potrebama korisnika
FZ-6 | Prijava/odjava odabranog termina | Korisnik u ulozi vlasnika ima mogućnost odabira jednog od slobodnih termina unutar prikazanog kalendara te odjavu istog. | Korisnik će kada odabere slobodni termin zaprimiti mail o odabranom terminu te to vrijeme više neće biti slobodno unutar kalendara. Prilikom odjave termina također će vlasnik zaprimiti mail o otkazanom terminu te će taj termin postati slobodan unutar kalendara. | 2 | Potrebni zahtjevi za funkcioniranjem PetVet sustava prema potrebama korisnika
FZ-7 | Izrada izvještaja digitalnog kartona | Korisnik u obje uloge ima mogućnost izrade izvještaja digitalnog kartona ljubimaca. | Korisnik će u obje uloge imati mogućnost izrade izvještaja digitalnog kartona, odnosno imat će mogućnost preuzimanja podataka u PDF obliku. | 2 | Potrebni zahtjevi za funkcioniranjem PetVet sustava prema potrebama korisnika
FZ-8 | Evidentiranje određenih tretmana kartona ljubimca | Korisnik u ulozi veterinara ima mogućnost popunjavanja digitalnog kartona o ljubimcima. | Korisnik kao veterinar u svakom trenutku, odnosno pri svakom posjetu ljubimca, ima mogućnost evidentiranja tog posjeta te popratne bilješke kao određeni tretman. | 1 | Potrebni zahtjevi za funkcioniranjem PetVet sustava prema potrebama korisnika
FZ-9 | Pretraživanje korisnika i njihovih ljubimaca | Korisnik u ulozi vlasnika ima mogućnost pretraživanja ostalih korisnika i njihovih ljubimaca. | Korisnik će prilikom pretraživanja dobiti rezultate o korisniku ako je korisnik registriran unutar aplikacije. Ako korisnik upiše korisnika pokušava naći korisnika koji nije registriran ispisati će se poruka kako ne postoji takav korisnik. | 3 | Potrebni zahtjevi za funkcioniranjem PetVet sustava prema potrebama korisnika

### Nefunkcionalni zahtjevi:
Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
NFZ01 | Izgled softvera | Sustav će interakciju sa zaposlenicima provoditi preko grafičkog sučelja. | Lucija Grzelj
NFZ02 | Izgled softvera | Paleta boja (nijanse zelene, nijanse smeđe, nijanse narančaste, bijela). | Lucija Grzelj
NFZ03 | Upotrebljivost softvera | Sustav će pružiti izravno upotrebljive, čitljive i po potrebi ispisive informacije. | Ivana Belinić
NFZ04 | Upotrebljivost softvera | Sustav će osigurati opciju pretraživanja te filtriranja rezultata pretraživanja. | Ivana Belinić
NFZ05 | Upotrebljivost softvera | Sustav će omogućiti potrebne mehanizme za osobama s poteškoćama temeljene na pomoćnim tehnologijama unutar samog sustava. | Ivana Belinić
NFZ06 | Upotrebljivost softvera | Sustav će imati jasno definiranje navigabilne elemente za jednostavnost kretanja kroz cijeli sustav. | Ivana Belinić
NFZ07 | Performanse softvera | Sustav će biti dostupan 24 sata na dan 365 dana u godini. | Iva Plavšić
NFZ08 | Izvođenje softvera i okruženje | Sustav treba raditi na računalima s instaliranim Windows 10 ili novijim operacijskim sustavom. | Lucija Grzelj
NFZ09 | Sigurnost i privatnost | Sustav će reagirati na neovlašteni pristup ili izmjenu konfiguracije sustava ili podataka. | Ivana Belinić
NFZ10 | Sigurnost i privatnost | Sustav će pružiti tehnologije, okvire alata i biblioteke implementirane na dosljedno siguran način. | Ivana Belinić
NFZ11 | Sigurnost i privatnost | Sustav će uključivati tradicionalne koncepte zaštite podataka poput šifriranja određenih podataka, konkretno lozinke korisnika. | Ivana Belinić
NFZ12 | Sigurnost i privatnost | Sustav će omogućiti ograničavanje pristupa podacima na temelju uloga korisnika. | Ivana Belinić
NFZ13 | Sigurnost i privatnost | Sustav će pružiti jamstvo da administratori sustava imaju odgovarajuće vještine i znanje o informacijskoj sigurnosti i implementaciji, upravljanju i održavanju sustava za koje su odgovorni. | Ivana Belinić




## Tehnologije i oprema
Nadopunit će se naknadno s obzirom na tehnologije.
