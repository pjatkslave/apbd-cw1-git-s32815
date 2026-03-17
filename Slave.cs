using System;
public class Slave
{
    public string Name { get; set; } = "Alex";
    public int Energy { get; set; } = 100;
    public int Hunger { get; set; } = 0;

    	public void Work()
    {
        Energy -= 20;
	Hunger += 20;
        Console.WriteLine($"{Name} is coding, energy left: {Energy}%");
    }
	public void Rest()
    {
        Energy += 20;
        Console.WriteLine($"{Name} is watching tiktok instead of do sport, energy left: {Energy}%");
    }
    	public void Feed()
    {
        Hunger = 0;
        Console.WriteLine("You gave a cigarete to slave, now he is happy and doesnt have hunger");
    }
    public void Punish()
    {
    	Energy -= 50;
    	Hunger += 50;
    	Console.WriteLine($"{Name} is punished, energy left: {Energy}%, hunger level: {Hunger}%, and he start to work harder, but you will not see the result of it, cause work of pjatkslave is pointless");
    }
}