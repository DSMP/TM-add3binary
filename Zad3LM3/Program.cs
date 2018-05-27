using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Zad3LM3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj ciąg bitów: ");
            string maybeBinaryNumber = Console.ReadLine();
            //if (!maybeBinaryNumber.ToCharArray().ToList().Exists(x => x.Equals("0") || x.Equals("1") || x.Equals("-")))
            //{
            //    return;
            //}

            List<char> tape = maybeBinaryNumber.Reverse().ToList();
            if (!tape[0].Equals("O"))
            {                
                tape.Add('O');
            }
            State state = new StateTable().GetInitialState();
            StringBuilder sbTape = new StringBuilder();
            StringBuilder sbMoved = new StringBuilder();
            StringBuilder sbStates = new StringBuilder();
            sbStates.Append(state.Name);
            Console.WriteLine("pozycja glowicy: " + sbMoved + " stan tasmy: " + "O" + maybeBinaryNumber + " aktualny stan: " + state.Name);
            for (int i = 0; i < tape.Count; i++)
            {
                string value = tape[i].ToString();
                tape[i] = state.Write(value).ToString().ToCharArray()[0];
                for (int j = tape.Count-1; j >= 0; j--) // zapis tasmy w konkretnym kroku
                {
                    sbTape.Append(tape[j]);
                }
                sbMoved.Append(state.Move(value));
                state = state.NextState(value);
                Console.WriteLine("pozycja glowicy: " + sbMoved + " stan tasmy: " + sbTape + " aktualny stan: " + state.Name);
                sbTape.Clear();
                sbStates.Append(" -> " + state.Name);

            }
            Console.WriteLine(sbStates);

        }
    }
}
