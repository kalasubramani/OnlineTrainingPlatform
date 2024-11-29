using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using OnlineTrainingPlatform.Models;

namespace OnlineTrainingPlatform.Services
{
    internal class PersistenceLayer
    {
        
        //load data from JSON files as corresponding class obj
        //mark it static as this will be called straight from the main program. So no need of instantiating it
        public static string LoadData(string? filePath)
        {
            //reads JSON format and maps the data to obj
            StreamReader streamReader=File.OpenText(filePath);
            string jsonObj = streamReader.ReadToEnd();
            streamReader.Close(); //stream reader must be closed properly to enable subsequent writes to the same file.
            return jsonObj; //return the json obj to main program

        }

        //read data from JSON file and maps the data to its corresponding classes
        //Ip param - use IList as a generic data type to represent all 3 class types
        public static void AddData(string? filePath,IList allData)
        {
            //converts objs to JSON format
            //check for the type of IList data and type cast the data accordingly and send to JSON serializer
            switch (allData)
            {
                case List<InstructorModel>:
                    //type cast the IList data to the correct class type
                    File.WriteAllText(filePath, JsonSerializer.Serialize<List<InstructorModel>>((List<InstructorModel>)allData));
                    break;

                case List<StudentModel>:
                    File.WriteAllText(filePath, JsonSerializer.Serialize<List<StudentModel>>((List<StudentModel>)allData));
                    break;

                case List<CourseModel>:
                    File.WriteAllText(filePath, JsonSerializer.Serialize<List<CourseModel>>((List<CourseModel>)allData));
                    break;
            }
           

        }
    }
}
