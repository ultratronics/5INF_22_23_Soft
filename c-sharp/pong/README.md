# Tutorial: Het maken van een Pong spel in C# (in het Nederlands)

In deze tutorial gaan we stap voor stap leren hoe we een eenvoudig Pong spel kunnen maken in C#. Pong is een klassiek arcadespel waarin twee spelers tegen elkaar strijden om een virtuele bal over het scherm te slaan met behulp van peddels. Laten we beginnen!

## Stap 1: Projectopzet

1. Open Visual Studio en maak een nieuw Windows Forms-toepassingsproject aan.
2. Voeg een PictureBox-besturingselement toe aan het formulier. Dit zal het speelveld van ons Pong spel voorstellen.
3. Voeg twee Panel-besturingselementen toe aan het formulier als peddels voor de spelers.
4. Pas de grootte en positie van de PictureBox en de Panel-besturingselementen aan zodat ze eruitzien als een Pong-speelveld.

## Stap 2: Game logica

Laten we beginnen met het implementeren van de game logica voor ons Pong spel.

### 2.1 Paddle beweging

- Voeg de volgende code toe om de peddels te laten bewegen met behulp van de pijltoetsen van het toetsenbord:

```csharp
private void Form_KeyDown(object sender, KeyEventArgs e)
{
    // Speler 1 (links)
    if (e.KeyCode == Keys.W)
    {
        panelPlayer1.Top -= 10; // Verplaats de peddel omhoog
    }
    else if (e.KeyCode == Keys.S)
    {
        panelPlayer1.Top += 10; // Verplaats de peddel omlaag
    }

    // Speler 2 (rechts)
    if (e.KeyCode == Keys.Up)
    {
        panelPlayer2.Top -= 10; // Verplaats de peddel omhoog
    }
    else if (e.KeyCode == Keys.Down)
    {
        panelPlayer2.Top += 10; // Verplaats de peddel omlaag
    }
}
```

### 2.2 Balbeweging

- Definieer variabelen voor de balpositie en de balrichting:

```csharp
int ballX = 0; // X-positie van de bal
int ballY = 0; // Y-positie van de bal
int ballSpeedX = 5; // Snelheid van de bal in de X-richting
int ballSpeedY = 5; // Snelheid van de bal in de Y-richting
```

- Voeg de volgende code toe aan de `Timer.Tick`-gebeurtenis om de bal te laten bewegen en de botsingen met de peddels en de randen van het speelveld te detecteren:

```csharp
private void gameTimer_Tick(object sender, EventArgs e)
{
    // Beweeg de bal
    ballX += ballSpeedX;
    ballY += ballSpeedY;

    // Controleer op botsingen met de peddels
    if (panelPlayer1.Bounds.IntersectsWith(pictureBoxBall.Bounds) || panelPlayer2.Bounds.IntersectsWith(pictureBoxBall.Bounds))
    {
        ballSpeedX *= -1; // Keer de richting van de bal om
    }

    // Controleer op botsingen met de boven- en onderkant van het speelveld
    if (ballY <= 0 || ballY >= pictureBox.Height -

 pictureBoxBall.Height)
    {
        ballSpeedY *= -1; // Keer de richting van de bal om
    }

    // Werk de positie van de bal bij
    pictureBoxBall.Left = ballX;
    pictureBoxBall.Top = ballY;
}
```

## Stap 3: Grafische weergave

Nu gaan we de grafische weergave van ons Pong spel implementeren.

- Voeg de volgende code toe aan de `Form.Load`-gebeurtenis om de initiële posities van de peddels en de bal in te stellen:

```csharp
private void Form_Load(object sender, EventArgs e)
{
    // Positie van de peddels
    panelPlayer1.Top = pictureBox.Height / 2 - panelPlayer1.Height / 2;
    panelPlayer2.Top = pictureBox.Height / 2 - panelPlayer2.Height / 2;

    // Positie van de bal
    ballX = pictureBox.Width / 2 - pictureBoxBall.Width / 2;
    ballY = pictureBox.Height / 2 - pictureBoxBall.Height / 2;
}
```

- Vergeet niet om de `Form.Load`, `Form.KeyDown` en `Timer.Tick`-gebeurtenissen aan de bijbehorende methoden te koppelen in de ontwerper of in de code.

## Stap 4: Uitvoeren van het spel

Nu zijn we klaar om ons Pong spel uit te voeren!

- Start het spel door het project uit te voeren.
- Gebruik de W- en S-toetsen om de peddel van speler 1 te bewegen.
- Gebruik de pijl-omhoog en pijl-omlaag toetsen om de peddel van speler 2 te bewegen.
- De bal zal beginnen te bewegen zodra het spel wordt gestart.

Gefeliciteerd! Je hebt met succes een eenvoudig Pong spel gemaakt in C#.

Dit was een basisimplementatie van Pong. Je kunt verder bouwen en aanpassingen maken om de functionaliteit en het uiterlijk van het spel te verbeteren. Veel plezier met het ontwikkelen van je eigen Pong spel!

Bedankt voor het volgen van deze tutorial!
