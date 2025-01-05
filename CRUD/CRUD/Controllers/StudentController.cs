using CRUD.EF;
using CRUD.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;

namespace CRUD.Controllers
{
    public class StudentController : ApiController
    {
        Context db = new Context();
        //Basic (No error Controll)

        //Create Student
        [HttpPost]
        [Route("api/students/create")]
        public HttpResponseMessage Create(Student s)
        {
            db.Students.Add(s);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK,s);
        }

        //Show All Students
        [HttpGet]
        [Route("api/students/read")]
        public HttpResponseMessage Read()
        {
            var data=db.Students.ToList();
            return Request.CreateResponse(HttpStatusCode.OK,data);
        }

        //Show specific Student by Id 
        [HttpGet]
        [Route("api/Students/readId/{id}")]
        public HttpResponseMessage ReadSecId(int id)
        {
            var data =db.Students.Find(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        //Show specific Student by Name
        [HttpGet]
        [Route("api/students/readName/{Name}")]
        public HttpResponseMessage ReadSpecName(string Name)
        {
            var data = db.Students.Where(s => s.Name.ToLower() == Name.ToLower()).ToList();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        //Update Student Details
        [HttpPut]
        [Route("api/Students/update/{id}")]
        public HttpResponseMessage Update(int id, [FromBody] Student updateStudent)
        {
            var data =db.Students.Find(id);
            data.Name=updateStudent.Name;
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");  
        }

        //Delete Student
        [HttpDelete]
        [Route("api/students/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var data = db.Students.Find(id);
            db.Students.Remove(data);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }

        /*
         [HttpPost]
[Route("api/students/create")]
public HttpResponseMessage Create([FromBody] Student s)
{
    try
    {
        if (s == null)
        {
            return Request.CreateResponse(HttpStatusCode.BadRequest, "Invalid data");
        }
        db.Students.Add(s);
        db.SaveChanges();
        return Request.CreateResponse(HttpStatusCode.Created, s);
    }
    catch (Exception ex)
    {
        return Request.CreateResponse(HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
    }
}

[HttpGet]
[Route("api/students/read")]
public HttpResponseMessage Read()
{
    try
    {
        var data = db.Students.ToList();
        if (data == null || !data.Any())
        {
            return Request.CreateResponse(HttpStatusCode.NotFound, "No students found");
        }
        return Request.CreateResponse(HttpStatusCode.OK, data);
    }
    catch (Exception ex)
    {
        return Request.CreateResponse(HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
    }
}

[HttpPut]
[Route("api/students/update/{id}")]
public HttpResponseMessage Update(int id, [FromBody] Student updateStudent)
{
    try
    {
        if (updateStudent == null)
        {
            return Request.CreateResponse(HttpStatusCode.BadRequest, "Invalid data");
        }

        var data = db.Students.Find(id);
        if (data == null)
        {
            return Request.CreateResponse(HttpStatusCode.NotFound, "Student not found");
        }

        data.Name = updateStudent.Name;
        data.Age = updateStudent.Age;
        data.Class = updateStudent.Class;

        db.SaveChanges();
        return Request.CreateResponse(HttpStatusCode.OK, "Updated successfully");
    }
    catch (Exception ex)
    {
        return Request.CreateResponse(HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
    }
}

[HttpDelete]
[Route("api/students/delete/{id}")]
public HttpResponseMessage Delete(int id)
{
    try
    {
        var data = db.Students.Find(id);
        if (data == null)
        {
            return Request.CreateResponse(HttpStatusCode.NotFound, "Student not found");
        }

        db.Students.Remove(data);
        db.SaveChanges();
        return Request.CreateResponse(HttpStatusCode.OK, "Deleted successfully");
    }
    catch (Exception ex)
    {
        return Request.CreateResponse(HttpStatusCode.InternalServerError, $"Error: {ex.Message}");
    }
}

         */
    }
}
