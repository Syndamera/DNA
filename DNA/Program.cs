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
            // create all the aminoacids and populate them in a array
            AminoAcid[] acids = new AminoAcid[20];

            for (int i = 0; i < 20; i++)
            {
                int codonValue = i;
                acids[i] = new AminoAcid();
                acids[i].GetAminoAcidInfo((Data.Codon)codonValue);
                Console.WriteLine(i + ": " + acids[i].Code);
            }
        }
    }
}
