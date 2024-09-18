int[] months;
months = [1,2,12];
int arrayLength = months.Length;
Console.WriteLine(arrayLength); 
for (int i=0; i<months.Length; i++) 
{
	Console.WriteLine("Months" + (i+1)+" has "+months[i]+" days");
}
