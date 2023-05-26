# Inleiding tot C-programmering

C is een krachtige en veelgebruikte programmeertaal, bekend om zijn efficiëntie en laagniveaucontrole over computerhardware. In deze tutorial zullen we de basisprincipes van C-programmering verkennen.

## Voorwaarden

Voordat we beginnen, moeten we ervoor zorgen dat de juiste tools zijn geïnstalleerd en geconfigureerd op ons systeem:

1. **Compiler**: Zorg ervoor dat je een C-compiler hebt geïnstalleerd. Een populaire keuze is GCC (GNU Compiler Collection). Je kunt het installeren door het volgende commando uit te voeren:

   ```shell
   sudo apt-get install build-essential
   ```

2. **Teksteditor**: Kies een teksteditor om je C-programma's te schrijven. Enkele populaire keuzes zijn Visual Studio Code, Atom en Sublime Text.

## Eerste C-programma

Laten we beginnen met het schrijven van ons eerste C-programma: "Hello, World!".

1. Open je teksteditor en maak een nieuw bestand aan met de naam `hello.c`.

2. Voeg de volgende code toe aan `hello.c`:

   ```c
   #include <stdio.h>

   int main() {
       printf("Hello, World!\n");
       return 0;
   }
   ```

3. Sla het bestand op.

## Compilatie en Uitvoering

Nu moeten we ons C-programma compileren en uitvoeren:

1. Open de terminal en navigeer naar de map waarin je `hello.c` hebt opgeslagen.

2. Voer het volgende commando uit om het programma te compileren:

   ```shell
   gcc hello.c -o hello
   ```

   Dit zal een uitvoerbaar bestand `hello` genereren.

3. Voer het programma uit met het volgende commando:

   ```shell
   ./hello
   ```

   Je zou "Hello, World!" als uitvoer moeten zien.

Gefeliciteerd! Je hebt met succes je eerste C-programma geschreven, gecompileerd en uitgevoerd.

## Variabelen en Gegevenstypen

Variabelen worden gebruikt om gegevens op te slaan en te manipuleren in een C-programma. Laten we eens kijken naar enkele veelvoorkomende gegevenstypen in C:

- **int**: Geheel getal (bijvoorbeeld: 1, -5, 100)
- **float**: Zwevendekomma getal (bijvoorbeeld: 3.14, -0.5, 2.0)
- **char**: Karakter (bijvoorbeeld: 'a', 'B', '@')
- **double**: Dubbel precisie zwevendekomma getal (bijvoorbeeld: 3.14159, -1.234)

Om een variabele te declareren en te initialiseren, volg je deze syntax:

```c
gegevenstype variabelenaam = waarde;
```

Hier is een voorbeeld dat het gebruik van variabelen laat zien:

```c
#include <stdio.h>

int main() {
    int leeftijd = 25;
    float gewicht = 68.5;
    char initiaal = 'J';
    double pi = 3.14159;

    printf("Leeftijd: %d\n", leeft

ijd);
    printf("Gewicht: %.1f\n", gewicht);
    printf("Initiaal: %c\n", initiaal);
    printf("Pi: %.5f\n", pi);

    return 0;
}
```

## Gebruikersinvoer

Je kunt ook input van de gebruiker lezen met behulp van de functie `scanf()`. Hier is een voorbeeld:

```c
#include <stdio.h>

int main() {
    int getal;

    printf("Voer een getal in: ");
    scanf("%d", &getal);

    printf("Het ingevoerde getal is: %d\n", getal);

    return 0;
}
```

In dit voorbeeld vragen we de gebruiker om een getal in te voeren en slaan we het op in de variabele `getal`. Let op het gebruik van `&` voor de variabelenaam in de `scanf()`-functie.

Dit was een inleiding tot C-programmering. Je hebt de basisprincipes geleerd, zoals het schrijven van je eerste programma, variabelen en gegevenstypen, en het lezen van gebruikersinvoer. Je kunt nu beginnen met het verkennen van meer geavanceerde concepten in C. Veel succes!



# Arrays, Variabelen, Char Arrays en Basisconcepten in C

In C zijn arrays, variabelen en char arrays enkele van de fundamentele concepten. Laten we elk concept apart bekijken:

## Variabelen

Variabelen in C worden gebruikt om gegevens op te slaan en te manipuleren. Voordat je een variabele kunt gebruiken, moet je deze declareren met een specifiek gegevenstype. Hier is een voorbeeld:

```c
#include <stdio.h>

int main() {
    int getal = 5;
    float decimaal = 3.14;
    char teken = 'A';

    printf("Getal: %d\n", getal);
    printf("Decimaal: %.2f\n", decimaal);
    printf("Teken: %c\n", teken);

    return 0;
}
```

In dit voorbeeld hebben we variabelen van de gegevenstypen `int`, `float` en `char` gedeclareerd en geïnitialiseerd met bepaalde waarden. Vervolgens gebruiken we `printf()` om de waarden van de variabelen af te drukken.

## Arrays

Een array is een gegevensstructuur die een verzameling van gelijksoortige elementen opslaat. Elk element in een array heeft een unieke index, beginnend bij 0. Hier is een voorbeeld van het declareren en gebruiken van een array in C:

```c
#include <stdio.h>

int main() {
    int getallen[5] = {1, 2, 3, 4, 5};

    printf("Element 0: %d\n", getallen[0]);
    printf("Element 2: %d\n", getallen[2]);

    return 0;
}
```

In dit voorbeeld hebben we een array `getallen` van lengte 5 gedeclareerd en geïnitialiseerd met enkele waarden. We kunnen individuele elementen van de array benaderen met behulp van de indexnotatie (`getallen[index]`). Hier drukken we de waarden van element 0 en element 2 af.

## Char Arrays (Strings)

In C worden strings meestal gerepresenteerd door char arrays. Een char array is een array van tekens met een speciaal karakter `\0` (nullkarakter) aan het einde om het einde van de string aan te geven. Hier is een voorbeeld:

```c
#include <stdio.h>

int main() {
    char groet[6] = {'H', 'e', 'l', 'l', 'o', '\0'};

    printf("Groet: %s\n", groet);

    return 0;
}
```

In dit voorbeeld hebben we een char array `groet` gedeclareerd en geïnitialiseerd met de individuele tekens van het woord "Hello". Let op het nullkarakter aan het einde van de array. We kunnen de volledige string afdrukken met behulp van de `%s`-specifier in `printf()`.

## Basisconcepten

Naast variabelen, arrays en char arrays zijn er nog enkele andere basisconcepten die belangrijk zijn in C-programmering:

- **Functies**: Functies in C zijn blokken van code die een specifieke taak uitvoeren. Een C-programma begint altijd met de `main

()`-functie, die het startpunt van het programma is. Je kunt ook je eigen functies definiëren en gebruiken.

- **Besturingssystemen**: C biedt verschillende besturingssystemen om de uitvoeringsvolgorde van instructies te regelen, zoals `if`, `else`, `while`, `for`, `switch`, enzovoort. Deze structuren helpen bij het nemen van beslissingen en het herhalen van codeblokken.

- **Invoer en uitvoer**: C biedt verschillende functies voor het lezen van invoer van gebruikers en het schrijven van uitvoer naar het scherm. `scanf()` wordt bijvoorbeeld gebruikt voor invoer en `printf()` voor uitvoer.

Dit was een korte introductie tot arrays, variabelen, char arrays en enkele andere basisconcepten in C-programmering. Deze concepten vormen de basis voor het schrijven van complexere programma's. Veel succes met het verkennen van C-programmering!
