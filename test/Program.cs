// test af konsol
Console.WriteLine ("Hello World!");

int abe; //Declare 
abe = 2; // assigned
double kat;
kat = -2.0;
int abekat = -2;
String hund;
hund = "jeg ønsker at jeg kan finde ud af det her";

Console.WriteLine(abe);
Console.WriteLine(kat);
Console.WriteLine(abekat);
Console.WriteLine(hund);

int a; 
a = 1+2; //x burde blive 3
int b; 
b = 5+2*1; // y er 5
double c; 
c = 1/2.0; //z må derfor være 0,5

Console.WriteLine (a) ;
Console.WriteLine(b) ;
Console.WriteLine(c) ;

int x;
x = 2;
int y;
y = 5;
int z = (x+y) *3;

Console.WriteLine(z);

int konto; //variabler i udtryk
konto = -50;
int løn;
løn = 135;
konto = konto + løn; 

Console.WriteLine(konto);

int num; 
num = 29;
int num1;
num1 = 34;

int resultat;
resultat = (num - num1);
Console.WriteLine(resultat);

int penge;
penge = 7;
int lønkr;
lønkr = 1;
int nyløn;
int nyløn2;
nyløn = penge + lønkr;
nyløn2 = nyløn - 8; 

Console.WriteLine(nyløn + nyløn2 + "er der tilbage"); // + kan kombinere tal med string +""

int value;
value= 0;
value ++;
Console.WriteLine(value);

int value1;
value1 = 0;
Console.WriteLine(++value); //Pre - den tager først resultatet af 1 en og viser så resultatet med en ekstra

//BOOLEAN

int burger;
burger = 10;
int pris;
pris = 2;
bool råd = burger >= pris;

Console.WriteLine(råd);

int husPris;
husPris = 1000;
int forældre;
forældre = 30;
int lånIBank;
lånIBank = 720;
int samletbeløb;
samletbeløb = forældre + lånIBank;
bool kanKøbes;
kanKøbes = samletbeløb >= husPris;

Console.WriteLine ("kan huset købes?" + kanKøbes);


//Loops eller kontrolstrukturer. 
/*Udfør kun den her kode, hvis et udtryk er true. Hvis en kode er true, så udfør kpden. Hvis udtrykket ikke er korrekt så udfør ikke koden*/

int indtægt = 10000, udgift=7000;
if (indtægt > udgift)
	Console.WriteLine ("der er overskud!");

// {} skal på, hvis der er flere koder, som skal udføres

//else kan sættes på, hvis vores if statment ikke er sandt
int udbud;
udbud = 500;
if (udbud >0)
Console.WriteLine("Vi har overskud");
else
Console.WriteLine ("Åh nej, go work");	//Der bliver derfor udskrevet "vi har overskud" fordi 500 er større end 0

//ELSE IF.
/*så hvis udbud er i nul så er den ikke negativ, men vi har heller ikke flere penge, derfor har vi sat et ekstra
else if på. Det gør vi for at gøre den mere speicifik. else if sætningen laver en ny betingelse. Og i else if sætninger/statments kan kun én af sætningerne være true*/
int dice;
dice = 1;
if (dice >3) {
	if (dice ==7) 
		Console.WriteLine("DEAD");
	else
Console.WriteLine ("HIT");
}
		else if (dice==0){
	Console.WriteLine("HIDE");
		}
	else 
	Console.WriteLine("RUN");
//else fanger ALT i et if statment
//Nestede if-sætninger
/*Der kan laves en if-sætning (huset kan købes) så skriv kode. Else if, så specificere vi den med kode, og så kan der komme en ny kode. 
Og i den kan der så være er endnu et if-statment (hvis lånet>0) så skrives koden "Du må gerne låne alligevel" 
vi kan jo kun komme ind i else if sætningen, hvis det første if statment er false. og det næste else if, så er true, kommer vi ind i det treide if. */



/* Hvis der er flere muligheder og vi ikke gider burge else if/if nestede. SÅ kan det gøres på en anden måde.*/