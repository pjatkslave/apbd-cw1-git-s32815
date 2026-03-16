using System;
Console.Writeline("Hello, your slave waiting for work");
Console.Writeline("Write 'work' and pjatkslave will start to write a code for you");
Console.Writeline("Write 'resr' and pjatkslave will rest");
Slave mySlave = new Slave();
string command = Console.ReadLine();

if (command == "work")
{
    	mySlave.Work();
}
else if (command == "rest")
{
	mySlave.Rest();
}
else
{
Console.Writeline("error command");
}