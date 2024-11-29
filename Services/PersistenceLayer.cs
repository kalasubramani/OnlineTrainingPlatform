using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTrainingPlatform.Services
{
    internal class PersistenceLayer
    {
        
        //load data from JSON files as corresponding class obj
        //mark it static as this will be called straight from the main program. So no need of instantiating it
        public static string LoadData(string? filePath)
        {
            StreamReader streamReader=File.OpenText(filePath);
            return streamReader.ReadToEnd(); //return the json obj to main program

        }
    }
}
