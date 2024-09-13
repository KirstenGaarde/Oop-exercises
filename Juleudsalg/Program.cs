int i=21816000;
double pris=599.95;
bool jul;
int Spm =60*60*24*30;
jul =(i>=Spm*11) && (i<Spm*12);  
Console.WriteLine("pris");
if (jul){
	double reduceretpris=600.0*0.7;
	Console.WriteLine (reduceretpris);
	}
Console.WriteLine(pris);