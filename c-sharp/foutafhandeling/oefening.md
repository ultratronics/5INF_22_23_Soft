Voorbeeld:

Stel dat je een functie hebt genaamd `DivideNumbers` die twee getallen deelt. Om ervoor te zorgen dat de functie veilig wordt uitgevoerd, moet je rekening houden met het scenario waarin de tweede parameter, de deler, gelijk is aan nul. Dit zou een `DivideByZeroException` genereren. Je kunt dit probleem oplossen door een try-catch blok te gebruiken om de uitzondering af te vangen en hiermee om te gaan.

```csharp
using System;

class Program
{
    static void Main()
    {
        int dividend = 10;
        int divisor = 0;
        int result = 0;

        try
        {
            result = DivideNumbers(dividend, divisor);
            Console.WriteLine("Het resultaat van de deling is: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Fout: Kan niet delen door nul.");
        }
    }

    static int DivideNumbers(int dividend, int divisor)
    {
        return dividend / divisor;
    }
}
```

In dit voorbeeld wordt de functie `DivideNumbers` aangeroepen met een dividend van 10 en een divisor van 0. Omdat delen door nul niet mogelijk is, wordt er een `DivideByZeroException` gegenereerd. De try-catch blok vangt deze uitzondering af en geeft een foutmelding weer in plaats van het programma te laten crashen.

Nu volgen drie probleemsets voor deze les:

Probleemset 1: Bestandslezen
Schrijf een programma dat een bestand opent en de inhoud ervan leest. Gebruik een try-catch blok om eventuele fouten bij het openen of lezen van het bestand af te vangen. Toon een foutmelding als het bestand niet kan worden geopend of gelezen.

Probleemset 2: Rekenmachine
Ontwikkel een eenvoudige rekenmachine waarin de gebruiker twee getallen en een operator (+, -, *, /) invoert. Gebruik een try-catch blok om uitzonderingen af te vangen die kunnen optreden bij het verwerken van de invoer. Toon een foutmelding als de invoer ongeldig is of als er een uitzondering optreedt tijdens de berekening.

Probleemset 3: Gegevensvalidatie
Schrijf een programma dat de gebruiker vraagt om zijn/haar leeftijd in te voeren. Gebruik een try-catch blok om uitzonderingen af te vangen die kunnen optreden bij het parsen van de invoer naar een getal. Toon een foutmelding als de invoer geen geldige leeftijd is (bijvoorbeeld een negatief getal of een niet-numerieke waarde).

Deze probleemsets zullen je helpen om de concepten van foutafhandeling en uitzonderingen in C# te oefenen en je programmeervaardigheden verder te ontwikkelen. Veel succes met het oplossen van de problemen!
