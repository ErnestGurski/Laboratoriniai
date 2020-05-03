class student
{
    public string name { get; set; }
    public string surname { get; set; }
    public double egzorez { get; set; }
    public double sum
    {
        get
        { return this.vid * 0.3 + this.egzorez*0.7;  }
    }

    public double sumMed
    {
        get
        {  return this.point[this.point.Count / 2] * 0.3 + this.egzorez*0.7;  }
    }
    public double vid
    {
        get
        {
            double temp = 0;
            foreach (var value in this.point)
            {
                temp += value;
            }
            return temp / this.point.Count;
        }
    }

    public List<double> point = new List<double>();


    public student(string name, string surname, double egzorez, List<double> point)
    {
        this.name = name;
        this.surname = surname;
        this.egzorez = egzorez;
        this.point = new List<double>(point);
        this.point.Sort();
    }


}
