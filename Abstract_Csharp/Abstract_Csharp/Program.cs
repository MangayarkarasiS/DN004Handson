using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Csharp
{

   abstract class Employee
    {
        public int empid;
        public string empnm;
        public string email;
        public float empsal;

        public abstract int calcsal();
        public void showdet()
        {
            
            Console.WriteLine("Enter name");
        }

    }
    class tempemp:Employee
    {
             

      /*  public void calcsal()
        {
            int hours=0, hrly_pay=500;
              float sal =hours*hrly_pay  ;
              Console.WriteLine("Salary for the month= "+sal);
        }*/



    }

class contremp:Employee 
    {
               public void calcsal()
        {
            int leave = 0, month_pay = 25000;
            float sal = month_pay-leave ;
            Console.WriteLine("Salary for the month= " + sal);
        }

    }

    class pro
    {
        staic void main()
        {
            emp contractemp = new ();
            const.
        }
    }











    abstract class emp
    {
        public string firname;
        public string lastnm;
        public string id;
        public int annualsalary;
        public string getfullnm()
        {
            return firname + lastnm;
        }
        public abstract void calculatesal();
        
      
        public virtual void award()
        {
            Console.WriteLine("100% attendance holders will receive Rs.1000");
        }

    }
    class IT:emp
    {
        public override  void award()
        {
            Console.WriteLine("extra Rs.1500 will be given" );
        }
        public override void calculatesal()
        {
            
        }
    }
    class hr: emp
    {
        public override  void award()
        {
            Console.WriteLine("cash award of rs.1000+ one day extra leave will be given");
        }

        public override void calculatesal()
        {
            float monthlysal = annualsalary / 12;
            Console.WriteLine(monthlysal);
        }
    }
    class admin : emp
    {
      public static   int hours=10;
       public  int hrlypay;
        public override void calculatesal()
        {
            float monthlysal = hours * hrlypay;
            hours = hours + 10;
            Console.WriteLine(monthlysal);
        }
        
        public int add()
        {
            hours = hours + 20;
           
            int z = 900;
            Console.WriteLine("Hours="+hours);
            return z;
        }
        
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            admin aa = new admin();
            aa.calculatesal();
            aa.add();




          /*  int y = 100,x=5,z=6;
            admin a = new admin();
          int z=  a.add(out y,ref x,z);
            Console.WriteLine("Inside Main a value= "+y);

            /*fulltimeemp femp = new fulltimeemp();
            femp.firname = "John";
            femp.lastnm = "Peter";
            femp.annualsalary = 50000;

            femp.calculatesal();

            contractemp cemp = new contractemp();
            cemp.firname = "sJohn";
            cemp.lastnm = "sPeter";
            cemp.hrlypay = 500;
            cemp.hours = 8;

            cemp.calculatesal();
            */
            Console.ReadKey();
        }
    }
}

