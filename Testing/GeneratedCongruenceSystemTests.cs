using NUnit.Framework;
using KinesiskaRestsatsen;
using System.Collections.Generic;
using System.Numerics;
using System.IO;
using System;
namespace Testing
{
    public class GeneratedCongruenceSystemTests
    {
        public string Root  { get; set; }
        public ICongruenceSystem GenCong { get; set; }
        public BigInteger Answear { get; set; }
        [SetUp]
        public void Setup()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string Root = @"C:\Users\dante\OneDrive\Dokument\VSCode\chinese-remainder-theorem-calc";
            Directory.SetCurrentDirectory(Root);
            GenCong = new GeneratedCongruenceSystem((200000, 300), Root);
            Answear = GenCong.SolveCongruenceSystem(Root);
        }

        [Test]
        public void ThrowsWhenNoCongruenceSystemCanBeCreatedWithTheGivenInputs()
        {
            string Root = @"C:\Users\dante\OneDrive\Dokument\VSCode\chinese-remainder-theorem-calc";
            Directory.SetCurrentDirectory(Root);
            int maxValue = 100;
            int congs = 26;
            Assert.Throws(typeof(System.Exception), delegate{new GeneratedCongruenceSystem((maxValue, congs), Root);} );
        }
        [Test]
        public void GivesCorrectSolution100Times(){
            string Root = @"C:\Users\dante\OneDrive\Dokument\VSCode\chinese-remainder-theorem-calc";
            Directory.SetCurrentDirectory(Root);
            // Reapeat test n times
            int errorCount = 0;
            for(int i = 0; i < 1 ; i++){
                GenCong = new GeneratedCongruenceSystem((1000000, 12000), Root);
                Answear = GenCong.SolveCongruenceSystem(Root);
                errorCount += Helper.LocateErrors(GenCong.A, GenCong.N, GenCong.Answear);
            }
            Assert.AreEqual(0, errorCount);
        }
    }
}