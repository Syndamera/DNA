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

        public void PrintAminoAcidInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Single letter code: " + SingleLetterCode);
            Console.Write("All Codons:");
            foreach(var codon in Codon)
            {
                Console.Write(" " + codon);
            }
            Console.WriteLine("\n");
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
                        Codon.Add(Data.Codon.UUG);
                        Codon.Add(Data.Codon.CUU);
                        Codon.Add(Data.Codon.CUC);
                        Codon.Add(Data.Codon.CUA);
                        Codon.Add(Data.Codon.CUG);
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
                        Codon.Add(Data.Codon.AGU);
                        Codon.Add(Data.Codon.AGC);
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
                case AminoAcidCode.W:
                    {
                        Name = "Tryptophan";
                        Codon.Add(Data.Codon.UGA);
                        Codon.Add(Data.Codon.UGG);
                        SingleLetterCode = AminoAcidCode.W;
                    }
                    break;
                case AminoAcidCode.P:
                    {
                        Name = "Proline";
                        Codon.Add(Data.Codon.CCU);
                        Codon.Add(Data.Codon.CCC);
                        Codon.Add(Data.Codon.CCA);
                        Codon.Add(Data.Codon.CCG);
                        SingleLetterCode = AminoAcidCode.P;
                    }
                    break;
                case AminoAcidCode.H:
                    {
                        Name = "Histidine";
                        Codon.Add(Data.Codon.CAU);
                        Codon.Add(Data.Codon.CAC);
                        SingleLetterCode = AminoAcidCode.H;
                    }
                    break;
                case AminoAcidCode.Q:
                    {
                        Name = "Glutamine";
                        Codon.Add(Data.Codon.CAA);
                        Codon.Add(Data.Codon.CAG);
                        SingleLetterCode = AminoAcidCode.Q;
                    }
                    break;
                case AminoAcidCode.R:
                    {
                        Name = "Arginine";
                        Codon.Add(Data.Codon.CGU);
                        Codon.Add(Data.Codon.CGC);
                        Codon.Add(Data.Codon.CGA);
                        Codon.Add(Data.Codon.CGG);
                        Codon.Add(Data.Codon.AGA);
                        Codon.Add(Data.Codon.AGG);
                        SingleLetterCode = AminoAcidCode.R;
                    }
                    break;
                case AminoAcidCode.I:
                    {
                        Name = "Isoleucine";
                        Codon.Add(Data.Codon.AUU);
                        Codon.Add(Data.Codon.AUC);
                        Codon.Add(Data.Codon.AUA);
                        SingleLetterCode = AminoAcidCode.I;
                    }
                    break;
                case AminoAcidCode.M:
                    {
                        Name = "Methionine";
                        Codon.Add(Data.Codon.AUG);
                        SingleLetterCode = AminoAcidCode.M;
                        StartCodon = true;
                    }
                    break;
                case AminoAcidCode.T:
                    {
                        Name = "Threonine";
                        Codon.Add(Data.Codon.ACU);
                        Codon.Add(Data.Codon.ACC);
                        Codon.Add(Data.Codon.ACA);
                        Codon.Add(Data.Codon.ACG);
                        SingleLetterCode = AminoAcidCode.T;
                    }
                    break;
                case AminoAcidCode.N:
                    {
                        Name = "Asparagine";
                        Codon.Add(Data.Codon.AAU);
                        Codon.Add(Data.Codon.AAC);
                        SingleLetterCode = AminoAcidCode.N;
                    }
                    break;
                case AminoAcidCode.K:
                    {
                        Name = "Lysine";
                        Codon.Add(Data.Codon.AAA);
                        Codon.Add(Data.Codon.AAG);
                        SingleLetterCode = AminoAcidCode.K;
                    }
                    break;
                case AminoAcidCode.V:
                    {
                        Name = "Valine";
                        Codon.Add(Data.Codon.GUU);
                        Codon.Add(Data.Codon.GUC);
                        Codon.Add(Data.Codon.GUA);
                        Codon.Add(Data.Codon.GUG);
                        SingleLetterCode = AminoAcidCode.V;
                    }
                    break;
                case AminoAcidCode.A:
                    {
                        Name = "Alanine";
                        Codon.Add(Data.Codon.GCU);
                        Codon.Add(Data.Codon.GCC);
                        Codon.Add(Data.Codon.GCA);
                        Codon.Add(Data.Codon.GCG);
                        SingleLetterCode = AminoAcidCode.A;
                    }
                    break;
                case AminoAcidCode.D:
                    {
                        Name = "Aspartic Acid";
                        Codon.Add(Data.Codon.GAU);
                        Codon.Add(Data.Codon.GAC);
                        SingleLetterCode = AminoAcidCode.D;
                    }
                    break;
                case AminoAcidCode.E:
                    {
                        Name = "Glutamic Acid";
                        Codon.Add(Data.Codon.GAA);
                        Codon.Add(Data.Codon.GAG);
                        SingleLetterCode = AminoAcidCode.E;
                    }
                    break;
                case AminoAcidCode.G:
                    {
                        Name = "Glycine";
                        Codon.Add(Data.Codon.GGU);
                        Codon.Add(Data.Codon.GGC);
                        Codon.Add(Data.Codon.GGA);
                        Codon.Add(Data.Codon.GGG);
                        SingleLetterCode = AminoAcidCode.G;
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
