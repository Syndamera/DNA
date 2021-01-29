using System;
using System.Collections.Generic;
using System.Text;

namespace DNA
{
    class AminoAcid
    {
        public string Name;
        public List<Data.Codon> Codon = new List<Data.Codon>();
        public AminoAcidCode SingleLetterCode;
        public bool StartCodon = false;

        public AminoAcid()
        {

        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Code: " + SingleLetterCode);
        }

        public void InitAminoAcidInfo(AminoAcidCode singleLetterCode)
        {
            switch (singleLetterCode)
            {
                case AminoAcidCode.F:
                    {
                        Name = "Phenylalanine";
                        Codon.Add(Data.Codon.UUU);
                        Codon.Add(Data.Codon.UUC);
                        SingleLetterCode = AminoAcidCode.F;
                    }
                    break;
                case AminoAcidCode.L:
                    {
                        Name = "Leucine";
                        Codon.Add(Data.Codon.UUA);
                        Codon.Add(Data.Codon.UUG);
                        SingleLetterCode = AminoAcidCode.L;
                    }
                    break;
                case AminoAcidCode.S:
                    {
                        Name = "Serine";
                        Codon.Add(Data.Codon.UCU);
                        Codon.Add(Data.Codon.UCC);
                        Codon.Add(Data.Codon.UCA);
                        Codon.Add(Data.Codon.UCG);
                        SingleLetterCode = AminoAcidCode.S;
                    }
                    break;
                case AminoAcidCode.Y:
                    {
                        Name = "Tyrosine";
                        Codon.Add(Data.Codon.UAU);
                        Codon.Add(Data.Codon.UAC);
                        SingleLetterCode = AminoAcidCode.Y;
                    }
                    break;
                case AminoAcidCode.C:
                    {
                        Name = "Cysteine";
                        Codon.Add(Data.Codon.UGU);
                        Codon.Add(Data.Codon.UGC);
                        SingleLetterCode = AminoAcidCode.C;
                    }
                    break;
            }
        }

        public enum AminoAcidCode
        {
            F,
            L,
            S,
            Y,
            C,
            W,
            P,
            H,
            Q,
            R,
            I,
            M,
            T,
            N,
            K,
            V,
            A,
            D,
            E,
            G,
        }
    }
}
