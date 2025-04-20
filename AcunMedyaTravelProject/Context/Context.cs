using AcunMedyaTravelProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace AcunMedyaTravelProject.Context
{
    public class Context:DbContext
    { 
        //tablonun adını(sınıfın adını) car -> cars
        public DbSet<Category> Categories { get;set;}
        public DbSet<Testimonial> Testimonials {get;set;}
        public DbSet<Destinations> Destinations {get;set;}
        public DbSet<Slider> Sliders {get;set;}
        public DbSet<Services> Services {get;set;}

    }
}