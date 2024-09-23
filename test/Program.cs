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