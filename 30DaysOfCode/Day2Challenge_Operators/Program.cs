using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    static void Main(string[] args)
    {
        double mealCost = double.Parse(Console.ReadLine());
        int tipPercent = Int32.Parse(Console.ReadLine());
        int taxPercent = Int32.Parse(Console.ReadLine());

        double tip = mealCost * tipPercent / 100;
        double tax = mealCost * taxPercent / 100;

        double totalCost = mealCost + tip + tax;

        Console.WriteLine(Math.Round(totalCost));
        Console.ReadKey();
    }
}

