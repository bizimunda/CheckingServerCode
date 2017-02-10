using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ReadingBadRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            string bad=
                "https://cap.mobilit.fgov.be/FodMob/rest/candidate/69040302702?APIKey=3682a9ac-16ec-45f6-8dba-034a05326617";
            string good=
                "https://cap.mobilit.fgov.be/FodMob/rest/candidate/84031709318?APIKey=3682a9ac-16ec-45f6-8dba-034a05326617";
            int result=badRequest(bad);
            Console.Write(result);
            Console.ReadLine();
               
        }

        private static int badRequest(string url)
        {
            int good = 100;
            int bad = 400;
            
            WebRequest request = WebRequest.Create(url);
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    //Console.Write(response.ToString());
                    //Console.ReadLine();
                    return good;
                }

            }
            catch (WebException ex)
            {
                //Console.WriteLine(ex.GetType().FullName);
                //Console.WriteLine(ex.GetBaseException().ToString());
                //Console.Write("There is an error");
                //Console.ReadLine();
                return bad;
            }
        }

        
        
    }
}
