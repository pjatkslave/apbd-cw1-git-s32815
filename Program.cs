using System;
Console.Writeline("Hello, your slave waiting for work");
Console.Writeline("Write 'work' and pjatkslave will start to write a code for you");
Console.Writeline("Write 'rest' and pjatkslave will rest");
Slave mySlave = new Slave();

while (true)
{
	string command = Console.ReadLine()
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
	else
	{
		Console.Writeline("error command");
	}
}