# Random Number Guessing Game

## Aufgabenstellung und Ziele

Selbst Programmiertes Game um mir selbst das **Programmieren** näher zu bringen.

1. Der Leser soll nach dem Eintrag verstehen wieso IF-Statements so wichtig sind beim Programmieren


# Text + Code Zeile:
In meinem Projekt waren IF-Statements Elementar und ohne diese würde das Programm nicht funktionieren.
```csharp
If (if (a > value)
                    {
                    Console.WriteLine("Guess Lower");
                    }
                    else if (a < value)
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Guess Higher");
                    }
                    else if (a == value)
                     {
                    Console.WriteLine("Bravo, you did it! Now get yourself a cookie and go outside")
                    }
```
Hier ist der Wert (Value) der Zufälligen Generierten Zahl, welcher verwendet wird um den Userinput (a) mit der Zufallszahl abzugleichen. Sobald (Value == a) ist wird das Programm beendet mit einem Kleinen Victory Text. Währe dies nicht da könnte die While-Schleife nicht beendet werden wenn (Value == a) und das Programm würde endlos weitergehen.
## Screenshot
https://raw.githubusercontent.com/SgtStalin/LA1200/main/Screenshot%20(18).png
## Video
https://youtu.be/aehjV9Ylv0A/

## Verifikation + Refklektion
Verifikation:
Ich habe diese Ziele Erreicht
Ziel 1: Wird mit dem Video, Screenshot und TExtlicher beschreibung + Code Snippets erklärt.

Reflektion: Ich habe viel zu lange mich an Problemen aufgehalten anstatt sie später zu lösen. Nächstes mal werde ich nicht zu lange an einem Problem sitzen, sondern nachfragen oder zum nächsten Auftrag übergehen.
