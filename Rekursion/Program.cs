//Fakultet af N 
/*skal have en basecase, så funktionen ved hvornår den skal stoppe så den ikke kører til stackoverflow
 det diffineres med en If (==)*/
long fakultet (long n) { 
	if (n==1)
		return n;
	return n * fakultet(n-1); 
};
Console.WriteLine ("Fakultet er =" + fakultet (18));