using System;

namespace Lab4CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Оберiть завдання : ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice) {
                case 1:
                    // Створення точки за допомогою конструктора без параметрів
                    Point point1 = new Point();
                    point1.Print();

                    // Створення точки за допомогою конструктора з параметрами
                    Point point2 = new Point(3, 4, 5);
                    point2.Print();

                    // Зміна координат точки
                    point2.Move(1, -1);
                    point2.Print();

                    // Визначення відстані від точки до початку координат
                    double distance = point2.DistanceToOrigin();
                    Console.WriteLine($"Відстань до початку координат: {distance}");

                    // Використання властивостей для отримання значень координат і кольору
                    Console.WriteLine($"Координата X: {point2.X}, Координата Y: {point2.Y}, Колір: {point2.Color}");

                    // Перегрузка оператора ++
                    ++point2;
                    point2.Print();

                    // Перегрузка оператора --
                    --point2;
                    point2.Print();

                    // Перевірка на рівність координат
                    Console.WriteLine(point2 ? "Координати рівні" : "Координати не рівні");

                    // Використання індексатора
                    Console.WriteLine($"Значення за індексом 0: {point2[0]}");

                    // Перевантаження явного перетворення в рядок
                    string pointString = (string)point2;
                    Console.WriteLine($"Point2 у вигляді рядка: {pointString}");

                    // Перевантаження явного перетворення з рядка в об'єкт Point
                    string pointStringInput = "7,8,9";
                    Point pointFromString = (Point)pointStringInput;
                    pointFromString.Print();

                    // Використання оператора +
                    Point point3 = new Point(1, 1, 1);
                    point3 = point3 + 2;
                    point3.Print();
                    break;
                case 2:
                    // Створення об'єктів класу VectorByte
                    VectorByte vector1 = new VectorByte(5);
                    VectorByte vector2 = new VectorByte(5, 10);
                    VectorByte vector3 = new VectorByte(5, 20);

                    // Приклад використання методів
                    vector1.Input();
                    Console.WriteLine("Vector 1:");
                    vector1.Output();

                    Console.WriteLine("\nVector 2:");
                    vector2.Output();

                    // Приклад використання операторів
                    VectorByte sum = vector1 + vector2;
                    Console.WriteLine("\nSum of Vector 1 and Vector 2:");
                    sum.Output();

                    VectorByte difference = vector2 - vector3;
                    Console.WriteLine("\nDifference of Vector 2 and Vector 3:");
                    difference.Output();

                    VectorByte product = vector1 * vector2;
                    Console.WriteLine("\nProduct of Vector 1 and Vector 2:");
                    product.Output();

                    VectorByte quotient = vector3 / vector2;
                    Console.WriteLine("\nQuotient of Vector 3 and Vector 2:");
                    quotient.Output();

                    VectorByte remainder = vector3 % vector2;
                    Console.WriteLine("\nRemainder of Vector 3 and Vector 2:");
                    remainder.Output();

                    if (vector1 == vector2)
                        Console.WriteLine("\nVector 1 and Vector 2 are equal.");
                    else
                        Console.WriteLine("\nVector 1 and Vector 2 are not equal.");

                    if (vector1 != vector2)
                        Console.WriteLine("Vector 1 and Vector 2 are not equal.");
                    else
                        Console.WriteLine("Vector 1 and Vector 2 are equal.");

                    if (vector1 > vector2)
                        Console.WriteLine("Vector 1 is greater than Vector 2.");
                    else
                        Console.WriteLine("Vector 1 is not greater than Vector 2.");

                    if (vector1 >= vector2)
                        Console.WriteLine("Vector 1 is greater than or equal to Vector 2.");
                    else
                        Console.WriteLine("Vector 1 is not greater than or equal to Vector 2.");

                    if (vector1 < vector2)
                        Console.WriteLine("Vector 1 is less than Vector 2.");
                    else
                        Console.WriteLine("Vector 1 is not less than Vector 2.");

                    if (vector1 <= vector2)
                        Console.WriteLine("Vector 1 is less than or equal to Vector 2.");
                    else
                        Console.WriteLine("Vector 1 is not less than or equal to Vector 2.");

                    // Побітові бінарні операції
                    VectorByte bitwiseOr = vector1 | vector2;
                    Console.WriteLine("\nBitwise OR of Vector 1 and Vector 2:");
                    bitwiseOr.Output();

                    VectorByte bitwiseXor = vector1 ^ vector2;
                    Console.WriteLine("\nBitwise XOR of Vector 1 and Vector 2:");
                    bitwiseXor.Output();

                    VectorByte bitwiseAnd = vector1 & vector2;
                    Console.WriteLine("\nBitwise AND of Vector 1 and Vector 2:");
                    bitwiseAnd.Output();

                    VectorByte rightShift = vector1 >> 2;
                    Console.WriteLine("\nRight Shift of Vector 1:");
                    rightShift.Output();

                    VectorByte leftShift = vector1 << 2;
                    Console.WriteLine("\nLeft Shift of Vector 1:");
                    leftShift.Output();
                    break;
                case 3:
                    // Створення матриць
                    MatrixByte matrix1 = new MatrixByte(3, 3);
                    MatrixByte matrix2 = new MatrixByte(3, 3, 5);

                    // Введення значень для першої матриці
                    Console.WriteLine("Enter values for matrix 1:");
                    matrix1.Input();

                    // Виведення першої матриці
                    Console.WriteLine("Matrix 1:");
                    matrix1.Output();

                    // Виведення другої матриці
                    Console.WriteLine("Matrix 2:");
                    matrix2.Output();

                    // Використання операторів
                    MatrixByte sum1 = matrix1 + matrix2;
                    MatrixByte difference1 = matrix1 - matrix2;
                    MatrixByte product1 = matrix1 * matrix2;
                    MatrixByte division = matrix1 / matrix2;
                    MatrixByte modulus = matrix1 % matrix2;
                    MatrixByte incrementedMatrix = ++matrix1;
                    MatrixByte decrementedMatrix = --matrix2;

                    // Виведення результатів операцій
                    Console.WriteLine("Sum of matrices:");
                    sum1.Output();

                    Console.WriteLine("Difference of matrices:");
                    difference1.Output();

                    Console.WriteLine("Product of matrices:");
                    product1.Output();

                    Console.WriteLine("Division of matrices:");
                    division.Output();

                    Console.WriteLine("Modulus of matrices:");
                    modulus.Output();

                    Console.WriteLine("Incremented matrix 1:");
                    incrementedMatrix.Output();

                    Console.WriteLine("Decremented matrix 2:");
                    decrementedMatrix.Output();

                    // Перевірка на рівність матриць
                    if (matrix1 == matrix2)
                    {
                        Console.WriteLine("Matrix 1 is equal to matrix 2.");
                    }
                    else
                    {
                        Console.WriteLine("Matrix 1 is not equal to matrix 2.");
                    }

                    // Перевірка на більше або менше
                    if (matrix1 > matrix2)
                    {
                        Console.WriteLine("Matrix 1 is greater than matrix 2.");
                    }
                    else if (matrix1 < matrix2)
                    {
                        Console.WriteLine("Matrix 1 is less than matrix 2.");
                    }
                    else
                    {
                        Console.WriteLine("Matrix 1 is equal to matrix 2.");
                    }
                    break;
                }

            }
            
    }
}
