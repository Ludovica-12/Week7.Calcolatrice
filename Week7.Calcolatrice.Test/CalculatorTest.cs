using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.Calcolatrice.Core;
using Xunit;

namespace Week7.Calcolatrice.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void TestSomma()
        {
            //ARRANGE : predisposizione del test
            MainBL operation = new MainBL();

            //ACT : chiamata alla funzione da testare
            double risultato = operation.SommaNumeri(5, 3);

            //ASSERT: verifica del risultato
            Assert.Equal(8 , risultato);

        }
        [Fact]
        public void TestSottrazione()
        {
            //ARRANGE : predisposizione del test
            MainBL operation = new MainBL();

            //ACT : chiamata alla funzione da testare
            double risultato = operation.SottraiNumeri(5, 3);

            //ASSERT: verifica del risultato
            Assert.Equal(2, risultato);

        }
        [Fact]
        public void TestMoltiplicazione()
        {
            //ARRANGE : predisposizione del test
            MainBL operation = new MainBL();

            //ACT : chiamata alla funzione da testare
            double risultato = operation.MoltiplicaNumeri(5, 3);

            //ASSERT: verifica del risultato
            Assert.Equal(15, risultato);

        }
        [Fact]
        public void TestDivisione()
        {
            //ARRANGE : predisposizione del test
            MainBL operation = new MainBL();

            //ACT : chiamata alla funzione da testare
            double? risultato = operation.DividiNumeri(5, 2);

            //ASSERT: verifica del risultato
            Assert.Equal(2.5, risultato);           

        }

        [Fact]
        public void TestDivisioneZero()
        {
            //ARRANGE : predisposizione del test
            MainBL operation = new MainBL();

            //ACT : chiamata alla funzione da testare
            double? risultato = operation.DividiNumeri(1 , 0);

            //ASSERT: verifica del risultato
            Assert.Null(risultato);

        }

        [Fact]
        public void TestVerificaSeAMaggioreDiB()
        {
            //ARRANGE: predisposizione del test
            MainBL calcolatrice = new MainBL();

            //ACT: chiamata alla funzionalità da testare
            bool risultato = calcolatrice.VerificaSeAMaggioreDiB(3, 1);

            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato == true);
        }

        [Fact]
        public void TestVerificaSeAMaggioreDiB2()
        {
            //ARRANGE: predisposizione del test
            MainBL calcolatrice = new MainBL();

            //ACT: chiamata alla funzionalità da testare
            bool risultato = calcolatrice.VerificaSeAMaggioreDiB(3.2, 3.2);

            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato == true);
        }



    }
}
