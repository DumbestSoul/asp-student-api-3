using Student.Entity.Models;
using Student.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Business.Contract
{
	public interface IStudentBusiness
	{
		List<StudentMaster> GetList();
		StudentMaster GetById(int id);

		void Add(StudentModel student);
		void Delete(int id);
	}
}
