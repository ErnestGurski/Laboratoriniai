class student
{
    public string name { get; set; }
    public string surname { get; set; }
    public double egzorez { get; set; }
    public double sum
    
    
    public student(string name, string surname, double egzorez, List<double> point)
    {
        this.name = name;
        this.surname = surname;
        this.egzorez = egzorez;
        this.point = new List<double>(point);
        this.point.Sort();
    }


}
