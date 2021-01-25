# Övning 1

## Uppgift 1

Vilka _klasser_ bör ingå i programmet?

Förutom klassen som innehåller `Main` metoden, behöver vi två klasser till: en klass som representerar en anställd, och en klass som håller själva registret över anställda. Klassen som representerar anställda döper vi till `Employee`, och klassen för registret ska vi helt enkelt kalla för `Registry`.

## Uppgift 2

Vilka _attribut_ och _metoder_ bör ingå i dessa klasser?

Enligt uppgiftsbeskrivningen ska registret lagra anställda med namn och lön, så `Employee` klassen behöver dessa två attribut: `name` för namn och `salary` för lönen. Den ska också helst kunna skriva ut sig själv, och för detta kan vi antingen skapa en metod som heter något i stil med `WriteOut()` eller så kan vi överlagra `ToString()` metoden. Vi väljer det senare.

Klassen `Registry` behöver ha en struktur som lagrar alla anställda. För detta ändamål kan vi lättast använda en `List`. Inga andra attribut behövs för närvarande. Metoderna som bör vara med är dels för att lägga till anställda till listan, dels för att skriva ut alla ansällda på listan. Vi skapar ~~en~~ två metoder för att lägga till anställda och döper den till `AddEmployee()`. Metoderna kommer bara att skilja sig i argumenten som de tar -- den ena tar en `Employee` och lägger den direkt i listan, och den andra tar ett namn och ett löndetal och skapar en `Employee` innan den läggs till listan. Vi behöver också en metod som gör det möjligt att skriva ut alla anställda. För detta väljer vi att skapa en metod `GetEmployees()` som går igenom listan och skapar och returnerar en sträng som innehåller namn och lön för varje anställd på sin egen rad.
