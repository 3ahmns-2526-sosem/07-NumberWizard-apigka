# 07-NumberWizard-apigka

Ein interaktives Ratespiel in Unity, bei dem die künstliche Intelligenz (der "Number Wizard") versucht, eine vom Spieler ausgedachte Zahl durch gezieltes Fragen zu erraten.

Unity Version 6000.0.57f1

---

## Ziel des Spiels

Der Spieler denkt sich im Kopf eine Zahl in einem festgelegten Bereich aus (z. B. zwischen 1 und 1000). Der *Number Wizard* schlägt daraufhin Zahlen vor. Der Spieler gibt dem System über Buttons Feedback, ob die gesuchte Zahl höher oder niedriger ist, bis der Wizard die korrekte Zahl erraten hat.

---

## Bedienung & Buttons

Das Spiel wird komplett über die Benutzeroberfläche (UI) gesteuert. Es stehen vier Buttons zur Verfügung:

* **Higher:** Drücke diesen Button, wenn deine ausgedachte Zahl **größer** ist als der aktuelle Vorschlag des Wizards.
* **Lower:** Drücke diesen Button, wenn deine ausgedachte Zahl **kleiner** ist als der aktuelle Vorschlag des Wizards.
* **Correct:** Drücke diesen Button, wenn der Wizard deine Zahl **exakt erraten** hat. Das Spiel wird daraufhin beendet und zeigt eine Erfolgsmeldung an.
* **Restart:** Setzt das Spiel nach einem Erfolg (oder zwischendurch) wieder auf den ursprünglichen Startbereich zurück, aktiviert alle Buttons und startet eine neue Runde.
