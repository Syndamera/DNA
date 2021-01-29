using System;

// ### APP DESCRIPTION ###
// The user input a DNA sequence (A,G,C,T) - only accepts these characters.
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
        struct AminoAcid
        {
            AminoAcidTable ID;
            string code;
        }
        enum AminoAcidTable
        {
            UUU,
            UUC,
            UUA,
            UUG
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
