using System;
using System.Collections.Generic;
using System.Text;

namespace DNA
{
    class AminoAcid
    {
        public string Name;
        public Data.Codon Codon;
        public AminoAcidCode Code;

        public AminoAcid()
        {

        }

        public void PrintInfo(AminoAcid a)
        {
            Console.WriteLine("Codon: " + a.Codon);
            Console.WriteLine("Name: " + a.Name);
            Console.WriteLine("Code: " + a.Code);
        }

        public void GetAminoAcidInfo(Data.Codon b)
        {
            switch (b)
            {
                case Data.Codon.UUU:
                    {
                        Name = "Phenylalanine";
                        Codon = Data.Codon.UUU;
                        Code = AminoAcidCode.F;
                    }
                    break;
                case Data.Codon.UUC:
                    {
                        Name = "Phenylalanine";
                        Codon = Data.Codon.UUC;
                        Code = AminoAcidCode.F;
                    }
                    break;
                case Data.Codon.UUA:
                    {
                        Name = "Leucine";
                        Codon = Data.Codon.UUA;
                        Code = AminoAcidCode.L;
                    }
                    break;
                case Data.Codon.UUG:
                    {
                        Name = "Leucine";
                        Codon = Data.Codon.UUG;
                        Code = AminoAcidCode.L;
                    }
                    break;
                case Data.Codon.UCU:
                    {
                        Name = "Serine";
                        Codon = Data.Codon.UCU;
                        Code = AminoAcidCode.S;
                    }
                    break;
                case Data.Codon.UCC:
                    {
                        Name = "Serine";
                        Codon = Data.Codon.UCC;
                        Code = AminoAcidCode.S;
                    }
                    break;
                case Data.Codon.UCA:
                    {
                        Name = "Serine";
                        Codon = Data.Codon.UCA;
                        Code = AminoAcidCode.S;
                    }
                    break;
                case Data.Codon.UCG:
                    {
                        Name = "Serine";
                        Codon = Data.Codon.UCG;
                        Code = AminoAcidCode.S;
                    }
                    break;
                case Data.Codon.UAU:
                    {
                        Name = "Tyrosine";
                        Codon = Data.Codon.UAU;
                        Code = AminoAcidCode.Y;
                    }
                    break;
                case Data.Codon.UAC:
                    {
                        Name = "Tyrosine";
                        Codon = Data.Codon.UAC;
                        Code = AminoAcidCode.Y;
                    }
                    break;
            }
        }

        public enum AminoAcidCode
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
            H,
            Q,
            N,
            K,
            D,
            E,
            C,
            W,
            R,
            G,
        }
    }
}
