# Demo Web Shop - Testiranje

Ovaj projekt sadrži 5 testova za testiranje funkcionalnosti na stranici "Demo Web Shop". Testovi uključuju registraciju, prijavu, dodavanje proizvoda u listu želja, dodavanje proizvoda u košaricu te proces narudžbe.

## Okruženje i alati za testiranje
Testovi su izvršeni u **Visual Studio 2022** koristeći **C#** programski jezik. Kako bi se osigurala pouzdanost testova, korištene su **wait naredbe**. Ove naredbe omogućuju čekanje na određene uvjete prije izvođenja sljedećeg koraka, što je vrlo korisno pri testiranju dinamičkih web stranica. Također, radi lakšeg kreiranja testova, korišten je i alat **Katalon Recorder**. Ovaj alat omogućuje snimanje koraka tijekom ručnog testiranja, što olakšava generiranje skripti za testiranje.

## Testovi

### Registracija (Register)
1. Kliknite na poveznicu "Register".
2. Odaberite spol (npr "Male").
3. Ispunite polja za ime, prezime i email (npr. "Luka", "Cener", "lllccc@net.hr").
4. Ispunite polja za lozinku (npr. "blablabla").
5. Kliknite na tipku "Register".
6. Nakon potvrde o uspješnoj registraciji, kliknite na tipku "Continue".

### Prijava (Log in)
1. Kliknite na poveznicu "Log in".
2. Ispunite polja za email i lozinku ("lllccc@net.hr", "blablabla").
3. Kliknite na okvir "Remember me?" kako biste ostali prijavljeni.
4. Kliknite na tipku "Log in".

### Dodavanje proizvoda u listu želja (Add To Wishlist)
1. Prije svega, potrebno je biti prijavljen koristeći korake iz testa "Prijava".
2. U zaglavlju kliknite na "Electronics".
3. Kliknite na kategoriju "Cell phones".
4. Kliknite na "Smartphone".
5. Kliknite na tipku "Add to wishlist".
6. Kliknite na poveznicu "Wishlist" kako biste provjerili je li proizvod dodan.

### Dodavanje proizvoda u košaricu (Add To Cart)
1. Prije svega, potrebno je biti prijavljen koristeći korake iz testa "Prijava".
2. U zaglavlju kliknite na "Computers".
3. Kliknite na kategoriju "Desktops".
4. Kliknite na "Build your own expensive computer".
5. Odaberite sve specifikacije (za ovaj test odaberite najskuplje opcije).
6. Kliknite na "Add to cart".
7. Kliknite na poveznicu "Shopping cart" kako biste provjerili je li proizvod dodan.

### Proces narudžbe (Checkout)
1. Prije svega, potrebno je biti prijavljen koristeći korake iz testa "Prijava".
2. Kliknite na poveznicu "Shopping cart".
3. Kliknite na okvir "I agree with the terms ..." kako biste prihvatili uvjete usluge.
4. Kliknite na tipku "Checkout".
5. Odaberite državu za naplatu (npr. "Croatia").
6. Ispunite polja za grad i adresu (npr. "Osijek", "Ulica Vatrenih 29").
7. Ispunite polja za poštanski broj i broj mobitela (npr. 31000, "123456789").
8. Kliknite na tipke "Continue" sve do koraka "Confirm Order".
9. Kliknite na tipku "Confirm".
10. Kliknite na tipku "Continue".
