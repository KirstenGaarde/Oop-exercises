﻿int iterationer = 10;
int [] array = {1,2,3,4,5};

//increment
for (int i=0; i < iterationer ; i++) {
try{
	Console.WriteLine(array[i]);
	array[i]++;
}
catch{
	Console.WriteLine ("Du har oversteget maksimum prøv igen");
}
}
//print
for (int i=0; i<array.Length ; i++)
{
	Console.WriteLine(array[i]);
}

