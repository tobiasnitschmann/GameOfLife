# Game of Life
Implementierung im Rahmen eines Seminars zum Thema Clean Code und TTD in .net6 und C#. Die Tests kamen leider etwas zu kurz. Die Implementierung des bekannten Regelwerks war interessanter :)

## Entwicklungsumgebung
- Ich habe hier Visual Studio 2022 for Mac (Preview) verwendet. Das Projekt sollte aber auch auf anderen Umgebungen lauffähig sein.
- Die MVC Applikation enthält noch einigen generierten Code, der nicht benätigt wird.

## Features
- Das Spielbrett wird mit einem 15 x 35 Raster initialisiert auf dem sich 2 Objekt befinden. Darunter ein Blinker und ein Gleiter
- Jeder Browser-Refresh initiiert einen Evolutionsschritt
- Die Browser Session wird als Speicher verwendet. Möchte man wieder zum Start,muss eine neue Session über einen neuen Browser geöffnet werden oder die App neugestartet werden. 

## Weiterentwicklungsideen
- Session-Handling
- Reset der Session über "Zurück auf Anfang"-Button
- Über User-Eingabe realisieren
- Status einzelner Zellen manuell veränderbar machen,sodass man zum Start eigene Ausgangssituationen schaffen kann
- Automatischer Refresh des Browsers
- ....
