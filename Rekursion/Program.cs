int factorial=(1*2*3*4*5*6*7*8*9*10*11*12*13*14*15*16*17*18);
int factorial(int n);
int factorial (int n) {
	if (n==0) {
		return 0;
} else if (n==1) {
	return 1;
} else {
	return int factorial(int n);
}
}

for (int n=0; n<18; n++) {
	Console.WriteLine(n+ ": "+factorial(n));
}