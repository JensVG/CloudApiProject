# CloudApiProject_JensVanGoethem_2019-2020

Het project gaat over de Belgische hoogste voetbal competitie de "Jupiler Pro League".

Op de client zal je eerst je moeten inloggen met een google account inloggen vooralleer je naar de startpagina wordt doorverwezen.
De authenticatie is gemaakt met firebase: https://console.firebase.google.com/project/projectcloudapi-277318/overview .
Eens je inlogt met je google account zal dit account verschijnen in de user lijst: https://console.firebase.google.com/project/projectcloudapi-277318/authentication/users



# Info over de StartPagina
Op de startpagina is er gebruik gemaakt van de thirdpartyapi.
Hierop zal je een tabel krijgen van de leukste wedstrijden van andere competities/toernooien.
In deze tabel zal je de 2 ploegen kunnen zien wie tegen elkaar spelen met een link erbij die je naar highlights en de verdere info over deze wedstrijd stuurt.
De keuze van deze ThirdPartyApi is omdat ik niks van een belgische voetbal API en om toch maar in het thema van het voetbal te blijven heb ik dus gekozen voor deze.
Gebruikte ThirdPartyAPI: https://www.scorebat.com/video-api/v1/ .



# Info over de Spelerspagina
Op de spelerspagina zou je volgende functionaliteiten moeten kunnen hebben.

# Alle Spelers
Deze is weergegeven in een tabel

# 1 bepaalde speler
Men kan kiezen uit alle ID's van de algemeene spelers lijst.
Wordt de keuze bevestigt dan krijgen we de informatie van deze speler te zien.

# Delete van een speler
Men kan kiezen uit alle ID's van de algemeene spelers lijst
Wordt de keuze bevestigt dan wordt de speler verwijdert uit de API en algemeene tabel.

# Searchen op voornaam speler
Men kan in een input veldje een voornaam intypen.
Als deze voornaam gekent is dan zal je over deze speler(s) meer info krijgen.

# Paging
Men via 2 knoppen (Vorige en Volgende) de tabel naar de vorige of volgende tabelpagina toestand brengen.
De knop "vorige" zal verdwijnen als men op de laagste pagina zit.
De knop "volgende" zal verdwijnen als men op de hoogste pagina zit.

# Sorting 
Hiermee kan men de waardes in de tabel gaan sorteren.
Men kan sorteren op : voornaam,achternaam,woonplaats en rugnummer.
De manier van sorteren kan op: voortwaarts of achterwaarts.

# Create
Men kan een nieuwe speler aanmaken hiervoor moet men alle require veldjes invullen.
Eens op de knop bevestigen is gedrukt zal de speler aangemaakt zijn en weertegeven zijn in de tabel.



# Ploegenpagina

# Alle Ploegen
Deze is weergegeven in een tabel

# 1 bepaalde ploeg
Men kan kiezen uit alle ID's van de algemeene ploegen lijst.
Wordt de keuze bevestigt dan krijgen we de informatie van deze ploeg te zien.

# 1 bepaalde ploeg delete
Men kan kiezen uit alle ID's van de algemeene ploegen lijst.
Wordt de keuze bevestigt dan zal deze ploeg uit de tabel verwijdert worden.

# Create
Men kan een nieuwe ploeg aanmaken hiervoor moet men alle require veldjes invullen.
Eens op de knop bevestigen is gedrukt zal de ploeg aangemaakt zijn en weertegeven zijn in de tabel.



#  Update , google cloud en token
Deze onderdelen zijn tot dit moment nog niet 100% functioneel.
