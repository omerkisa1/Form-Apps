using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

class MathEvaluator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter mathematical operation:");
        string input = Console.ReadLine();
        string postfix = InfixToPostfix(input);
        Console.WriteLine($"Postfix : {postfix}");
        EvaluatePostfix(postfix);
    }

    //  priority 
    private static readonly Dictionary<char, int> Precedence = new Dictionary<char, int>
    {
        { '^', 4 }, { '*', 3 }, { '/', 3 }, { '+', 2 }, { '-', 2 }
    };

    // convert infix to postfix
    public static string InfixToPostfix(string infix)
    {
        Stack<char> operators = new Stack<char>();
        List<string> postfix = new List<string>();

        foreach (char token in infix)
        {
            if (char.IsDigit(token))
            {
                postfix.Add(token.ToString());
            }
            else if (token == '(')
            {
                operators.Push(token);
            }
            else if (token == ')')
            {
                while (operators.Peek() != '(')
                    postfix.Add(operators.Pop().ToString());
                operators.Pop();
            }
            else if ("^*/+-".Contains(token))
            {
                while (operators.Count > 0 && operators.Peek() != '(' && Precedence[operators.Peek()] >= Precedence[token])
                    postfix.Add(operators.Pop().ToString());
                operators.Push(token);
            }
        }

        while (operators.Count > 0)
            postfix.Add(operators.Pop().ToString());

        return string.Join(" ", postfix);
    }

    // fix the postfix
    public static void EvaluatePostfix(string postfix)
    {
        Stack<double> values = new Stack<double>();
        string[] tokens = postfix.Split(' ');

        Console.WriteLine("Solution Steps:");

        foreach (string token in tokens)
        {
            if (double.TryParse(token, out double number))
            {
                values.Push(number);
            }
            else
            {
                double operand2 = values.Pop();
                double operand1 = values.Pop();
                double result;
                switch (token)
                {
                    case "+":
                        result = operand1 + operand2;
                        break;
                    case "-":
                        result = operand1 - operand2;
                        break;
                    case "*":
                        result = operand1 * operand2;
                        break;
                    case "/":
                        result = operand1 / operand2;
                        break;
                    case "^":
                        result = Math.Pow(operand1, operand2);
                        break;
                    default:
                        throw new InvalidOperationException("Geçersiz işlem");
                }


                Console.WriteLine($"{operand1} {token} {operand2} = {result}");
            values.Push(result);
        }
    }

        Console.WriteLine($"Sonuç: {values.Pop()}");
        Console.ReadKey();
    }
}
