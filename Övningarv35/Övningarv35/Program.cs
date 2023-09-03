
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
string input = Console.ReadLine();
for (int i = 0; i < input.Length; i++)
{
    Console.WriteLine(input[i]);
}

11. Skapa ett program med en array som innehåller strängarna “noll”, “ett”, “två”, “tre”, “fyra”, “fem”, “sex”, “sju”, “åtta”, “nio”. 
Be sedan användaren att mata in en siffra. Använd arrayen för att skriva ut siffrans ord. Ex. Inmatning “3” => “tre”.
Extra utmaning: Användaren kan mata in en sträng med fritt antal siffror, om man skriver in t.ex 432 så svarar programmet: “fyra-tre-två”.


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
//
// 12. Fråga användaren hur många tal den vill mata in. Fråga sedan efter talen i tur och ordning (“Ange tal 1:” osv).
// När alla tal är inmatade skriv ut dem i omvänd ordning.

Console.WriteLine("Hur många tal vill du skriva in?");
int userindex = int.Parse(Console.ReadLine());
int[] tal = new int[userindex];
int counter = 1;
for (int i = 0; i < tal.Length; i++)
{
    Console.WriteLine("Ange tal " + counter + ":");
    int holder = int.Parse(Console.ReadLine());
    tal[i] = holder;
    counter++;
}
Array.Reverse(tal);
for (int i = 0;i < tal.Length; i++)
{
    Console.Write(tal[i]);
}

13. Be användaren mata in en text. Skriv sedan ut texten baklänges.


Console.WriteLine("Skriv en text för att skrivas ut baklänges");
string userinput = Console.ReadLine();
string[] omvandlare = new string[userinput.Length];
for (int i = 0; i < userinput.Length; i++)
{
    omvandlare[i] += userinput[i];
}
Array.Reverse(omvandlare);
for (int i = 0;i < omvandlare.Length;i++)
{
    Console.Write(omvandlare[i]);
}

14. Be användaren mata in en text. Skriv ut texten med alla vokaler ersatta med *

Console.WriteLine("Skriv en text för att ersätta alla vokaler");
string userinput = Console.ReadLine();
string[] konsonanter = new string[userinput.Length];
userinput = userinput.ToLower();
for (int i = 0; i < konsonanter.Length; i++)
{
    if (userinput[i] == 'a' || userinput[i] == 'o' || userinput[i] == 'u' || userinput[i] == 'å' || userinput[i] == 'e' || userinput[i] == 'i' || userinput[i] == 'y' || userinput[i] == 'ä' || userinput[i] == 'ö')
    {
        konsonanter[i] += "*";
    }
    else
    {
        konsonanter[i] += userinput[i];
    }
}
for (int i = 0;i < konsonanter.Length; i++)
{
    Console.Write(konsonanter[i]);
}

// Extra utmaning: Skriv ut texten översatt till rövarspråket.

Console.WriteLine("Skriv en text som ska översättas till röverspråket");
string userinput = Console.ReadLine();
string[] konsonanter = new string[userinput.Length];
userinput = userinput.ToLower();
for (int i = 0; i < konsonanter.Length; i++)
{
    if (userinput[i] == 'a' || userinput[i] == 'o' || userinput[i] == 'u' || userinput[i] == 'å' || userinput[i] == 'e' || userinput[i] == 'i' || userinput[i] == 'y' || userinput[i] == 'ä' || userinput[i] == 'ö')
    {
        konsonanter[i] += userinput[i];
    }
    else if (userinput[i] == ' ')
    {
        konsonanter[i] += ' ';
    }
    else
    {
        konsonanter[i] += userinput[i];
        konsonanter[i] += "o";
        konsonanter[i] += userinput[i];

    }
}
for (int i = 0; i < konsonanter.Length; i++)
{
    Console.Write(konsonanter[i]);
}

// 15. Ett palindrom är ett ord som blir samma framlänges som baklänges.
// Be användaren skriva in ett ord och ange sedan om det är ett palindrom eller inte.
Console.WriteLine("Skriv ett ord som du tror är ett palindrom");
string userinput = Console.ReadLine();
int nummer = 1;
char holder;
for (int i = 0; i <= userinput.Length - 1; i++)
{
    holder = userinput[userinput.Length - nummer];
    if (userinput[i] == holder)
    {
        nummer++;
    }
    else if (userinput[i] != holder)
    {
        Console.WriteLine("Detta är ingen palindrom");
        break;
    }
}
nummer = 0;
if (userinput[nummer] == userinput[userinput.Length - 1])
{
    Console.WriteLine("Det är ett palindrom!");
    
}

16.Skriv ett program som först frågar efter ett tal, sedan frågar efter ett av följande tecken: +, -, *eller /.
Därefter ska ytterligare ett tal efterfrågas. Programmet ska fungera som en simpel miniräknare.
Om man t.ex matat in först 3, sedan *, och sist 5, så ska programmet skriva ut: 3 * 5 = 15.
Gör om uppgift 6 så man kan mata in allt på en rad (första talet, operator, andra talet).
Ignorera inmatade mellanslag i strängen. Om man t.ex. matar in strängen “34 - 14”, så ska programmet skriva ut “= 20”.
*/

Console.WriteLine("Skriv en beräkning som ska uträknas.");
string userinput = Console.ReadLine();
string[] holder = new string[userinput.Length];
for (int i = 0; i <= userinput.Length - 1; i++)
{
    if (userinput[i] != ' ')
    {
        holder[i] += userinput[i];
    }
}
int tal = 0;
string test2 = "";
for (int i = 0;i < holder.Length - 1; i++)
{
    if (holder[i] != null)
    {
        if (int.Parse(holder[i]) is int)
        {
            Console.WriteLine("teeeest");
        }
        if (holder[i] != "+" && holder[i + 1] != "+")
        {
            if (holder[i] != "*" && holder[i + 1] != "*")
            {
                if (holder[i] != "-" && holder[i + 1] != "-")
                {
                    if (holder[i] != "/" && holder[i + 1] != "/")
                    {
                        tal = int.Parse(holder[i] + holder[i + 1]);
                        Console.WriteLine(tal);
                    }
                }
            }
        }

    }
    
}



//Lägg userinputs i en array
//gå igenom array och leta fram mellanslagen
//byt ut mellanslagen med indexet efter.
Console.ReadKey();