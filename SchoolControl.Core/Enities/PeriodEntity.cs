namespace SchoolControl.Core.Dtos;

public class PeriodEntity
{
    public int Id { get; set; }

    public string Name { get; set; }

    public DateTime DateRegistration { get; set; } = DateTime.Now;

    public DateTime DateStart { get; set; }

    public DateTime DateEnd { get; set; }
}