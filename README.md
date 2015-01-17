roguelike
===========
Ein Roguelike in C#, das als Schulprojekt für den Einstieg in die Programmierung dienen kann/soll. Es werden Arrays und Dateioperationen behandelt. Vertiefende Themen können aus den Bereichen der Computergrafik ([Double Buffering](https://de.wikipedia.org/wiki/Doppelpufferung), der künstlichen Intelligenz (Computerspieler) oder der Algorithmik (Wegfindung, Field Of View)) kommen.

Fachliche Konzepte
------------------

Am Beispiel von Roguelikes lassen sich viele unterschiedliche fachliche Konzepte untersuchen.

### Double Buffering

Wenn man das Dungeon in der TextBox der Windows-Form direkt zeichnet, kann man
schon bei kleinen Felder ein Flackern bemerken. Erst das Schreiben in einen
Zwischenpuffer - z.B. einen String - und das anschließende Kopieren in die
TextBox verhindert das Problem.

Weiterführende Links
--------------------

* [Wikipedia-Artikel Rogue-like](https://de.wikipedia.org/wiki/Rogue-like)
* [roguebasin](http://www.roguebasin.com/) - englisch sprachige Webseite mit vielen Informationen
* [Video: Roguelikes, and building one (ab Minute 17)](http://media.ccc.de/browse/congress/2014/31c3_-_6579_-_en_-_saal_g_-_201412291245_-_lightning_talks_day_3_-_theresa.html) 
