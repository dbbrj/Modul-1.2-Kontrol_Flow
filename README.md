# 8 Booleans

## 8.1 Definition
Hvad er en boolean?
## 8.2 Oprettelse
Hvilke operatorer kan man bruge til at få et expression til at evaluere til en boolsk værdi?
## 8.3 Købsbeslutning
Forklar sidste linje og fokuser på:
	• I hvilken rækkefølge bliver hvad udregnet?
	• Hvilke værdier (navngivne eller ej) udføres de enkelte operatorer på?
	• Hvilke typer har disse værdier?
	• Hvad repræsenterer variablen shouldBuy?
## 8.4 Terninger
Skriv et program, hvori
1. Værdien af et terningeslag er gemt i en variabel ved navn dice.
	• Hvilken type giver det mening at erklære variablen som?
	• Vælg selv en specifik værdi.
2. Opret en boolsk variabel og tildel den en værdi der repræsenterer hvorvidt værdien fra variablen dice er lige og større end 3.
3. Udskriv den værdien af denne boolske variabel.

# 9 Branches

## 9.1 Epoch 
Skriv et program, hvori
1. I tager udgangspunkt i opgaven fra afsnit 7.4.
2. I erklærer en variabel hvis værdi repræsenterer et antal sekunder siden nytår.
3. På baggrund af denne variabels værdi udregner I hvilken måned og hvilken dag der er tale om (I kan gå ud fra at alle måneder er 30 dage lange).
4. Udskriv “Det er jul!” hvis det er tilfældet (det er jul den 24. December).
## 9.2 Epoch Diff
Udvid opgaven fra afsnit 9.1 til – hvis det ikke er jul – at udskrive hvor lang tid man skal vente på at det bliver jul.
## 9.3 Juleudsalg
Skriv et program, hvori
1. En variabel oprettes (erklæres) og initialiseres til værdien 21816000. Dette tal repræsenterer et antal sekunder siden nytår (alle måneder antages at være 30 dage lange).
2. En anden variabel indeholder en pris på 599,95 dkr.
3. Der skal gives et 30% rabat hvis det er Jul. Find selv på en fornuftig definition af hvornår det er Jul.
4. Udregn den gældende pris (eventuelt rabat medregnet) og gem denne i en variabel.
5. Udskriv denne variabel.
6. Sørg for at teste den logik I har skrevet ved at prøve at tildele den første variable forskellige andre værdier. Hvilke værdier vil være fornuftige at teste?
## 9.4 Længden af en Måned
Skriv et program, hvori
1. En måneds nummer gemmes i en variabel. Denne variabel skal fungere som input til jeres program.
	• Hvilket navn ville være passende for denne variabel?
	• Hvilken type ville være passende for denne variabel?
2. Skriv noget kode der bestemer hvor mange dage der er i den måned som udpeges af denne variabels konkrete værdi (vi antager at det ikke er skudår), og udskriv dette tal.
3. Skriv dette tal ud på skærmen.
4. Tjek kalenderen om jeres kode er korrekt.
## 9.5 Ferie
Undervisningskalenderen fortæller os at der (blandt andet) er følgende ferier:
	• Efterårsferie Oktober
	• Juleferie December
	• Påskeferie April
	• Sommerferie Juli + August
Skriv et program, hvori
1. Et månedsnummer gives via en variabel.
2. Afhængigt af indholdet af denne variabel udskrives en feries navn (hvis der er ferie i måneden) eller “Hårdt arbejde” (hvis der ikke er). 10 Loops

# 10 Loops

## 10.1 Celcius til Fahrenheit 
Skriv et program, hvori
	• Der udskrives en tabel af matchende Celcius og Fahrenheit værdier.
		– Formel: TF = 32 + (9/5)TC
	• Der skal være ét sæt matchende værdier per linje.
	• Listen skal starte med -5◦C og slutte ved 40◦C.
	• Listen skal have én linje for hver 0,5◦C.
## 10.2 Celcius til Fahrenheit i Omvendt Rækkefølge
Omskriv programmet fra opgave 10.1 til at vende rækkefølgen om sådan at første linje udskriver 40◦C og sidste -5◦C.
## 10.3 Celcius til Fahrenheit Alternativer
Lav to andre udgaver af programmet fra opgave 10.1, hvori loopet omskrives til hver af de to resterende typer af loops.
## 10.4 Areal af Cirkler
Skriv et program der udregner og udskriver arealet (π · r2) af tre cirkler med radius på hhv. 1, 3 og 5.
**Bemærk**: Dette er en gentagelse af opgave ??. Denne gang har I flere værktøjer til rådighed.
## 10.5 Primtal 
Skriv et program, der udregner alle primtal under 1.000.000, og udskriver det største.
Hints (se bort fra følgende hints hvis I er friske på en udfordring):
	• Et positivt heltal er et primtal hvis, og kun hvis, der ikke er andre heltal end 1 der går op i det.
	• Benyt en del-og-hersk strategi12, hvor I ser opgaven som tre delopgaver:
		– Gennemløb alle positive heltal under 1.000.000. Har vi ikke en konstruktion der kan det?
		– Bestem om et givent positivt heltal er et primtal.
		– Udprint et heltal (hvis det altså er et primtal).
	• For at bestemme om et givent positivt heltal er et primtal kan I endnu engang benytte del-og-hersk:
		1. Opret en variable af typen boolean ved navn is_prime som er True.
		2. Gennemløb alle heltal fra og med 2 til (men ikke med) 1.000.000.
		3. For hvert af disse tal skal I checke om dette tal går op i det potentielle primtal. Gør de det, så sættes is_prime til False. Men hvordan undersøger man om ét tal går op i et andet?
			– Man prøver det da!
			– Hvis en heltalsdivision går op er det ikke nogen rest og en dermed giver en modulo operation (via operatoren %) nul.
			– Alternativt kan man udnytte at en heltalsdivision kommer til at foretage en afrunding hvis divisionen ikke går op sådan at (a/b) · b ̸= a.
		4. Herefter repræsenterer is_prime en sandhedsværdi for hvovidt et tal er et primtal.
