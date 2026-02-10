using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Github;

public class Diszno
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }

    public Diszno(string[] data)
    {
        this.Name = data[0].Trim(' ');
        this.Gender = data[1].Trim(' ');
        this.Weight = double.Parse(data[2]);
        this.Age = int.Parse(data[3]);
    }
    
    public string Rename(string newName)
    {
        return $"az új neve: {newName}";
    }
    
    public double Feed()
    {
        double newWeight = Weight * 0.01;
        return newWeight;
    }
    public override string ToString()
    {
        return $"a neve: {Name}, neme: {Gender}, súlya: {Weight}, életkora: {Age}";
    }

}
