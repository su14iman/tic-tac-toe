# Tic-Tac-Toe

- **Bezeichnung**:  
    Tic-Tac-Toe (XO)-Spiel für der Konsole programmiert auf der C#-Sprache
- **Spiellogik**:  
    Auf einem quadratischen, 3×3 Felder großen Spielfeld setzen die beiden Spieler abwechselnd ihr Zeichen (ein Spieler Kreuze, der andere Kreise) in ein freies Feld. Der Spieler, der als Erster drei Zeichen in eine Zeile, Spalte oder Diagonale setzen kann, gewinnt. Wenn allerdings beide Spieler optimal spielen, kann keiner gewinnen, und es kommt zu einem Unentschieden. Das heißt, alle neun Felder sind gefüllt, ohne dass ein Spieler die erforderlichen Zeichen in einer Reihe, Spalte oder Diagonalen setzen konnte.
    
- **Benutztes Werkzeug**:
	-   Visual studio (IDE)
	-   C# (logic)

- **Elemente**:
	-   ***Tisch***: die Feldern auswählen und die Gewinnsituation überprüfen.
	-   ***Spieler***: Mensch oder ein Bot ,, Der Bot trifft zufällige Entscheidungen aus den verfügbaren Feldern.

-   **Szenario**:

	-   Das Spiel beginnt mit der Aufforderung, den Namen des Spielers einzugeben
	-   Die Rolle des Spielers (Mensch) beginnt zunächst mit der Auswahl ein Felder
	-   Dann die Rolle geht an den Bot, um zufällig auszuwählen
	-   Das Spiel endet mit einem Gewinn für ein Spieler oder Unentschieden, wenn alle Felder ausgefüllt sind

-   **Classes Diagram**:

![Alt text](/doc/images/uml_classes.png?raw=true "Classes Diagram")

-   **Flowchart**:

    - GameManger
    ![Alt text](/doc/images/flowchart_gamemanger.svg "flowchart GameManger")

    - Tisch
    ![Alt text](/doc/images/flowchart_tisch.svg "flowchart Tisch")

    - Spieler
    ![Alt text](/doc/images/flowchart_spieler.svg "flowchart Spieler")
