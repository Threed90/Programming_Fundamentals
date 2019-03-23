using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _03.Jarvis
{
    class Robot
    {

        public BigInteger MaxEnergy { get; set; }
        public Head Head { get; set; }
        public Torso Torso { get; set; }
        public Arm[] Arms { get; set; }
        public Leg[] Legs { get; set; }

        public Robot(string maxEnergy, Head head, Torso torso, List<Arm> arms, List<Leg> legs)
        {
            MaxEnergy = BigInteger.Parse(maxEnergy);
            Head = head;
            Torso = torso;
            this.Arms = arms.OrderBy(x => x.Enegry).Take(2).ToArray();
            this.Legs = legs.OrderBy(x => x.Energy).Take(2).ToArray();
        }

        public override string ToString()
        {
            string result = "";

            
            if(Head==null || Torso==null || Arms.Length<2 || Legs.Length<2)
            {
                result = "We need more parts!";
            }
            else if (MaxEnergy - Head.Energy - Torso.Energy - Arms[0].Enegry - Arms[1].Enegry - Legs[0].Energy - Legs[1].Energy < 0)
            {
                result = "We need more power!";
            }
            else
            {
                result = $"Jarvis:{Environment.NewLine}" +
                     $"#Head:{Environment.NewLine}" +
                     $"###Energy consumption: {Head.Energy}{Environment.NewLine}" +
                     $"###IQ: {Head.IQ}{Environment.NewLine}" +
                     $"###Skin material: {Head.SkinMaterial}{Environment.NewLine}" +
                     $"#Torso:{Environment.NewLine}" +
                     $"###Energy consumption: {Torso.Energy}{Environment.NewLine}" +
                     $"###Processor size: {Torso.ProcessorSize:f1}{Environment.NewLine}" +
                     $"###Corpus material: {Torso.Material}{Environment.NewLine}" +
                     $"#Arm:{Environment.NewLine}" +
                     $"###Energy consumption: {Arms[0].Enegry}{Environment.NewLine}" +
                     $"###Reach: {Arms[0].ArmDistance}{Environment.NewLine}" +
                     $"###Fingers: {Arms[0].Fingers}{Environment.NewLine}" +
                     $"#Arm:{Environment.NewLine}" +
                     $"###Energy consumption: {Arms[1].Enegry}{Environment.NewLine}" +
                     $"###Reach: {Arms[1].ArmDistance}{Environment.NewLine}" +
                     $"###Fingers: {Arms[1].Fingers}{Environment.NewLine}" +
                     $"#Leg:{Environment.NewLine}" +
                     $"###Energy consumption: {Legs[0].Energy}{Environment.NewLine}" +
                     $"###Strength: {Legs[0].Strength}{Environment.NewLine}" +
                     $"###Speed: {Legs[0].Speed}{Environment.NewLine}" +
                     $"#Leg:{Environment.NewLine}" +
                     $"###Energy consumption: {Legs[1].Energy}{Environment.NewLine}" +
                     $"###Strength: {Legs[1].Strength}{Environment.NewLine}" +
                     $"###Speed: {Legs[1].Speed}{Environment.NewLine}";
            }

            return result;
        }
    }
}
