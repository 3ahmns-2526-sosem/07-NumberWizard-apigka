# 07-NumberWizard-apigka

Markdown Cheatsheet: https://github.com/adam-p/markdown-here/wiki/markdown-cheatsheet

Unity - Number Wizard (Zahlen-Zauberer)

Ein einfaches, interaktives 2D-Ratespiel, entwickelt mit der Unity Engine und C#. Dieses Projekt dient als ideales Einstiegsprojekt, um die Grundlagen der Spieleentwicklung und algorithmisches Denken praxisnah zu erlernen.


## Das Spielprinzip
Der Spieler denkt sich im Kopf eine geheime Ganzzahl in einem bestimmten Bereich aus (Standard: `1` bis `1000`). Der **Number Wizard** (die KI des Spiels) versucht, die Zahl durch strategisches Raten so schnell wie möglich herauszufinden.

Nach jedem Rateversuch gibt der Spieler dem Computer über die Benutzeroberfläche (UI) ein Feedback:
* **Höher (+):** Die gedachte Zahl ist größer als der Tipp des Computers.
* **Niedriger (-):** Die gedachte Zahl ist kleiner als der Tipp des Computers.
* **Korrekt (=):** Der Computer hat die Zahl erraten! Das Spiel wechselt in den Gewinnbildschirm.

Der mathematische Algorithmus
Um die Zahl mit möglichst wenigen Versuchen zu ermitteln, nutzt das Spiel das Prinzip der **Binären Suche (Binary Search)**. 
Anstatt blind zu raten, halbiert das Skript nach jedem Feedback den verbleibenden Suchraum:

$$\text{guess} = \frac{\text{min} + \text{max}}{2}$$

Durch diese Vorgehensweise ist garantiert, dass das System selbst bei einem großen Zahlenbereich von 1 bis 1000 die gesuchte Zahl in **maximal 10 Versuchen** ($\log_2 1000 \approx 10$) exakt bestimmt.
