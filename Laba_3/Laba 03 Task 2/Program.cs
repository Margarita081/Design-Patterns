using Laba_03_Task_2.Task_2;
using System;
using static Laba_03_Task_2.Task_2.ATMHandler;
using static Laba_03_Task_2.Task_2.ChechNumberCard;

public class Program
{
    static void Main()
    {
        var realCard = new BankCard
        {
            Number = "0045002305",
            OwnerName = "Carl Linnaeus",
            Status = "Active",
            Money = 10000
        };

        var checkCard = new CardInsertedHadler();
        var checkName = new CardCheckName();
        var checkNumber = new ChechNumberCard();
        var checkStatus = new CheckStatus();
        var checkBalance = new CheckBalance();

        checkCard.SetNext(checkName).SetNext(checkNumber).SetNext(checkStatus).SetNext(checkBalance);

        var request = new ATMRequest
        {
            Card = realCard,
            EnterdNumber = "0045002305",
            EnterdName = "Carl Linnaeus",
            HowMuchMoney = 100
        };

        bool success = checkCard.Handler(request);


        //Memento
        var message = new Message();
        var history = new History();

        Console.WriteLine("Hello!");
        Console.WriteLine("Enter text.");
        Console.WriteLine("Command: 'undo' - cancel.");
        Console.WriteLine("Command: 'redo' - return text.");
        Console.WriteLine("Command: 'exit' - exit.");

        string command;
        while ((command = Console.ReadLine()) != "exit")
        {
            if (command == "undo")
            {
                if (history.Undo(message))
                {
                    Console.WriteLine($"{message.Text}");
                }
                else
                {
                    Console.WriteLine("nothing to cancel.");
                }

            }
            else if (command == "redo")
            {
                if (history.Redo(message))
                {
                    Console.WriteLine(message.Text);
                }
                else
                {
                    Console.WriteLine("nothing to return.");
                }

            }
            else
            {
                history.BackUp(message);
                message.Text = command;
                Console.WriteLine(message.Text);
            }
        }

        //Iterator
        var words = new WordCollection();
        words.Add("Latte");
        words.Add("Espresso");
        words.Add("Machiato");

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}