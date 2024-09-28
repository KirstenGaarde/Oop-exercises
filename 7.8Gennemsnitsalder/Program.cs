//Age of different people as a varibel
int ada =36;
int dennis = 70;
int Grace = 85;
int hedy = 85;
int Edger = 72;
int douglas = 88;

//Calulation of the male and female avergede, and the differens between female and male years
float male_avg = (float)(dennis+Edger+douglas)/3;
float female_avg =(float)(ada+Grace+hedy)/3;
float avg = (male_avg+female_avg)/2;
float diff = male_avg-female_avg;

// Write to user the avgede years in female and male
Console.WriteLine (male_avg);
Console.WriteLine (female_avg);
Console.WriteLine (avg);
Console.WriteLine (diff);

/*1. del af koden. Der er 6 mennesker som har en alder. Deres alder er sat i koden som fastevædier.
 2. del af koden, bliver mændens gennemsnits alder udregnet, vedhjælp af varibalen float. Det samme gælder kvindernes
 gennemsnits alder.
 Der er i samme del af koden, udregnet det generelle gennemsnit, af både mænd og kvinder. og man har også beregnet 
 differencen på mønd og kvinders gennemsnitsalder.
 I 3 og sidste del af koden, skrivers der ud til brugeren svarene på mændensgennemsitsalder, kvindernes, differencen og 
 det generelle gennemsnit*/
