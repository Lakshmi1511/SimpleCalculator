using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class SimpleCalculator
    {
        Operator[] operators = new Operator[]
            {
              new Operator('+',(left,right)=>{return left+right; }),
              new Operator('-',(left,right)=>{return left-right; }),
              new Operator('*',(left,right)=>{return left*right; }),
              new Operator('/',(left,right)=>{return left/right; })
            };

        class Operator
        {
            public char Symbol;
            public Func<int, int, int>Function;
            public Operator(char symbol, Func<int, int, int> function)
            {
                Symbol = symbol;
                Function = function;
            }
        }

        public int Calculate(string input)
        {
            foreach (var op in operators)
            {
                if (input.Contains(op.Symbol))
                {
                    string[] parts = input.Split(new char[] { op.Symbol },StringSplitOptions.RemoveEmptyEntries);
                    int left = Convert.ToInt32(parts[0]);
                    int right = Convert.ToInt32(parts[1]);
                    return op.Function(left, right);
                    
                }
                
            }
            throw new InvalidOperationException();
        }

    }
}