using System;
using System.Collections.Generic;

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
        class AminoAcid
        {
            public string Name;
            public Codon Base;
            public AminoAcidCode Code;


            public void PrintInfo(AminoAcid a)
            {
                Console.WriteLine("Codon: " + a.Base);
                Console.WriteLine("Name: " + a.Name);
                Console.WriteLine("Code: " + a.Code);
            }

            public void GetAminoAcidInfo(Codon b)
            {
                switch(b)
                {
                    case Codon.UUU:
                        {
                            Name = "Phenylalanine";
                            Base = Codon.UUU;
                            Code = AminoAcidCode.F;
                        } break;
                    case Codon.UUC:
                        {
                            Name = "Phenylalanine";
                            Base = Codon.UUC;
                            Code = AminoAcidCode.F;
                        }
                        break;
                    case Codon.UUA:
                        {
                            Name = "Leucine";
                            Base = Codon.UUA;
                            Code = AminoAcidCode.L;
                        }
                        break;
                    case Codon.UUG:
                        {
                            Name = "Leucine";
                            Base = Codon.UUG;
                            Code = AminoAcidCode.L;
                        }
                        break;

                } 
            }
        }
        enum Codon
        {
            UUU,
            UUC,
            UUA,
            UUG
        }
        enum AminoAcidCode
        {
            F,
            L,
            I,
            V,
            S,
            P,
            T,
            A,
            Y,
            Stop,
            H,
            Q,
            N,
            K,
            D,
            E,
            C,
            W,
            R,
            G
        }

        static void Main(string[] args)
        {
            List<string> aminoAcids = new List<string>();

            for (int i = 0; i < aminoAcids.Count; i++)
            {

            }

            AminoAcid a = new AminoAcid();
            a.GetAminoAcidInfo(Codon.UUU);
            AminoAcid b = new AminoAcid();
            b.GetAminoAcidInfo(Codon.UUG);
            a.PrintInfo(a);
            b.PrintInfo(b);
        }

    }
}
