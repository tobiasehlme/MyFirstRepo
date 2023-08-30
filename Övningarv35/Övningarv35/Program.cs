
/* 
1. Skriv ett program som frågar efter användarens namn och skriver ut en hälsning på konsolen. Om namnet är "David" ska det skriva ut "Hej David!"

Console.WriteLine("Vad heter du?");
var namn = Console.ReadLine();
Console.WriteLine("Hej " + namn + "!");
Console.ReadKey();


2. Skriv ett program som frågar användaren efter ett lösenord. Hitta på ett hemligt lösenord och spara det i en variabel.
När användaren har skrivit in ett lösenord ska programmet jämföra med det sparade lösenordet och skriva ut om det var rätt eller inte. Använd en if-sats.

Console.WriteLine("Skriv ett valfritt lösenord");
var password = Console.ReadLine();
Console.WriteLine("För att fortsätta vidare, måste ni skriva in ert lösenord");
if (password == Console.ReadLine())
{
    Console.WriteLine("Du har skrivit rätt lösenord");
}
else
{
    Console.WriteLine("Du har skrivit fel lösenord");
}

3. Skriv ett program som frågar användaren efter ett tal. Det ska skriva ut om talet är mindre än 100, lika med 100 eller större.
Console.WriteLine("Skriv ett tal");
int tal = int.Parse(Console.ReadLine());
if (tal < 100)
{
    Console.WriteLine("Ditt tal är mindre än 100");
}
else if (tal > 100)
{
    Console.WriteLine("Ditt tal är mer än 100");
}
else if (tal == 100)
{
    Console.WriteLine("Ditt tal är 100");
}

4. Uppdatera programmet i uppgift 1 så att det även frågar efter ett tal. Skriv hälsningen så många gånger som användaren anger.

Console.WriteLine("Vad heter du?");
var namn = Console.ReadLine();
Console.WriteLine("Hur många gånger vill du upprepa ditt namn");
int upprepa = int.Parse(Console.ReadLine());
for (int i = 0; i < upprepa; i++)
{
    Console.WriteLine("Hej " + namn + "!");
}

5. Skriv ett program som upprepade gånger frågar användaren efter ett tal ända till man skriver något som inte är ett tal (t.ex bara trycker enter).
Efter varje inmatning ska summan av alla tal som matats in skrivas ut, innan nästa inmatning efterfrågas.
Innan programmet avslutas ska man även skriva ut medelvärde av de inmatade talen. Hint: TryParse()

int Enter = 0;
int counter = 0;
int summa = 0;
int tal = 0;

while (Enter == 0)
{
    Console.WriteLine("Skriv ett tal");
    var input = Console.ReadLine();
   
    if (int.TryParse(input, out tal))
    {
        summa += tal;
        counter++;
        int medelvärde = summa / counter;
        Console.WriteLine("Summan av dina tal är " + summa);
        Console.WriteLine("Medel värdet av dina tal är " + medelvärde);
    }
    else
    {
        Console.WriteLine("Du skrev inte ett tal");
        Console.WriteLine("Programmet avslutas");
        Enter++;
    }    
    
}

6. Skriv ett program som först frågar efter ett tal, sedan frågar efter ett av följande tecken: +, -, * eller /.
Därefter ska ytterligare ett tal efterfrågas. Programmet ska fungera som en simpel miniräknare.
Om man t.ex matat in först 3, sedan *, och sist 5, så ska programmet skriva ut: 3 * 5 = 15.

Console.WriteLine("Skriv ett tal");
int tal1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ange en operator t.ex +, -, * eller /");
var operatör = Console.ReadLine();
Console.WriteLine("Skriv ett till tal");
int tal2 = int.Parse(Console.ReadLine());
if (operatör == "+")
{
    int summa = tal1 + tal2;
    Console.WriteLine(tal1 + " + " + tal2 + " = " + summa);
}
else if (operatör == "-") 
{
    int summa = tal1 - tal2;
    Console.WriteLine(tal1 + " - " + tal2 + " = " + summa);
}
else if (operatör == "*")
{
    int summa = tal1 * tal2;
    Console.WriteLine(tal1 + " * " + tal2 + " = " + summa);
}
else if (operatör == "/")
{
    int summa = tal1 / tal2;
    Console.WriteLine(tal1 + " / " + tal2 + " = " + summa);
}


7. Skriv ett program som ber användaren skriva in en månad. Programmet ska göra om månaden till månadens siffervärde.
T.ex. ska januari bli 1 och december 12. Använd switch. Alternativ: Prova även att lösa uppgiften med array och/eller enum.

string[] månader = {"Januari", "Februari", "Mars", "April", "Maj", "Juni", "Juli", "Augusti", "September", "Oktober", "November", "December" };
Console.WriteLine("Skriv det månad som du vill omvanlda");
string input = Console.ReadLine();
int månad = 1;
for (int i = 0; i < månader.Length; i++)
{
    if (månader[i] == input)
    {
        Console.WriteLine(månad);
    }
    else { månad++; }
}


8. Skapa ett program som skriver ut 1 på första raden, 2 på nästa, sedan 4, o.s.v (dubbelt så hög siffra för varje rad).
Fortsätt till du skrivit ut 16 rader.

int tal = 1;
for (int i = 0; i < 16; i++)
{
    Console.WriteLine(tal);
    tal *= 2;
}


9. Skriv ett program som frågar användaren efter ett tal mellan 1 och 100. Programmet ska ha ett hemligt tal lagrat i en variabel.
Det ska fortsätta fråga användaren till dess att användaren gissar det hemliga talet.
Om man gissade för högt eller för lågt så ska det skrivas ut, så att användaren har en rimlig chans att klara det.
Exempel: programmet har det hemliga talet 27. Användaren gissar på 50. Programmet skriver ut att användaren gissade för högt.
Användaren gissar på 20. Programmet skriver ut att det var för lågt. Användaren gissar på 27. Programmet skriver ut att det var rätt och avslutas.
Extra utmaning: slumpa det hemliga talet med hjälp av Random (kolla upp på google hur det fungerar).
Spara antalet gissningar i en variabel och skriv ut det när användaren gissat rätt.


Random random = new Random();
int secret = random.Next(100);
int gissningar = 1;
int lek = 1;
Console.WriteLine("Gissa på ett tal mellan 0-100");
while (lek == 1)
{
    
    int input = int.Parse(Console.ReadLine());
    if (input > secret) 
    {
        Console.WriteLine("Ditt tal är större än det hemliga talet, gissa igen :-)");
        gissningar++;
    }
    else if (input < secret)
    {
        Console.WriteLine("Ditt tal är mindre än det hemliga talet, gissa igen :-)");
        gissningar++;
    }
    else
    {
        Console.WriteLine("Du gissade rätt!");
        Console.WriteLine("Antal gissningar: " + gissningar);
        lek = 0;

    }
}

Extra utmaning 2: skriv ett sten-sax-påse spel. Användaren skriver in “sten”, “sax” eller “påse”.
Dators val slumpas med Random. Skriv sedan ut vad datorn valde, och vem som vann omgången.
Lägg det hela i en loop så spelet fortsätter tills man matar in en tom sträng (trycker enter utan att skriva något). Skriv även ut poäng.


string[] SSP = { "Sten", "Sax", "Påse" };
int kör = 1;
int poäng = 0;
while (kör == 1)
{

    Random random = new Random();
    int i = random.Next(SSP.Length);
    Console.WriteLine("Dina poäng är " + poäng);
    Console.WriteLine("Skriv Sten, Sax eller Påse för att tävla med datorn");
    var input = Console.ReadLine();
    if (input == "") { kör = 0; }
    if (input == "Sten")
    {
        if (SSP[i] == "Sax")
        {
            Console.WriteLine("Du hade " + input + " och datorn hade " + SSP[i]);
            Console.WriteLine("Du vann!");
            poäng++;
        }
        else if (SSP[i] == "Påse")
        {
            Console.WriteLine("Du hade " + input + " och datorn hade " + SSP[i]);
            Console.WriteLine("Du förlorade!");
            poäng--;
        }
        else
        {
            Console.WriteLine("Du hade " + input + " och datorn hade " + SSP[i]);
            Console.WriteLine("Det blev oavgjort!");
        }
    

    }
    if (input == "Sax")
    {
        if (SSP[i] == "Sax")
        {
            Console.WriteLine("Du hade " + input + " och datorn hade " + SSP[i]);
            Console.WriteLine("Det blev oavgjort");
        }
        else if (SSP[i] == "Påse")
        {
            Console.WriteLine("Du hade " + input + " och datorn hade " + SSP[i]);
            Console.WriteLine("Du vann!");
            poäng++;
        }
        else
        {
            Console.WriteLine("Du hade " + input + " och datorn hade " + SSP[i]);
            Console.WriteLine("Du förlorade!");
            poäng--;
        }
    }
    if (input == "Påse")
    {
        if (SSP[i] == "Sax")
        {
            Console.WriteLine("Du hade " + input + " och datorn hade " + SSP[i]);
            Console.WriteLine("Du förlorade!");
            poäng--;
        }
        else if (SSP[i] == "Påse")
        {
            Console.WriteLine("Du hade " + input + " och datorn hade " + SSP[i]);
            Console.WriteLine("Det blev oavgjort!");
        }
        else
        {
            Console.WriteLine("Du hade " + input + " och datorn hade " + SSP[i]);
            Console.WriteLine("Du vann!");
            poäng++;
        }
    }


}

10. Be användaren mata in en sträng. Skriv ut varje tecken i strängen på en egen rad. Ex:

Hej
H
e
j


Console.WriteLine("Skriv en sträng som ska delas upp");
var input = Console.ReadLine();
for (int i = 0; i < input.Length; i++)
{
    Console.WriteLine(input[i]);
}
Console.ReadLine();

11. Skapa ett program med en array som innehåller strängarna “noll”, “ett”, “två”, “tre”, “fyra”, “fem”, “sex”, “sju”, “åtta”, “nio”. 
Be sedan användaren att mata in en siffra. Använd arrayen för att skriva ut siffrans ord. Ex. Inmatning “3” => “tre”.
Extra utmaning: Användaren kan mata in en sträng med fritt antal siffror, om man skriver in t.ex 432 så svarar programmet: “fyra-tre-två”.
*/

string[] nummer = new string[] { "Noll", "Ett", "Två", "Tre", "Fyra", "Fem", "Sex", "Sju", "Åtta", "Nio" }; // Array skapas
Console.WriteLine("Skriv en siffra"); // Frågar efter siffra
string usernummer = Console.ReadLine(); // Lägger användarens input i en sträng variabel
if (usernummer.Length == 1) // Checkar ifall användaren har skrivit fler än 1 siffra
{
    for (int i = 0; i < nummer.Length; i++) // Loop skapas för att gå igenom nummer arrayen
    {
        if (int.Parse(usernummer) == i) // Omvandlar användarens input till en int och checkar ifall den stämmer överens med index
        {
            Console.WriteLine(nummer[i]); 
        }
    }
}
else // Kommer till detta läge ifall man har skrivit flera nummer
{
    for (int i = 0;i < usernummer.Length; i++) // Går igenom användarens input och körs lika många gånger som användaren skrev för nummer
    {
        string test = usernummer[i].ToString(); // Omvandlar nummer var för sig och lägger de i en sträng
        int värde = int.Parse(test); // Omvandlar strängen till en int
        for (int j = 0; j < nummer.Length; j++) // Samma som rad 290
        {
            if (värde == j) // Checkar ifall värdet stämmer överens med index
            {
                Console.Write(nummer[j] + "-"); // Skriver ut nummer i text form fortsatt med bindestreck
            }
        }
    }
}
// Behöver skriva om då det finns ett bättre sätt.
Console.ReadKey();
