/**
 * Write a method to read two integer matrices from StdIn and print
 * their product matrix.
 */

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Matrix
{
  private String _name;
  private int _rows;
  private int _cols;
  private int[,] _matrix;

  // Create class constructor with parameter matrixName
  private Matrix(string matrixName)
  {
    _name = matrixName;
  }

  // Method to set a matrix from standard io
  void SetMatrix()
  {
    try
    {
      Console.WriteLine($"Matrix {this._name} rows: ");
      int rows = Convert.ToInt32(Console.ReadLine().Trim());
      Console.WriteLine($"Matrix {this._name} columns: ");
      int cols = Convert.ToInt32(Console.ReadLine().Trim());
      Console.WriteLine($"Space separated Matrix {this._name} entries (e.g. '1 2 3'): ");
      int[] matRaw = Console.ReadLine().Trim().Split(" ").ToArray().
        Select(arrTemp => Convert.ToInt32(arrTemp)).ToArray();
      int[,] mat = new int[rows, cols];
      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < cols; j++)
        {
          mat[i, j] = matRaw[i * cols + j];
        }
      }
      this._rows = rows;
      this._cols = cols;
      this._matrix = mat;
    }
    catch (Exception e)
    {
      Console.WriteLine("Caught an error. Please try again! " + e.Message);
      this.SetMatrix();
    }
  }
  static int[,] Multiply(Matrix matA, Matrix matB)
  {
    /**
    * Function multiplies two matrices given col_A == rows_B.
    *
    * Args:
    *     matA (matrix): Matrix A.
    *     matB (matrix): Matrix B.
    *
    * Raises:
    *     None.
    *
    * Returns:
    *     prodMat (matrix): Product of Matrix A and Matrix B.
    */

    int[,] prodMat = new int[matA._rows, matB._cols];
    for (int i = 0; i < matA._rows; i++)
    {
      for (int j = 0; j < matB._cols; j++)
      {
        int prodMatIJ = 0;
        for (int k = 0; k < matA._cols; k++)
        {
          prodMatIJ += matA._matrix[i, k] * matB._matrix[k, j];
        }
        prodMat[i, j] = prodMatIJ;
      }
    }
    return prodMat;
  }

  public static void Main(string[] args)
  {
    Matrix matA = new Matrix("A");
    matA.SetMatrix();
    Matrix matB = new Matrix("B");
    matB.SetMatrix();
    if (matA._cols == matB._rows)
    {
      int[,] prodMat = Multiply(matA, matB);
      Console.WriteLine("The product Matrix is: ");
      for (int i = 0; i < matA._rows; i++)
      {
        string row = "";
        for (int j = 0; j < matB._cols; j++)
        {
          row += prodMat[i, j].ToString() + " ";
        }
        Console.WriteLine("\t" + row);
      }
    }
    else
    {
      Console.WriteLine("Matrices can't be multiplied!");
    }
  }
}