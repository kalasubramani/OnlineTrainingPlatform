using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTrainingPlatform.Models
{
    //base class - make it abstract
    internal abstract class PersonModel
    {
        //accessible only in derived classes
        protected string? FirstName, LastName;
        protected DateTime DateOfBirth;
        protected int Age;

        protected PersonModel(string? firstName,string? lastName,DateTime dataofBirth )
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dataofBirth;
            Age=DateTime.Now.Year - dataofBirth.Year;
        }

    }
}
