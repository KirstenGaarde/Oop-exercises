﻿
int plus(int a, int b)
{
	return a + b;
}
Console.WriteLine (plus (1,4));

//suduko 

int[][] puzzle = new int[][] {
new int[]{7, 3, 6, 4, 5, 2, 9, 8, 1},
new int[]{1, 9, 8, 6, 3, 7, 4, 5, 2},
new int[]{4, 2, 5, 9, 8, 1, 3, 7, 6},
new int[]{3, 6, 4, 5, 2, 8, 1, 9, 7},
new int[]{9, 5, 2, 7, 1, 4, 6, 3, 8},
new int[]{8, 1, 7, 3, 0, 6, 2, 4, 5},
new int[]{2, 8, 9, 1, 7, 3, 5, 6, 4},
new int[]{6, 7, 3, 2, 4, 5, 8, 1, 9},
new int[]{5, 4, 1, 8, 6, 9, 7, 2, 3},
};


void suduko (int[][] p) 
{           
	for (int row = 0; row < p.Length; row++) {
		for (int col = 0; col < p[row].Length; col++) {
			Console.Write(" " + p[row][col]);
		}
		Console.WriteLine("");
	} 
	
}

suduko(puzzle);

//Test