using System;
using System.Collections.Generic;

namespace LauseGeneraattori
{
    class Program
    {
        static int RandInt(int RepeatAmount)
        {
            Random rnd = new Random();
            int RandNum;
            RandNum = rnd.Next(0, (10 - RepeatAmount));
            return RandNum;
            /*Luo satunnaisen numeron numerojen 0 - 10 väliltä */
        }
        static void Main(string[] args)
        {
            int Repeat;
            Console.WriteLine("Kuinka pitkän puheen haluat. Vastaa kokonaislukuna.");
            while (!int.TryParse(Console.ReadLine(), out Repeat))
                Console.WriteLine("Vastaus on virheellinen. Yritä uudelleen.");
            /*Käyttäjältä kysytään puheen pituutta*/

            Generator(Repeat);

        }
        static int Generator(int Repeat)
        {
            /*Puhemetodi*/
            string UsedSana1 = "";
            string UsedSana2 = "";
            string UsedSana3 = "";
            string UsedSana4 = "";

            while (Repeat > 0)
            {
                /*Luodaan listat joissa on lauseenosat*/
                List<string> sana1 = new List<string>(9);
                sana1.Add("On huomattava, että");
                sana1.Add("Kuitenkin");
                sana1.Add("Tämän vuoksi");
                sana1.Add("Ymmärrettävästi");
                sana1.Add("Kun ajattelemme asiaa,");
                sana1.Add("Myös asiantuntijoiden mukaan");
                sana1.Add("Voimme olla varmoja, että");
                sana1.Add("On myös hyvä muistaa, että");
                sana1.Add("Kaiken lisäksi");
                sana1.Add("Mainitsen vielä, että");

                List<string> sana2 = new List<string>(9);
                sana2.Add("opintojen suorittaminen");
                sana2.Add("tenttitilaisuusien järjestäminen");
                sana2.Add("ohjelmointikielen erityispiirteiden hahmottaminen ja huomiointi");
                sana2.Add("oman koodin dokumentointi");
                sana2.Add("kokeisiin harjoittelu");
                sana2.Add("työkokemuksen hankkiminen");
                sana2.Add("koodin siistiminen");
                sana2.Add("hyvä asiakaspalvelu");
                sana2.Add("huono suunnittelu");
                sana2.Add("vähä unen määrä");

                List<string> sana3 = new List<string>(9);
                sana3.Add("auttaa myös");
                sana3.Add("vaikuttaa suoraan mutta myös kiertoteitse");
                sana3.Add("on ratkaisevassa osassa");
                sana3.Add("ei aina auta");
                sana3.Add("voi toimia hyvin");
                sana3.Add("vaikuttaa positiivisesti");
                sana3.Add("voi olla osana");
                sana3.Add("on tärkeä osa");
                sana3.Add("vaikuttaa negatiivisesti");
                sana3.Add("ei ole hyvä asia");

                List<string> sana4 = new List<string>(9);
                sana4.Add("loppututkinnon suorittamisessa.");
                sana4.Add("työelämässä.");
                sana4.Add("saamaan ystäviä ja vaikutusvaltaa.");
                sana4.Add("koulussa.");
                sana4.Add("kotimatkalla.");
                sana4.Add("ystävien kanssa olemisessa.");
                sana4.Add("kesätöissä.");
                sana4.Add("opintojen aikana.");
                sana4.Add("työharjoittelussa.");
                sana4.Add("elämässä.");

                int RepeatAmount = 0;

                /*Valitaan listoista satunnaiset lauseenosat*/
                string RandomSana1;
                do
                {
                    RandomSana1 = sana1[RandInt(RepeatAmount)];
                }
                while (RandomSana1 == UsedSana1);
                UsedSana1 = RandomSana1;

                string RandomSana2;
                do
                {
                    RandomSana2 = sana2[RandInt(RepeatAmount)];
                }
                while (RandomSana2 == UsedSana2);
                UsedSana2 = RandomSana2;

                string RandomSana3;
                do
                {
                    RandomSana3 = sana3[RandInt(RepeatAmount)];
                }
                while (RandomSana3 == UsedSana3);
                UsedSana3 = RandomSana3;

                string RandomSana4;
                do
                {
                    RandomSana4 = sana4[RandInt(RepeatAmount)];
                }
                while (RandomSana4 == UsedSana4);
                UsedSana4 = RandomSana4;

                /*Tulostetaan lause*/
                Console.WriteLine(RandomSana1 + " " + RandomSana2 + " " + RandomSana3 + " " + RandomSana4);
                Repeat -= 1;
                RepeatAmount += 1;
            }

            return 0;
        }
    }
}
