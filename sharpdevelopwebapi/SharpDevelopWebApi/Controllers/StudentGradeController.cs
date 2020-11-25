using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SharpDevelopWebApi.Models;

namespace SharpDevelopWebApi.Controllers
{
    public class StudentGradeController : ApiController
    {
        SDWebApiDbContext _db = new SDWebApiDbContext();

        [HttpGet]
        public IHttpActionResult GetAll(int studentId)
        {
          
            var id = _db.StudentGrades.Find(studentId);
            List<StudentGrade> studentGrade;

            studentGrade = _db.StudentGrades.Where(x => x.Id == studentId).ToList();
            return Ok(studentGrade);
        }

        [HttpPost]
        public IHttpActionResult Create([FromBody] StudentGrade studentGrade)
        {
            _db.StudentGrades.Add(studentGrade);
            _db.SaveChanges();
            return Ok("Successfully Added" + "Id" + studentGrade.Id);
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] StudentGrade updateStudentGrade)
        {
            var student = _db.StudentGrades.Find(updateStudentGrade.Id);
            if (student != null)
            {
                student.StudentId = updateStudentGrade.StudentId;
                student.SubjectId = updateStudentGrade.SubjectId;
                student.P1Grade = updateStudentGrade.P1Grade;
                student.P2Grade = updateStudentGrade.P2Grade;
                student.P3Grade = updateStudentGrade.P3Grade;
                _db.Entry(student).State = EntityState.Modified;
                _db.SaveChanges();

                return Ok(student);
            }
            else
            {
                return BadRequest("Student not found.");
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(int Id)
        {
            var gradeToDelete = _db.StudentGrades.Find(Id);
            if (gradeToDelete != null)
            {
                _db.StudentGrades.Remove(gradeToDelete);
                _db.SaveChanges();

                return Ok("Successfully Deleted.");
            }
            else
            {
                return BadRequest("Grade not available.");
            }
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var studentGrade = _db.StudentGrades.Find(id);
            if (studentGrade != null)
            
                return Ok(studentGrade);
            else
            {
                return BadRequest("Student grade not found.");
            }
        }
    }
}
