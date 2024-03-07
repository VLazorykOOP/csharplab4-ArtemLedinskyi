using System;

namespace Lab4CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення об'єкта вектора без параметрів
            VectorByte vector1 = new VectorByte();
            vector1.Input(); // Введення елементів вектора з клавіатури
            vector1.Output(); // Виведення елементів вектора на екран

            // Створення об'єкта вектора з заданим розміром та початковим значенням
            VectorByte vector2 = new VectorByte(5, 10); // Розмір - 5, Початкове значення - 10
            vector2.Output();

            // Приклади перегрузки операторів
            VectorByte vector3 = vector1 + vector2; // Додавання двох векторів
            vector3.Output();

            VectorByte vector4 = vector1 + 5; // Додавання скаляру до вектора
            vector4.Output();

            VectorByte vector5 = vector1 - vector2; // Віднімання двох векторів
            vector5.Output();

            VectorByte vector6 = vector1 - 5; // Віднімання скаляру від вектора
            vector6.Output();

            VectorByte vector7 = vector1 * vector2; // Множення двох векторів
            vector7.Output();

            VectorByte vector8 = vector1 * 5; // Множення вектора на скаляр
            vector8.Output();

            VectorByte vector9 = vector1 / vector2; // Ділення одного вектора на інший
            vector9.Output();

            VectorByte vector10 = vector1 / 5; // Ділення вектора на скаляр
            vector10.Output();

            VectorByte vector11 = vector1 % vector2; // Остача від ділення одного вектора на інший
            vector11.Output();

            VectorByte vector12 = vector1 % 5; // Остача від ділення вектора на скаляр
            vector12.Output();

            VectorByte vector13 = vector1 | vector2; // Побітове додавання двох векторів
            vector13.Output();

            VectorByte vector14 = vector1 | 5; // Побітове додавання скаляру до вектора
            vector14.Output();

            VectorByte vector15 = vector1 ^ vector2; // Побітове XOR двох векторів
            vector15.Output();

            VectorByte vector16 = vector1 ^ 5; // Побітове XOR вектора та скаляру
            vector16.Output();

            VectorByte vector17 = vector1 & vector2; // Побітове AND двох векторів
            vector17.Output();

            VectorByte vector18 = vector1 & 5; // Побітове AND вектора та скаляру
            vector18.Output();

            VectorByte vector19 = vector1 >> 2; // Побітовий зсув вправо на 2 позиції
            vector19.Output();

            VectorByte vector20 = vector1 >> vector2; // Побітовий зсув вправо відносно другого вектора
            vector20.Output();

            VectorByte vector21 = vector1 << 2; // Побітовий зсув вліво на 2 позиції
            vector21.Output();

            VectorByte vector22 = vector1 << vector2; // Побітовий зсув вліво відносно другого вектора
            vector22.Output();

            // Перевірка умов порівняння
            if (vector1 == vector2)
                Console.WriteLine("Вектори рівні");
            else
                Console.WriteLine("Вектори не рівні");

            if (vector1 > vector2)
                Console.WriteLine("Перший вектор більший за другий");
            else
                Console.WriteLine("Перший вектор не більший за другий");

            if (vector1 >= vector2)
                Console.WriteLine("Перший вектор більший або рівний другому");
            else
                Console.WriteLine("Перший вектор не більший або рівний другому");

            if (vector1 < vector2)
                Console.WriteLine("Перший вектор менший за другий");
            else
                Console.WriteLine("Перший вектор не менший за другий");

            if (vector1 <= vector2)
                Console.WriteLine("Перший вектор менший або рівний другому");
            else
                Console.WriteLine("Перший вектор не менший або рівний другому");

            // Зупинка консолі до натискання клавіші
            Console.ReadKey();
        }
    }
}
