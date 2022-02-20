/**Write a method to read two matrices from StdIn and print
 * their product matrix.
 */  

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Matrix {
  public int[,] Multiply(
    int[,] matA, 
    int[,] matB, 
    int matARows, 
    int matACols, 
    int matBCols
    ) {
    int[,] prodMat = new int[matARows, matBCols];
    for (int i = 0; i < matARows; i++) {
      for (int j = 0; j < matBCols; j++) {
        int prodMatIJ = 0;
        for (int k = 0; k < matACols; k++) {
          prodMatIJ += matA[i, k] * matB[k, j];
        }
        prodMat[i, j] = prodMatIJ;
      }
    }
    return prodMat;
  }
  
  public static void Main(string[] args) {
    Console.WriteLine("Matrix A rows: ");
    int matARows = Convert.ToInt32(Console.ReadLine().Trim());
    Console.WriteLine("Matrix A columns: ");
    int matACols = Convert.ToInt32(Console.ReadLine().Trim());
    Console.WriteLine("Space separated Matrix A entries (e.g. '1 2 3'): ");
    int[] matARaw = Console.ReadLine().Trim().Split(" ").ToArray().
      Select(arrTemp => Convert.ToInt32(arrTemp)).ToArray();
    int[,] matA = new int[matARows, matACols];
    for (int i = 0; i < matARows; i++) {
      for (int j = 0; j < matACols; j++) {
        matA[i, j] = matARaw[i*matACols + j];
      }
    }
    Console.WriteLine("Matrix B rows: ");
    int matBRows = Convert.ToInt32(Console.ReadLine().Trim());
    Console.WriteLine("Matrix B columns: ");
    int matBCols = Convert.ToInt32(Console.ReadLine().Trim());
    Console.WriteLine("Space separated Matrix B entries (e.g. '4 5 6'): ");
    int[] matBRaw = Console.ReadLine().Trim().Split(" ").ToArray().
      Select(arrTemp => Convert.ToInt32(arrTemp)).ToArray();
    int[,] matB = new int[matBRows, matBCols];
    for (int i = 0; i < matBRows; i++) {
      for (int j = 0; j < matBCols; j++) {
        matB[i, j] = matBRaw[i*matBCols + j];
      }
    }
    Matrix obj = new Matrix();
    if (matACols == matBRows) {
      int[,] prodMat = obj.Multiply(matA, matB, matARows, matACols, matBCols);
      Console.WriteLine("The product Matrix is: ");
      for (int i = 0; i < matARows; i++) {
        string row = "";
        for (int j = 0; j < matBCols; j++) {
          row += prodMat[i, j].ToString() + " ";
        }
        Console.WriteLine(row);
      }
    } else {
      Console.WriteLine("Matrices can't be multiplied!");
    }
  }
}


