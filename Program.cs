using System;
Console.WriteLine("Hello, your slave waiting for work");
Console.WriteLine("Write 'work' and pjatkslave will start to write a code for you");
Console.WriteLine("Write 'rest' and pjatkslave will rest");
Console.WriteLine("Write 'feed' and you will give some food to pjatkslave");
Console.WriteLine("Write 'punish' and you will hit your slave with whip");
Slave mySlave = new Slave();

while (true)
{
	string command = Console.ReadLine();
	if (command == "exit") break;

	if (command == "work")
	{
        if (mySlave.Energy < 0)
        {
            	Console.WriteLine("Error your slave is almost dead, give him some rest");
        }
	else if (mySlave.Hunger > 100)
	{
	    	Console.WriteLine("Error your slave is almost dead, give him some food");
	}
        else
        {
            	mySlave.Work();
        }
    	}
	else if (command == "rest")
	{
		mySlave.Rest();
	}
	else if (command == "feed")
    	{
        	mySlave.Feed();
    	}
	else if (command == "punish")
    	{
        	mySlave.Punish();
    	}
	else
	{
		Console.WriteLine("error command");
	}
}