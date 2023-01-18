using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Student_Registration.DATA;
using Student_Registration.Models;
using Student_Registration.Models.Domain;
using System.Threading;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Microsoft.EntityFrameworkCore;

using System.Reflection.Metadata;



namespace Student_Registration.Controllers
{
    public class contro : Controller
    {
        private readonly StudentDbcontext db;

        public contro(StudentDbcontext studentDbcontext)
        {
            db = studentDbcontext;
        }
       
        [HttpGet]
        public async Task<IActionResult> tableview()
        {
            var table = await db.PARLE.ToListAsync();
            return View(table);

        }



        [HttpGet]
        public IActionResult srmview()
        {


            return View();
        }

        [HttpPost]
        public IActionResult Add(Addviewstudents addviewstudent)
        {


            var student = new STUDENT()
            {

                NAME = addviewstudent.NAME,
                PLACE = addviewstudent.PLACE,
                DEPARTMENT = addviewstudent.DEPARTMENT
            };

            db.Add(student);
            db.SaveChanges();
            Thread.Sleep(500);
            return Redirect("/Home/Index");




        }
        [HttpGet]
        public async Task<IActionResult> view(int ID)
        {
            var stu = await db.PARLE.FirstOrDefaultAsync(x => x.ID == ID);
            if (stu != null)
            {
                var viewmod = new STUDENT()
                {
                    ID = stu.ID ,
                    NAME = stu.NAME,
                    PLACE = stu.PLACE,
                    DEPARTMENT = stu.DEPARTMENT
                };
                return View(viewmod);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<ActionResult> view(STUDENT model)
        {
            var stu = await db.PARLE.FindAsync(model.ID);
            if (stu != null)
            {
                stu.ID = model.ID ;
                stu.NAME = model.NAME;
                stu.PLACE = model.PLACE;
                stu.DEPARTMENT = model.DEPARTMENT;
                await db.SaveChangesAsync();
                return Redirect("/Home/Index");
            }
            return Redirect("/Home/Index");

        }

        [HttpPost]
        public async Task<IActionResult> delete(STUDENT model)
        {
            var stu =  await db.PARLE.FindAsync(model.ID);
            if(stu!=null)
            {
                db.PARLE.Remove(stu);
                await db.SaveChangesAsync();
                return Redirect("/Home/Index");

            }
            return RedirectToAction("Index");


        }
        

        }

    }


