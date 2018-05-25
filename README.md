# Hardcover form

Applicatie ontwikkeld in .NET Core 2.0 met Entity Framework Code-First, Visual Studio 2017.

## Gebruik
Database synchroniseren gebeurt met het Powershell-commando `Update-Database` via de Package Manager Console in VS. Alles is Code-First dus database hoeft niet zelf aangemaakt te worden.

De connection string moet voor een SQL database zijn en is te vinden in `appsettings.json`.

## Models

`Models/SalesForm.cs` is het model voor een hardcover formulier. Dit wordt gebruikt door Entity Framework om de  tabel te maken in de database met deze velden.

De front-end gebruikt dit model ook voor de tekstvakken, checkboxes,..

## Views
`Views/Home/Index.cshtml` bevat een overzicht van alle gemaakte formulieren. Hier kan je ze bewerken, downloaden als PDF, verwijderen,..

`Views/Home/Create.cshtml` is het formulier voor het aanmaken en bewerken van een hardcover formulier. Dit wordt opgeroepen via de Create van de HomeController.

`Views/Home/Details.cshtml` is gelijkaardig aan Create maar toont enkel de waardes (geen inputvelden). Deze URL wordt gebruikt door de PDFgenerator.

## Controllers
De methodes van de controller zijn vanzelfsprekend (Edit, Save, Details, Delete, Index).

De Download methode zal via de Details-url een HTML document ophalen dat kan gegeven worden aan de PDFgenerator.

De PDFgenerator is een singleton dat via dependency injection in de HomeController terecht komt. Het resultaat (de bytes in het geheugen, er wordt niks opgeslagen naar disk) worden als een File gestuurd naar de client.

Het grootste probleem met de generator is het plaatsen van de libwkhtmltox.dll. Op het moment van schrijven moest ik manueel via de PATH variabele tonen waar deze PDF te vinden was, anders vond hij hem niet op het moment dat de conversie gebeurt. Heb al geprobeerd hem toe te voegen aan het project en 'Copy always' te selecteren, maar dit werkt niet.

Vermoedelijk komt dit omdat IIS vanuit een andere plaats start dan de projectmap, waardoor de working directory niet klopt en hij de DLL niet kan vinden.