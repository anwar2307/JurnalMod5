using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302194032
{
    internal class SayaTubeUser
    {
        static void Main(string[] args)
        {
            SayaTubeUser a = new SayaTubeUser("Tutorial Design By Contract – [ANWAR YUSUF]");
            a.GetTotalVideoPlayCount();
            a.AddVideo(SayaTubeVideo)(1);
            a.PrintAllVideoPlaycount(1);
        }
    }

    public class SayaTubeUser
    {
        private int id;
        private string username;
        private LinkedList<SayaTubeVideo> uploadVideo;

        public SayaTubeUser(string a)
        {
            Random b = new Random();

            Console.WriteLine("Five random integer values:");
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,15:N0}", b.Next());
            Console.WriteLine();

            for (int ctr = 1; ctr <= 50; ctr++)
            {
                Console.Write("{0,3}    ", b.Next(1000, 10000));
                if (ctr % 10 == 0) Console.WriteLine();
            }

            this.id = b.Next(10000, 100000);
            this.title = a;
            playCount = 0;
            setPlayCount(123);
        }

        public void GetTotalVideoPlayCount(int a)
        {
            TotalVideoPlayCount += a;
        }

        public void AddVideo(SayaTubeVideo)
        {
            Console.WriteLine("Judul video :" + id);
            Console.WriteLine("user : " + username);
            uploadVideo = new LinkedList<SayaTubeVideo>();
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User : " + username);
            Console.WriteLine("video : " + uploadVideo);
        }
    }
}
