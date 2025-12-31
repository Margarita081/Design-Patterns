using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laba_03_Task_2.Task_2
{
    public class BankCard
    {
        public string Number { get; set; }
        public string OwnerName { get; set; }
        public string Status { get; set; }
        public double Money { get; set; }
    }

    public abstract class ATMHandler
    {
        protected ATMHandler? _next;
        public ATMHandler SetNext(ATMHandler next)
        {
            _next = next;
            return _next;
        }

        public virtual bool Handler(ATMRequest reqeust)
        {
            if (_next != null)
            {
                return _next.Handler(reqeust);
            }
            return true;
        }
        public class ATMRequest
        {
            public BankCard? Card { get; set; }
            public string EnterdNumber { get; set; }
            public string EnterdName { get; set; }
            public double HowMuchMoney { get; set; }
        }
    }

    public class CardInsertedHadler : ATMHandler
    {
        public override bool Handler(ATMRequest reqeust)
        {
            if (reqeust.Card == null)
            {
                Console.WriteLine("Error! The card is not inserted. Insert the card.");
                return false;
            }
            Console.WriteLine("The card is inserted");
            return base.Handler(reqeust);
        }
    }

    public class CardCheckName : ATMHandler
    {
        public override bool Handler(ATMRequest reqeust)
        {
            if (reqeust.EnterdName == null)
            {
                Console.WriteLine("Write your full name.");
                return false;
            }
            else if (reqeust.EnterdName != reqeust.Card.OwnerName)
            {
                Console.WriteLine("The name does not match the name of the cardholder. Make sure that you entered the name correctly.: Last Name First Name");
                return false;
            }

            Console.WriteLine("Name confirmed");
            return base.Handler(reqeust);
        }
    }

    public class ChechNumberCard : ATMHandler
    {
        public override bool Handler(ATMRequest reqeust)
        {
            if (reqeust.EnterdNumber == null)
            {
                Console.WriteLine("The card number is not entered.");
                return false;
            }
            else if (reqeust.EnterdNumber != reqeust.Card.Number)
            {
                Console.WriteLine("The card number is incorrect. Try again.");
                return false;
            }
            Console.WriteLine("The card has been found.");
            return base.Handler(reqeust);
        }

        public class CheckStatus : ATMHandler
        {
            public override bool Handler(ATMRequest reqeust)
            {
                if (reqeust.Card.Status != "Active")
                {
                    Console.WriteLine("Your card is not active. Contact the bank");
                    return false;
                }
                Console.WriteLine("Card is active.");
                return base.Handler(reqeust);
            }
        }

        public class CheckBalance : ATMHandler
        {
            public override bool Handler(ATMRequest reqeust)
            {
                if (reqeust.HowMuchMoney > reqeust.Card.Money)
                {
                    Console.WriteLine($"There are insufficient funds in the account. Your balance is {reqeust.Card.Money}");
                    return false;
                }
                Console.WriteLine("The money is ready to be issued.");
                reqeust.Card.Money -= reqeust.HowMuchMoney;
                Console.WriteLine($"Your money and the receipt. Your card balance is {reqeust.Card.Money}");
                return base.Handler(reqeust);
            }
        }
    }
}
