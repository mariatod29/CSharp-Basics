using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

class SquareMatrix
{
    public static void Main()
    {
        string matrixInput = @"MatrixInput.txt";
        string matrixOutput = @"MatrixOutput.txt";
        double[,] matrix;
        double result;
        try
        {
            matrix = ReadToArray(matrixInput);
            result = MaxArea(matrix);
            ExportIntoOutputFile(matrixOutput, result);
        }
        catch (Exception ex)
        {
            if (ex is NullReferenceException) Console.WriteLine("The matrix is not correctly filled due to an error.");
            else throw;
        }
    }

    private static double[,] ReadToArray(string matrixInput)
    {
        try
        {
            double[,] matrix;
            StreamReader reader = new StreamReader(matrixInput, Encoding.GetEncoding("UTF-8"));

            using (reader)
            {
                int sizeOfMatrix = int.Parse(reader.ReadLine());
                matrix = new double[sizeOfMatrix, sizeOfMatrix];
                for (int row = 0; row <= sizeOfMatrix - 1; row++)
                {
                    string line = reader.ReadLine();
                    string[] lineArr = line.Split();

                    for (int col = 0; col < sizeOfMatrix; col++)
                    {
                        matrix[row, col] = double.Parse(lineArr[col]);
                    }
                }
            }
            return matrix;
        }
        catch (Exception ex)
        {
            Console.WriteLine("The matrix can not be returned correctly: " + ex.Message);
            return null;
        }
    }

    static double MaxArea(double[,] matrix)
    {
        double max = 0;
        double temp = 0;
        try
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    temp = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (temp > max) max = temp;
                }
            }
        }
        catch (Exception ex)
        {
            if (ex is IndexOutOfRangeException)
            {
                Console.WriteLine("An error has occured during looping: " + ex.Message);
            }
            else throw;
        }
        return max;
    }

    static void ExportIntoOutputFile<T>(string path, T result)
    {
        StreamWriter writer;
        try
        {
            writer = new StreamWriter(@"OutputMatrix.txt", false, Encoding.GetEncoding("UTF-8"));
            using (writer)
            {
                writer.WriteLine(result);
            }
            Console.WriteLine("Press \"Y\" to see the result: ");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                Process.Start(@"OutputMatrix.txt");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error has occured: " + ex.Message);
        }
    }
}