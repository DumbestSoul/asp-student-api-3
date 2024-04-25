using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student.Business.Contract;
using Student.Entity.Models;
using Student.ViewModel;

namespace Student.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentController : ControllerBase
	{
		private readonly IStudentBusiness _studentBusiness;
		public StudentController(IStudentBusiness studentBusiness)
		{
			this._studentBusiness = studentBusiness;
		}

		[HttpGet]
		public ActionResult<List<StudentMaster>> GetList() => _studentBusiness.GetList();

		[HttpGet("{id}")]
		public ActionResult<StudentMaster> GetById(int id) => _studentBusiness.GetById(id);

		[HttpPost]
		public ActionResult Add(StudentModel student)
		{
			_studentBusiness.Add(student);
			return CreatedAtAction("Add", student);
		}

		[HttpDelete("{id}")]
		public ActionResult Delete(int id)
		{
			_studentBusiness.Delete(id);
			return Ok("Entry Deleted");
		}
	}
}
