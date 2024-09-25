int iterationer = 10;
int [] array = {1,2,3,4,5};

//increment
try{
for (int i=0; i < iterationer ; i++)
{
	Console.WriteLine(array[i]);
	array[i]++;
}
}
catch {
	Console.WriteLine ("Du har oversteget maksimum prøv igen");
	for (int i=0; i < 5 ; i++)
	{
	array[i]++;
	Console.WriteLine(array[i]);
	}
}
//print
for (int i=0; i<array.Length ; i++)
{
	Console.WriteLine(array[i]);
}

