# Till Mikael

Hej Mikael! Som jag skrev i mailet så hade jag missat att 


# Pseudokod och dokumentation: 
Program.cs skapar en instance av Game klassen som heter game, game kör sin Run metod som egentligen är min main menu. Via Run kommer användaren åt resten av spelet. 
I Run kan användaren välja mellan att se reglerna för spelet, spela spelet, se leaderboards och att avsluta. 
Regelmetoden är bara text som printas till konsolen. 
Spelmetoden skapar 2 variabler för att  hålla kolla på antalet försök användaren har kvar. En bool som heter slutPåFörsök och en int som heter försökKvar. 
Spel metoden skapar även två instancer av tärningsklassen, dvs 2 st tärningar. Sedan körs loopen som pågår så länge som slutPåFörsök är sann. 
Spelet kör den ena tärningens kasta metod som genererar ett random nummer mellan 1 och 6. 
Sedan körs den andra tärningens kasta metod som gör samma sak. sedan räknas summan ihop genom att en metod anropas som tar tärningarnas nummer som argument och räknar ihop totalen, om totalen är lika med 12 returneras en bool som true, annars returneras false. 
Om true har returnerats printas ett grattis meddelande i terminalen, annars räknas antalet försök om och användaren får försöka igen om användaren har försök kvar, om användaren inte har försök kvar printas istället GAME OVER.
