using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using SharpDevelopWebApi.Models;

namespace SharpDevelopWebApi.Controllers
{
    public class GradeController : ApiController
    {
        SDWebApiDbContext _db = new SDWebApiDbContext();
        
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            List<Grade> grades = _db.Grades.ToList();
            return Ok(grades);
        }
        [HttpPost]
        public IHttpActionResult Create([FromBody]Grade grade)
        {
            _db.Grades.Add(grade);
            _db.SaveChanges();
            return Ok("Successfully Added.");
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] Grade updateGrade)
        {
            var grade = _db.Grades.Find(updateGrade.Id);
            if (grade != null)
            {
                grade.Id = updateGrade.Id;
                grade.StudentId = updateGrade.StudentId;
                grade.SubjectId = updateGrade.Artist;
                grade.P1Grade = updateGrade.P1Grade;
                grade.P2Grade = updateGrade.P2Grade;
                grade.P3Grade = updateGrade.P3Grade;
                _db.Entry(grade).State = EntityState.Modified;
                _db.SaveChanges();
                return Ok(grade);
            }
            else
                return BadRequest("Record not found.");
        }

        [HttpDelete]
        public IHttpActionResult Delete(int Id)
        {
            var gradeToDelete = _db.Grades.Find(Id);
            if (gradeToDelete != null)
            {
                _db.Grades.Remove(gradeToDelete);
                _db.SaveChanges();
                return Ok("Successfully Deleted.");
            }
            else
                return BadRequest("Record not found.");
        }

        [HttpGet]
        public IHttpActionResult Get(int Id)
        {
            var grade = _db.Grades.Find(Id);
            if (grade != null)
                return Ok(grade);
            else
                return BadRequest("Record not found.");
        }
    }
}
