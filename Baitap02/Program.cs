using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap02
{

    class Account
    {
        private string id;
        private string name;
        private int balance;
        public Account(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public string getID()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getBlance()
        {
            return balance;
        }
        public void Credit(int amount)
        {
            if (amount > 0)
                balance += amount;
        }
        public void Debit(int amount)
        {
            if (amount <= balance)
                balance -= amount;
            else
                Console.WriteLine(" Số tiền đã vượt quá mức quy định!");
        }
        public void TranferTo(Account Acc, int amount )
        {
            if (amount <= balance)
            {
                balance -= amount;
                Acc.balance += amount;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("---------------------------------------------------------------------");
            Console.Write("Nhập id của bạn: ");
            string id = Console.ReadLine();
            Console.Write("Nhập tên của bạn: ");
            string name = Console.ReadLine();
            Console.Write("Nhập số tiền trong tài khoản của bạn: ");
            int blance = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------------");
            Account my = new Account(id, name,blance);
            Console.Write("Nhập id của bạn: ");
            string id1 = Console.ReadLine();
            Console.Write("Nhập tên của bạn: ");
            string name1 = Console.ReadLine();
            Console.Write("Nhập số tiền trong tài khoản của bạn: ");
            int blance1 = int.Parse(Console.ReadLine());
            Account myFriend = new Account(id1, name1, blance1);
            //Account my = new Account("79792005", "Nguyen Huynh Na", 1000000);
            //Account myFriend = new Account("49941107", "Nguyen Minh Beo", 500000);

            Console.WriteLine("Thông tin 2 tài khoản ban đầu:");
            Console.WriteLine("My Account:[id {0}, Name: {1}, Blance:{2}]",my.getID(),my.getName() , my.getBlance());
            Console.WriteLine("MyFriend Account:[id {0}, Name: {1}, Blance:{2}]", myFriend.getID(), myFriend.getName(), myFriend.getBlance());
            //my.Debit(1000000);
            //my.TranferTo(myFriend, 300000);
            int amount = 0;
            Console.WriteLine("Số tiền bạn muốn rút: ");
            amount = int.Parse(Console.ReadLine());
            my.Debit(amount);
            Console.WriteLine("Số tiền bạn muốn chuyển khoản: ");
            amount = int.Parse(Console.ReadLine());
            my.TranferTo(myFriend, amount);
            Console.WriteLine("------ Thông tin 2 tài khoản sau khi thực hiện giao dịch ------");
            Console.WriteLine("My Account:[id {0}, Name: {1}, Blance:{2}]", my.getID(), my.getName(), my.getBlance());
            Console.WriteLine("MyFriend Account:[id {0}, Name: {1}, Blance:{2}]", myFriend.getID(), myFriend.getName(), myFriend.getBlance());
            Console.ReadLine();
        }
    }
}
