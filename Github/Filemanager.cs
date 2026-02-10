using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github;

public class Filemanager
{
    public static List<Diszno> ReadFile(string fileName)
    {
        List<Diszno> disznok = new List<Diszno>();
        try
        {
            foreach (string line in File.ReadAllLines(fileName, Encoding.UTF8).Skip(1))
            {
                string[] temp = line.Split(";");

            }
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }

        return disznok;
    }
}
