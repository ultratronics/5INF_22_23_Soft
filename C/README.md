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
