using System;
using System.Collections.Generic;

namespace m0201
{
    public class InputTrimmer
    {
        private List<char> Chars { get; set; }

        public InputTrimmer()
        {
            this.Chars = new List<char>();
        }

        public void Add(string line)
        {
            this.Chars.Add(line[0]);
        }

        public void Print()
        {
            foreach (var c in this.Chars)
            {
                Console.WriteLine(c);
            }
        }
    }
}
