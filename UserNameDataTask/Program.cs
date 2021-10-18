using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada oma eesnime;
            //programm küsib kasutajal sisestada numbrit 1-3;
            //kui kasutaja sisestab '1', siis kuvatkse kasutaja eesnime tagurpidi
            //kui kasutaja sisestab '2', siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib '3', siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnime:");
            string userName = Console.ReadLine();

            Console.WriteLine("Vali number ('1', '2' või '3')");
            char userOperator = Convert.ToChar(Console.ReadLine());
            

            switch (userOperator)
            {
                case '1':
                    GetUserNameData1(userName);
                    break;
                case '2':
                    GetUserNameData2(userName);
                    break;
                case '3':
                    GetUserNameData3(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;

            }


        }

        public static void GetUserNameData1(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }
        public static void GetUserNameData2(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }
        public static void GetUserNameData3(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
    }
}
