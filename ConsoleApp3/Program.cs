﻿namespace ConsoleApp3;

/*
    Имеется строка s на входе. Разделение этой строки на 2 непустые подстроки p и q называется хорошим тогда и только тогда,
    когда конкатенация этих строк дает строку s и количество различных элементов в подстроке p равно количеству различных в q.
    Напишите метод, принимающий строку s, который подсчитывает количество "хороших" разделений строки s.

    Например: aacaba
    1. a - acaba (1 - 3)
    2. aa - caba (1 - 3)
    3. aac - aba (2 - 2) хорошее
    4. aaca - ba (2 - 2) хорошее
    5. aacab - a (3 - 1)

    Итого 2 хороших разбиения
 */
class Program
{
    static void Main(string[] args)
    {
        var a = "aacaba";

        Console.WriteLine(Solver.Solve(a));
    }
}