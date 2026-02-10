namespace Github
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Diszno> disznok = Filemanager.ReadFile("disznok2.csv");
            Console.WriteLine(String.Join('\n', disznok));

            Diszno legidosebb = disznok.First();
            foreach (Diszno item in disznok)
            {
                if (legidosebb.Age > item.Age)
                {
                    legidosebb = item;
                }
            }
            Console.WriteLine(legidosebb);

            Diszno legnehezebb = disznok.First();
            foreach (Diszno item in disznok)
            {
                if (legnehezebb.Weight > item.Weight)
                {
                    legnehezebb = item;
                }
            }
            Console.WriteLine(legnehezebb);

            int fiuDiszno = 0;
            foreach (Diszno item in disznok)
            {
                if (item.Gender == "kan")
                {
                    fiuDiszno++;   
                }
            }
            Console.WriteLine(fiuDiszno);


            int lanyDiszno = 0;
            foreach (Diszno item in disznok)
            {
                if (item.Gender == "koca")
                {
                    lanyDiszno++;
                }
            }
            Console.WriteLine(lanyDiszno);


            double ossz = 0;
            double fiuAtlagSuly = 0;
            foreach (Diszno item in disznok)
            {
                if (item.Gender == "kan")
                {
                    
                    fiuAtlagSuly += item.Weight;
                    
                }
                
            }

            Console.WriteLine(fiuAtlagSuly / disznok.Count);


            double ossz1 = 0;
            double lanyAtlagEletkor = 0;
            foreach (Diszno item in disznok)
            {
                if (item.Gender == "koca")
                {

                    lanyAtlagEletkor += item.Weight;

                }

            }

            Console.WriteLine(lanyAtlagEletkor / disznok.Count);

            
        }
    }
}
