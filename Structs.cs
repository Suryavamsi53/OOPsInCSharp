using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsInCsharp
{
    internal class Structs
    {
       

            static void Main(string[] args)
            {
                doApp();
            }

            public static void doApp()
            {

                Students[] s = new Students[3];
                for (int i = 0; i < s.Length; i++)
                {
                    s[i].name = "Name " + i.ToString();
                    s[i].address = "Address of student ";
                    s[i].rollNumber = i;
                    s[i].className = " VA";
                    s[i].dateOfBirth = Convert.ToDateTime("1992-09-10 00:00:00");
                }

                for (int i = 0; i < s.Length; i++)
                {
                    Console.Write(s[i].name + ",");
                    Console.Write(s[i].address + ",");
                    Console.Write(s[i].rollNumber + ",");
                    Console.Write(s[i].className + ",");
                    Console.Write(s[i].dateOfBirth);
                    Console.WriteLine("------------------------");
                }
            }
        }

        struct Students
        {
            public string name;
            public string address;
            public int rollNumber;
            public string className;
            public DateTime dateOfBirth;


        }
    }
