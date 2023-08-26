using System;

class Program {
  public static void Main (string[] args) {
    //It asks you to enter the 3 grades of the student
   Console.Write("What is the student's grade 1 ? ");
   double noteOne = Convert.ToDouble(Console.ReadLine());

  Console.Write("What is the student's grade 2 ? ");
  double noteTwo = Convert.ToDouble(Console.ReadLine());

  Console.Write("What is the student's grade 3 ? ");
  double noteThree = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the average of the exercises");
  double averageExercises = Convert.ToDouble(Console.ReadLine());

    double averagePerformance = (noteOne + noteTwo * 2 + noteThree * 3 + averageExercises) / 7;

    string concept;
    if (averageExercises >= 9.0)
      concept = "A";
    else if (averageExercises >= 7.5 && averageExercises < 9.0)
    concept = "B";
    else if (averageExercises >= 6.0 && averageExercises < 7.5)
    concept = "C";
    else
    concept = "D";

    Console.WriteLine($"Grade point average:{averageExercises:F2}");
    Console.WriteLine($"Concept: {concept}");
    
    }
  }