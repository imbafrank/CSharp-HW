using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
            while (true)
            {
                int multifunc;
                Console.Write("1.Add order\n2.Remove order\n3.Search order by client name\n4.Add order detail\n5.Update orderdetail\n6.Remove order detail\nEnter function:");
                Order resultorder = new Order;
                if (int.TryParse(Console.ReadLine(), out multifunc))
                    switch(multifunc)
                    {
                        case 1:
                            int addorderoid;
                            Console.WriteLine("Enter oid");
                            if (int.TryParse(Console.ReadLine(), out addorderoid))
                            {
                                Console.WriteLine("Enter client name");
                                os.AddOrder(addorderoid, Console.ReadLine());
                            }
                            break;
                        case 2:
                            int removeorderoid;
                            Console.WriteLine("Enter oid");
                            if (int.TryParse(Console.ReadLine(), out removeorderoid))
                            {
                                os.RemoveOrder(removeorderoid);
                                //Console.WriteLine("{0}", os.GetByCname("hi")[0]);
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter client name");
                            List<Order> clientnamesearchresult = os.GetByCname(Console.ReadLine());
                            Console.Write("Press number of order for further process");
                            int numchoose;
                            if (int.TryParse(Console.ReadLine(), out numchoose))
                                if(1<=numchoose&&numchoose<=clientnamesearchresult.Count)
                                {
                                    resultorder = clientnamesearchresult[numchoose-1];
                                }
                                break;
                        case 4:
                            resultorder.AddItem(new OrderDetail(Console.ReadLine(), int.Parse(Console.ReadLine())));
                            break;
                        case 5:
                            resultorder.UpdateItem(Console.ReadLine(), int.Parse(Console.ReadLine()));
                            break;
                        case 6:
                            resultorder.RemoveItem(Console.ReadLine());
                            break;
                    }
                else
                {
                    break;
                }



                //Console.WriteLine(os.GetByCname("hi")[0].customername);
                //os.GetByCname("hi")[0].AddItem(new OrderDetail("apple", 2));
                // os.GetByCname("hi")[0].Removeitem("apple");
                //os.RemoveOrder(1);
            }



            //Console.ReadKey();

        }
    }
}
