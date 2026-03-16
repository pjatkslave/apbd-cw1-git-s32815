using System;
public class Slave
{
    public string Name { get; set; } = "Alex";
    public int Energy { get; set; } = 100;

    public void Work()
    {
        Energy -= 20;
        Console.WriteLine($"{Name} is coding, energy left: {Energy}%");
    }
	public void Rest()
    {
        Energy += 20;
        Console.WriteLine($"{Name} is watching tiktok instead of do sport, energy left: {Energy}%");
    }
}