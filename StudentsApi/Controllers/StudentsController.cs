
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StudentsApi.Models;

[Route("api/students")]
[ApiController]
public class StudentsController: ControllerBase
{
    [HttpGet]
    [Route("all")]
    public ActionResult GetAllStudents()
    {
        var students = new string[]{"DIpesh", "Sagar", "Swostika"};
            
        if(students==null){
            return NotFound();
        }
        return  Ok(students); 
    }
    [HttpGet]
    [Route("{name}")]
    public ActionResult GetAllStudentById(string name)
    {
        var students = new string[]{"Dipesh", "Sagar", "Swostika"};
         var student=   students.Where(x=> x == name).FirstOrDefault();
        if(student==null){
            return NotFound();
        }
        return  Ok(student); 
    }
    [HttpPost]
    [Route("add")]
    public ActionResult CreateStudent(Student student )
    {
       
        if(student==null){
            return BadRequest();
        }
        return  Created("",student); 
    }
    [HttpPost]
    [Route("delete")]
    public ActionResult delete(Student student )
    {
       
        if(student==null){
            return BadRequest();
        }
        return  Created("",student); 
    }
 
}