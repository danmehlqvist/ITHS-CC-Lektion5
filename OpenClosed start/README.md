## EXEMPEL PÅ STEG FÖR ATT REFAKTORERA ErrorLogger

1.	Vi vill bygga bort switchen och ersätta den med ett interface.

2.	Skapa ett Interface ILoggingStrategy som har en metod void Log(string message);

3.	Implementera ILoggingStrategy för fallen som vi har i switchen.

4.  Ändra konstruktorn så att den tar emot ett ILoggingStrategy istället för en sträng.

5.	Ändra koden så den använder ILoggingStrategy för att logga.

6.	Nu kan vi utan att förändra ErrorLogger fixa till en loggning ner i databas till exempel.

7.	Detta är ett exempel på ett design pattern som kallas för Strategy Pattern.