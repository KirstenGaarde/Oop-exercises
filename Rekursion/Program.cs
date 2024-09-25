//Fakultet af N 
/*skal have en basecase, så funktionen ved hvornår den skal stoppe så den ikke kører til stackoverflow
 det diffineres med en If (==)*/
long fakultet (long n) { 
	if (n==1)
		return n;
	return n * fakultet(n-1); 
};
Console.WriteLine ("Fakultet er =" + fakultet (18));


//Cirkler i Tal 14.9 
// areal

double pi;
pi = 3.147;
double aeral (int a) {
	if (a==0)
		return a;
	return pi * Math.Pow(a,2.0); //Pow er en funktioner, der opløfter a i anden, havde der stået a, 3 var det i trejide 
}
Console.WriteLine("Arealet er =" + aeral(3));

//Omkreds
double omkreds (int a) {
	if (a==0)
		return a; 
	return pi * 2 * a;
}
Console.WriteLine ("Omkredsen er =" + omkreds(3));

//Egen kvadaret rod
double 