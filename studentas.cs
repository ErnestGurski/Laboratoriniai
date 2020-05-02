using System.Collections.Generic;


class studentas
{
    public string vardas { get; set; }
    public string pavarde { get; set; }
    public double rezEgz { get; set; }
    public double galutinis
    {
        get
        {
            return this.vid * 0.3 + this.rezEgz * 0.7;
        }
    }

    public double galutinisMed
    {
        get
        {
            return this.balai[this.balai.Count / 2] * 0.3 + this.rezEgz * 0.7;
        }
    }
    public double vid
    {
        get
        {
            double temp = 0;
            foreach (var value in this.balai)
            {
                temp += value;
            }
            return temp / this.balai.Count;
        }
    }

    public List<double> balai = new List<double>();


    public studentas(string vardas, string pavarde, double rezEgz, List<double> balai)
    {
        this.vardas = vardas;
        this.pavarde = pavarde;
        this.rezEgz = rezEgz;
        this.balai = new List<double>(balai);
        this.balai.Sort();
    }


}