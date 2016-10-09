using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mongoDBExample.Types;

namespace mongoDBExample
{
    class Program
    {

        static void Main(string[] args)
        {
            LetsAppBase appbase = new LetsAppBase();
            appbase.process();
        }
    }

    public class LetsAppBase : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void process()
        {
            try
            {
                LetsAppContext context = new LetsAppContext();
                List<LetsMeetApp> listApp = new List<LetsMeetApp>();
                LetsMeetApp app = new LetsMeetApp()
                {
                    Authkey = Guid.NewGuid(),
                    Birthday = 06,
                    BirthMonth = "October",
                    MobileNumber = 9822084242,
                    Name = "Nikhil",
                    interests = new List<Interest>()
                {
                    new Interest {InterestId =1, InterestName="Reading", Type= AreayType.intermediate }
                }

                };
                LetsMeetApp nullableApp = new LetsMeetApp()
                {
                    Authkey = Guid.NewGuid(),
                    Birthday = 06,
                    BirthMonth = "October",
                    MobileNumber = 7387233322,
                    Name = "Prachi",
                    interests =null
                };
                listApp.Add(app);
                listApp.Add(nullableApp);
                
                context.collection.InsertMany(listApp);

                 var letsmeet = context.collection.AsQueryable<LetsMeetApp>().Where(p => p.MobileNumber == 7387233322).First();
                Console.WriteLine("AuthKey- {0}", letsmeet.Authkey.ToString());
                Console.WriteLine("Mobile number - {0}", letsmeet.MobileNumber);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
