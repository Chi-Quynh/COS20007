using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CustomProject
{


    public class UserCredentialsWriter
    {
        public void WriteCredentialsToFile(string username, string password)
        {
            using (StreamWriter writer = new StreamWriter("credentials.txt"))
            {
                writer.WriteLine(username);
                writer.WriteLine(password);
            }
        }
    }

    public class UserCredentialsReader
    {
        public Tuple<string, string> ReadCredentialsFromFile()
        {
            string username, password;
            using (StreamReader reader = new StreamReader("credentials.txt"))
            {
                username = reader.ReadLine();
                password = reader.ReadLine();
            }
            return new Tuple<string, string>(username, password);
        }
    }

}
