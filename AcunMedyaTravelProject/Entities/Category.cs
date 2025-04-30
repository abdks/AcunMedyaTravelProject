using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AcunMedyaTravelProject.Entities
{
    public class Category
    {
        //categoryıd, categoryname, 
        public int CategoryID { get; set; }

        public string CategoryName { get; set;}
       
        public List<Destinations> Destinations {get;set;}

    }
}



