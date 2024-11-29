using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTrainingPlatform.Models
{
    //a record would better suit this case as the data is immutable. No need to create an obj in this case.
    record Purchase(string courseID,string studentID,decimal basePrice,decimal discount)
    {
        //deduct discount % from base price 
        decimal PurchasePrice = basePrice - ((discount/100)*basePrice);

        public override string ToString() => $"Course ID {courseID} Student ID {studentID} Base Price {basePrice} " +
                                             $"Discount {discount} Purchase Price {PurchasePrice}";

    }

   
}
