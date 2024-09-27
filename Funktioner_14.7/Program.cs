Console.WriteLine(d(1, 2, 3));
Console.WriteLine(roots(1, 2, 3));

int dis(int a, int b, int c) //Laver funktionen, der indeholde de tre informationer, som den indgår i diskiminaten 
{
    return b * b - 4 * a * c; //Her står hvordan man regner diskimrinanten ud
}

double[] roots(int d, int e, int f)
{
    int cint = dis(d, e, f);
    if (cint == 0)
    {
        int positiv = (-b / +Math.Sqrt(cint)) / 2 * a);
            int negativ = (-b / -Math.Sqrt(cint)) / 2 * a);
            return (positiv, negativ); 
    }

    return ((-b / +-Math.Sqrt(cint)) / 2 * a);
}





