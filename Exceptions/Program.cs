int iterationer = 10; 
int [] array = {1,2,3,4,5};

//increment 
/* Det er fordi der står iterationer i vores paraentes, der gør at det bliver til en exception. Havde der stået array.Length, havde vi ikke fået en fejl og der
havde ikke været en expecition som skal try og derefte catch*/
for (int i=0; i < iterationer ; i++) { //Exception. Som bliver kastet 
try{
	Console.WriteLine(array[i]);
	array[i]++;
}
catch{ //Her bliver den grebet, og koden/programmet kører videre
	Console.WriteLine ("Du har oversteget maksimum prøv igen");
}
}
//print
for (int i=0; i<array.Length ; i++)
{
	Console.WriteLine(array[i]);
}

