using System;
using System.Collections.Generic;

namespace CSharpEventAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 . Video example");
            Console.WriteLine("2 . Employee example");
            Console.WriteLine("Please give input : ");

            switch (Console.ReadLine())
            {
                case "1":
                    EncodeAnyVideo();
                    break;
                case "2":
                    PromotAnyEmploye();
                    break;
            }
        }

        private static void PromotAnyEmploye()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Name = "Jay", Exp =  4},
                new Employee{Name = "Todd", Exp =  3},
                new Employee{Name = "Roy", Exp =  5}
            };

            Employee.PromotedEmployees(employees, x => x.Exp > 3);
            Console.ReadKey();
        }

        static void EncodeAnyVideo()
        {
            var video = new Video { Title = "Chainsmoker massup" };
            var videoEncoder = new VideoEncoder();  //Publisher
            var mailService = new MailService(); //Subscriber
            videoEncoder.VideoEncodedEvent += mailService.VideoEncoded_EventHandler;
            videoEncoder.Encode(video);
        }
    }
}
