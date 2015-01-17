roguelike
===========
Ein Roguelike in C#, das als Schulprojekt für den Einstieg in die Programmierung
dienen kann/soll. Es werden Arrays und Dateioperationen behandelt. Vertiefende
Themen können aus den Bereichen der Computergrafik ([Double
Buffering](https://de.wikipedia.org/wiki/Doppelpufferung), der künstlichen
Intelligenz (Computerspieler) oder der Algorithmik (Wegfindung, Field Of View))
kommen.

Fachliche Konzepte
------------------

Am Beispiel von Roguelikes lassen sich viele unterschiedliche fachliche Konzepte
untersuchen. 

### Double Buffering

Wenn man das Dungeon in der TextBox der Windows-Form direkt zeichnet, kann man
schon bei kleinen Felder ein Flackern bemerken. Erst das Schreiben in einen
Zwischenpuffer - z.B. einen String - und das anschließende Kopieren in die
TextBox verhindert das Problem.

### Dungeon Generierung

Die Generierung des Dungeons kann auf unterschiedliche Arten erfolgen und
beliebig kompliziert realisiert werden. Eine einfache Art ist die manuelle
Erzeugung und Speicherung in Textdateien, die während des Spiels geladen werden.

Interessanter wird es bei automatisch generierten Dungeons. Das roguebasin-Wiki
bietet sich hier als wahre Fundgrube an. Ein einfacher Algorithmus ist
[hier](http://www.roguebasin.com/index.php?title=Maze_Generation) beschrieben.
Eine komplexere Version gibt es an
[dieser](http://www.roguebasin.com/index.php?title=Dungeon-Building_Algorithm)
Stelle. Schließlich findet man
[hier](http://www.roguebasin.com/index.php?title=Dynamically_Sized_Maze) eine
Sammlung weiterer Verfahren. 

Weiterführende Links
--------------------

* [Wikipedia-Artikel Rogue-like](https://de.wikipedia.org/wiki/Rogue-like)
* [roguebasin](http://www.roguebasin.com/) - englisch sprachige Webseite mit
vielen Informationen.
* [Video: Roguelikes, and building one (ab Minute
17)](http://media.ccc.de/browse/congress/2014/31c3_-_6579_-_en_-_saal_g_-_201412291245_-_lightning_talks_day_3_-_theresa.html)
