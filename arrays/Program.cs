//Array temeperatur for loop

double [] temperatur = {21.5,23.7,19.6,22.5,25.3,21.8,18.9};

//arry loop
for (int d=0; d<temperatur.Length-1; d ++)
{
	Console.WriteLine (temperatur [d+1]- temperatur[d]);
}