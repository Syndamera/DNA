using System;
using System.Collections.Generic;

// ### APP DESCRIPTION ###
// The user input a DNA sequence (A,G,C,T = U) - only accepts these characters.
// Translate DNA sequence to Amino Acid - Match a sequence of 3 to corresponding Amino Acid
// Lookup: Amino Acid Table > ENUM
// Print out the correct one letter code
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
            string a = Data.Codon.AAG.ToString();
            Console.WriteLine("DEMO DATA STRING: " + a + " ENUM: " + (int)Data.Codon.UUU + "\n");
            acids[1].PrintAminoAcidInfo();

            // collect and print data from all the acid objects
            foreach(var acid in acids)
            {
                foreach(var codon in acid.Codon)
                {
                    Console.WriteLine(acid.Name + " " + codon + " " + acid.SingleLetterCode);
                }
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
    }
}
