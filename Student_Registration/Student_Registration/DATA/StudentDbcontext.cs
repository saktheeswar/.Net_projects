using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Student_Registration.Models.Domain;

namespace Student_Registration.DATA
{
    public class StudentDbcontext:DbContext
    {
        public StudentDbcontext(DbContextOptions option): base (option)
        {
            
        }

       
       public  DbSet<STUDENT> PARLE { get; set; }
    }
}
