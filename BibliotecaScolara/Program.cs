namespace BibliotecaScolara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Logare");
            Console.WriteLine("2.Inregistrare cont");
            
            AlegeInregistrareSauLogare();
            Console.ReadLine();
            string[][] carti = {
                new string[] { "chimie avansata", "chimieVolum2", "chimieVolum3" },
                new string[] { "astronomie speciala", "astronomieVolum2", "astronomieVolum3" },
                new string[] { "fizicaCuantica", "fizicaVolum2", "fizicaVolum3" },
                new string[] { "matematicaVolum3 ", "matematicaVolum2", "matematicaVolum3" },
                new string[] { "informatica", "informaticaVolum2", "informaticaVolum3" },
                new string[] { "arteVolum1", "arteVolum2", "arteVolum3" }
            };

            double[][] preturi = {
            new double[] { 30.5, 25.0, 40.0 },
            new double[] { 35.0, 28.0, 45.5 },
            new double[] { 40.0, 32.0, 50.0 },
            new double[] { 22.0, 18.0, 30.0 },
            new double[] { 28.5, 24.0, 38.0 },
            new double[] { 15.0, 12.0, 20.0 }
        };

            AfisareRafturiCuCarti(carti,preturi);

            Console.WriteLine("1. Cautare carte");
            Console.WriteLine("2. Inchide program");


            Console.Write("Alege o optiune: ");
            int optiune = int.Parse(Console.ReadLine());
            OptiuneAlegere(optiune, carti,preturi);

            Console.ReadLine();
        }

        static bool CautareCarte(string[][] carti, string carteCautata)
        {
            bool stare = false;

            for (int i = 0; i < carti.Length; i++)
            {
                for (int j = 0; j < carti[i].Length; j++)
                {
                    if (carteCautata == carti[i][j])
                    {
                        stare = true;
                        break;
                    }
                }
                if (stare) break;
            }

            if (stare)
            {
                TiparesteMesajUserStareCautareDacaTrue();
            }
            else
            {
                TiparesteMesajUserStareCautareDacaFalse();
            }

            return stare;
        }

        static void TiparesteMesajUserStareCautareDacaTrue()
        {
            string mesaj = "Cartea a fost găsită cu succes. Spor la explorat!";
            Console.WriteLine(mesaj);
        }

        static void TiparesteMesajUserStareCautareDacaFalse()
        {
            string mesaj = "Cartea nu a fost găsită! Încercați altadata.";
            Console.WriteLine(mesaj);
        }

        static void ImprumutCarte(string carteImprumutata, string[][] carti, double[][] preturi)
        {
            bool carteGasita = false;
            double pretCarteImprumutata = 0;

            for (int i = 0; i < carti.Length; i++)
            {
                for (int j = 0; j < carti[i].Length; j++)
                {
                    if (carteImprumutata == carti[i][j])
                    {
                        carteGasita = true;
                        pretCarteImprumutata = preturi[i][j];
                        break;
                    }
                }
                
            }

            if (carteGasita)
            {
                Console.WriteLine($"Cartea --{carteImprumutata}--  a fost imprumutata cu succes.");
                Console.WriteLine($"Pretul pentru aceasta carte este de: {pretCarteImprumutata} lei");
            }
            else
            {
                Console.WriteLine($"Cartea {carteImprumutata} nu a fost gasita. Încercați altadata.");
            }
        }


static void AchizitionareCarte()
        {
           
           Console.WriteLine("Cartea a fost achiziționată cu succes.");
         
        }
        static void AfisareRafturiCuCarti(string[][] carti, double[][] preturi)
        {
            Console.WriteLine("Rafturi disponibile:");

            for (int i = 0; i < carti.Length; i++)

            {
                Console.Write($"Raft {i+1}: ");

                //Console.Write($"Raft {i+1}: ");
                for (int j = 0; j < carti[i].Length; j++)
                {
                    Console.Write($"{carti[i][j]} {preturi[i][j]} " + "lei "); ;
                }
                Console.WriteLine();
            }
        }
        static void OptiuneAlegere(int optiune, string[][] carti, double[][] preturi)
        {
            switch (optiune)
            {
                case 1:
                    Console.Write("Introdu numele cartii: ");
                    string cautaCarte = Console.ReadLine();
                    bool carteGasita = CautareCarte(carti, cautaCarte);

                    if (carteGasita)
                    {
                        Console.WriteLine("Vrei sa achizitionezi cartea sau sa o imprumuti?");
                        Console.WriteLine("1. imprumut");
                        Console.WriteLine("2. achizitioneaza");

                        int imprumutSauAchizitie = int.Parse(Console.ReadLine());

                        if (imprumutSauAchizitie == 1)
                        {
                            
                            ImprumutCarte(cautaCarte, carti, preturi);
                           
                        }
                        else if (imprumutSauAchizitie == 2)
                        {
                            AchizitionareCarte();
                        }
                    }
                    break;

                case 2:
                    Console.WriteLine("Programul s-a inchis");
                    break;

                default:
                    Console.WriteLine("Optiune invalida. Programul se va închide.");
                    break;
            }
        }
        //inregistrare student

        static void AlegeInregistrareSauLogare()
        {
            int alegere = int.Parse(Console.ReadLine());

            switch (alegere)
            {
                case 1:
                    Autentificare();
                    break;

                case 2:
                    InregistrareStudent();
                    break;



                default:
                    Console.WriteLine("Optiune invalida.Programul se va inchide");
                   break;
            }
                    
        }
        static void InregistrareStudent()
        {
            Console.Write("Inregistrare student");
            Console.Write("Nume:");
            string nume = Console.ReadLine();
            Console.Write("Introdu Specializarea:");
            string specializare = Console.ReadLine();
            Console.Write("Orasul:");
            string oras = Console.ReadLine();
            Console.Write("Introdu utilizatorul: ");
            string utilizator = Console.ReadLine();
            Console.Write("Introdu parola: ");
            string parola = Console.ReadLine();
            if (parola.Length < 8)
            {
                Console.Write("Parola trebuie sa contina minim 8 caractere!!!");
            }
            else
            {
                Console.Write("Contul a fost creat cu succes");
            }
        }
        static void Autentificare()
        {
           Console.WriteLine("utilizator: ");
            string utilizator = Console.ReadLine();
            Console.WriteLine("parola: ");
            string parola = Console.ReadLine();

        }
    }
}

