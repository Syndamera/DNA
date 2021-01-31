using System;
using System.Collections.Generic;
using System.Linq;

// ### APP DESCRIPTION ###
// TASK #1: DONE
// The user input a DNA sequence (A,G,C,T = U) - only accepts these characters.
// Translate DNA sequence to Amino Acid - Match a sequence of 3 to corresponding Amino Acid
// Lookup: Amino Acid Table > ENUM
// Print out the correct single letter code
// This below is called reading frame. Only applies if we have a remainder from the DNA sequence.
// xxx xxx xx = start || x xxx xxx x = middle || xx xxx xxx = end
// Check the 3s in the sequence and print out from start 3's, middle 3's and from the end 3's.

// TASK #2:
// <extra> GC content >> % of bases that are either G or C from the input.
// Identify the start Codon and that determines the reading frame >> we will start the reading from this DNA code.
//    AAAGGGAUGCCAUGGAAAAUGUAAAAAGGGCCCUAAAUGCCCUAAUUUAA 
// 1:            <M><x><x><x><x><x><x><x><x><x><x><x><!> 
// 2: <skip><M><x><x><x><M><!>   <skip>                  
// 3: <skip>            <M><!>   <skip>                  
// 4:                                     <M><x><!><skip>
// Print out the correct amino acids
// >Sequence 1
// Mxxxxxxxxxxx
// >Sequence 2
// MxxxM
// >Sequence 3
// M
// >Sequence 4
// Mx

namespace DNA
{
    class Program
    {
        static void Main(string[] args)
        {
            // init and create all the amino acid objects
            List<AminoAcid> acids = new List<AminoAcid>();
            CreateAminoAcids(acids);

            Console.Write("Input DNA code: ");
            string inputConsole = Console.ReadLine().ToUpper();
            inputConsole = string.Concat(inputConsole.Where(c => !char.IsWhiteSpace(c)));
            string input = inputConsole.Replace("T", "U");

            char[] characters = new char[input.Length];
            characters = input.ToCharArray();
            ReadingFramesAndOutputSequence(acids, characters, input);
        }

        static void ReadingFramesAndOutputSequence(List<AminoAcid> acids, char[] characters, string input)
        {
            int remainder = characters.Length % 3;
            if (remainder != 0 && characters.Length > 2)
            {
                // Reading frames with different input
                // 8: (xxx xxx) xx - x (xxx xxx) x   - xx (xxx xxx)
                // 7: (xxx xxx) x  - x (xxx xxx)     - xx (xxx) xx
                if (remainder == 2 || remainder == 1)
                {
                    // 8: (xxx xxx) xx
                    // 7: (xxx xxx) x
                    // removes the two last characters - start frame for 7-8 characters
                    string start = string.Empty;
                    for (int i = 0; i < characters.Length - remainder; i++)
                    {
                        char c = characters[i];
                        start += c.ToString();
                    }
                    Console.Write("Sequence 1: ");
                    CompareData(acids, start.ToCharArray());
                    Console.WriteLine();
                    // 8: x (xxx xxx) x
                    // 7: x (xxx xxx)
                    // removes the first and the last character - middle frame for 7-8 characters
                    string middle = string.Empty;
                    for (int i = 1; i < characters.Length - (remainder - 1); i++)
                    {
                        char c = characters[i];
                        middle += c.ToString();
                    }
                    Console.Write("Sequence 2: ");
                    CompareData(acids, middle.ToCharArray());
                    Console.WriteLine();

                    int temp = 0;
                    if (remainder == 1)
                    {
                        temp = 2;
                    }
                    // 8: xx (xxx xxx)
                    // 7: xx (xxx) xx - uses temp variable
                    // removes the two first characters and removes the 2 last for 7 characters - end frame
                    string end = string.Empty;
                    for (int i = 2; i < characters.Length - temp; i++)
                    {
                        char c = characters[i];
                        end += c.ToString();
                    }
                    Console.Write("Sequence 3: ");
                    CompareData(acids, end.ToCharArray());
                    Console.WriteLine();
                }
            }
            else
            {
                // 6: (xxx xxx)    - x (xxx) xx      - xx (xxx) x >> should be 3 different readins from x^3
                // Display all the readings as single line, single letter code.
                // first reading frame (xxx xxx)
                if (characters.Length > 2)
                {
                    Console.Write("Sequence 1: ");
                    CompareData(acids, characters);
                    Console.WriteLine();

                    // second reading frame x (xxx) xx
                    string second = string.Empty;
                    for (int i = 1; i < characters.Length - 2; i++)
                    {
                        char c = characters[i];
                        second += c.ToString();
                    }
                    Console.Write("Sequence 2: ");
                    CompareData(acids, second.ToCharArray());
                    Console.WriteLine();

                    // third reading frame xx (xxx) x
                    string third = string.Empty;
                    for (int i = 2; i < characters.Length - 1; i++)
                    {
                        char c = characters[i];
                        third += c.ToString();
                    }
                    Console.Write("Sequence 3: ");
                    CompareData(acids, third.ToCharArray());
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("ERROR: Your input was only {0:D} character and you need a minimum of 3 characters", characters.Length);
                }
            }
        }

        static void CompareData(List<AminoAcid> acids, char[] characters)
        {
            // this only works on x^3
            // compares 3 characters at a time against a Codon.
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

        static void CompareDnaWithAminoAcids(List<AminoAcid> acids, string str)
        {
            // check for one of the stop codons
            if (str == Data.Codon.UAA.ToString() ||
                str == Data.Codon.UAG.ToString() ||
                str == Data.Codon.UGA.ToString())
            {
                Console.WriteLine("Stop Codon with " + str);
            }
            else
            {
                foreach (var acid in acids)
                {
                    foreach (var codon in acid.Codon)
                    {
                        if (str == codon.ToString())
                        {
                            //Console.WriteLine("FOUND A MATCH: " + input + " " + acid.Name + " " + acid.SingleLetterCode);
                            // TODO: Save the result and return the SingleLetterCode?
                            Console.Write(acid.SingleLetterCode);
                            if (acid.StartCodon)
                            {
                                //Console.WriteLine("Start Codon");
                            }
                            // prints all the info of the matched amino acid
                            //acid.PrintAminoAcidInfo();
                        }
                    }
                }
            }
        }
    }
}
