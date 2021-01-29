using System;
using System.Collections.Generic;
using System.Linq;

// ### APP DESCRIPTION ###
// The user input a DNA sequence (A,G,C,T = U) - only accepts these characters.
// Translate DNA sequence to Amino Acid - Match a sequence of 3 to corresponding Amino Acid
// Lookup: Amino Acid Table > ENUM
// Print out the correct single letter code
// This below is called reading frame. Only applies if we have a remainder from the DNA sequence.
// xxx xxx xx = start || x xxx xxx x = middle || xx xxx xxx = end
// Check the 3s in the sequence and print out from start 3's, middle 3's and from the end 3's.

namespace DNA
{
    class Program
    {
        static void Main(string[] args)
        {
            // init and create all the amino acid objects
            List<AminoAcid> acids = new List<AminoAcid>();
            CreateAminoAcids(acids);

            // convert enum into a string
            //string a = Data.Codon.AAG.ToString();
            //Console.WriteLine("DEMO DATA STRING: " + a + " ENUM: " + (int)Data.Codon.AAG + "\n");

            // prints out all the info for one amino acid
            //acids[1].PrintAminoAcidInfo();

            // testing comparing strings
            //string input = "AUG";
            //CompareDnaWithAminoAcids(acids, input);

            // TODO: input % 3 and if remainder call a function to handle reading frames.
            // if no remainder, remove whitespace in the string and copy each 3 chars
            // into a new string and call CompareDnaWithAminoAcids()
            // loop the call until all the new strings are completed.
            //string input = "AUGCCCAUGAUAGCCUAA";
            Console.Write("Input DNA code: ");
            string inputConsole = Console.ReadLine().ToUpper();
            inputConsole = string.Concat(inputConsole.Where(c => !char.IsWhiteSpace(c)));
            string input = inputConsole.Replace("T", "U");

            char[] characters = new char[input.Length];
            characters = input.ToCharArray();

            int remainder = characters.Length % 3;
            if (remainder != 0)
            {
                // TODO: shift chars left and keep all but the remainders.
                // then shift right and keep all but the remainders.
                // lastly remove either the first or the last or both first & last chars.
                if(remainder == 2 || remainder == 1)
                {
                    // removes the two last characters - start frame
                    string start = string.Empty;
                    for (int i = 0; i < characters.Length - remainder; i++)
                    {
                        char c = characters[i];
                        start += c.ToString();
                    }
                    Console.WriteLine("START FRAME:" + start);
                    CompareData(acids, start.ToCharArray());

                    // removes the first and the last character - middle frame
                    // 8: (xxx xxx) xx - x (xxx xxx) x   - xx (xxx xxx)
                    // 7: (xxx xxx) x  - x (xxx xxx)     - xx (xxx) xx
                    // 6: (xxx xxx)    - x (xxx) xx      - xx (xxx) x
                    string middle = string.Empty;
                    for (int i = 1; i < characters.Length - (remainder - 1); i++)
                    {
                        char c = characters[i];
                        middle += c.ToString();
                    }
                    Console.WriteLine("MIDDLE FRAME: " + middle);
                    CompareData(acids, middle.ToCharArray());

                    // removes the two last characters - end frame
                    int temp = 0;
                    if(remainder == 1)
                    {
                        temp = 2;
                    }
                    string end = string.Empty;
                    for (int i = 2; i < characters.Length - temp; i++)
                    {
                        char c = characters[i];
                        end += c.ToString();
                    }
                    Console.WriteLine("END FRAME: " + end);
                    CompareData(acids, end.ToCharArray());
                }
            }
            else
            {
                CompareData(acids, characters);
            }

            // collect and print data from all the acid objects
            //PrintAllAminoAcids(acids);
        }

        static void CompareData(List<AminoAcid> acids, char[] characters)
        {
            // this only works on x^3
            int arrayPos = 0;
            string str = string.Empty;
            while (arrayPos < characters.Length)
            {
                for (int i = 0; i < 3; i++)
                {
                    char c = characters[i + arrayPos];
                    str += c.ToString();
                }
                CompareDnaWithAminoAcids(acids, str);
                str = string.Empty;
                arrayPos += 3;
            }
        }

        static void CreateAminoAcids(List<AminoAcid> acids)
        {
            for (int i = 0; i < 20; i++)
            {
                AminoAcid acid = new AminoAcid();
                acid.InitAminoAcidInfo((AminoAcid.AminoAcidCode)i);
                acids.Add(acid);
            }
        }

        static void PrintAllAminoAcids(List<AminoAcid> acids)
        {
            foreach (var acid in acids)
            {
                foreach (var codon in acid.Codon)
                {
                    Console.WriteLine(acid.Name + " " + codon + " " + acid.SingleLetterCode);
                }
            }
        }

        static void CompareDnaWithAminoAcids(List<AminoAcid> acids, string input)
        {
            // check for one of the stop codons
            if (input == Data.Codon.UAA.ToString() ||
                input == Data.Codon.UAG.ToString() ||
                input == Data.Codon.UGA.ToString())
            {
                Console.WriteLine("Stop Codon with " + input);
            }
            else
            {
                foreach (var acid in acids)
                {
                    foreach (var codon in acid.Codon)
                    {
                        if (input == codon.ToString())
                        {
                            Console.WriteLine("FOUND A MATCH: " + input + " " + acid.Name + " " + acid.SingleLetterCode);
                            if (acid.StartCodon)
                            {
                                Console.WriteLine("Start Codon");
                            }

                            // prints all the info of the matched amino acid
                            acid.PrintAminoAcidInfo();
                        }
                    }
                }
            }
        }
    }
}
