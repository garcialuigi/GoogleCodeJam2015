using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleCodeJam2015
{
    public abstract class Problem
    {
        protected string[] inputLines;
        protected int iLine;
        protected StringBuilder outputText;

        public abstract bool StandardExecution
        {
            get;
        }

        public abstract bool RealMode
        {
            get;
        }

        public void Execute() {
            if (StandardExecution)
            {
                PreExecution();
                Start();
                PostExecution();
            }
            else
                Start();
        }

        public void PreExecution() {
            if (RealMode) { 
                inputLines = File.ReadAllText("input.in").Split('\n');
                iLine = 0;
                outputText = new StringBuilder();
            }
        }

        public abstract void Start();

        public void PostExecution() {
            Console.WriteLine(outputText.ToString());
            if (RealMode)
            {
                File.WriteAllText("output.in", outputText.ToString());
            }
        }

        public void Print(string value) {
            if (RealMode)
                outputText.Append(value);
            else
                Console.WriteLine(value);
        }

        public T RequestInput<T>() {
            string input = "";

            if(RealMode)
                input = inputLines[iLine++];
            else
                input = Console.ReadLine();
            
            if(typeof(T) == typeof(string))
                return (T)(object)input;
            return (T)Convert.ChangeType(input, typeof(T));            
        }
    }
}
