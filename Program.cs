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
        if (mySlave.Energy > 0)
        {
            mySlave.Work();
        }
        else
        {
            Console.WriteLine("Error your slave is almost dead, give him some rest");
        }
    	}
	else if (command == "rest")
	{
		mySlave.Rest();
	}
	else
	{
	Console.Writeline("error command");
	}
}