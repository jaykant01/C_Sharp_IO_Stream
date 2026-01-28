namespace CSV;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    public override string ToString()
    {
        return $"{Id},{Name},{Department},{Salary}";
    }
}
