## EXEMPEL PÅ STEG FÖR ATT REFAKTORERA CsvFileProcessor

1.	Identifiera vad CsvFileProcessor faktiskt gör; hämtar, manipulerar och sparar.

2.	Lägg funktionaliteten ovan i private metoder som delsteg.

3.  Skapa interface för att hämta: IDataProvider

4.	Implementera IDataProvider. Ta emot IDataProvider i konstruktorn.

5.  Gör samma manöver för manipulera och spara. IDataParser och IDataSaver

6.	Byt namn på CsvFileProcessor så det blir mer passande.

7.  Vi har nu brutit ut funktionaliteten i mindre klasser. Som en liten bonus har vi också
	sett till att vi använder en abstraktion av implementationen. Det har vi löst genom Dependency
	Injection.