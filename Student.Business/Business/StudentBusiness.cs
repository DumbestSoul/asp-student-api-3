using Student.Business.Contract;
using Student.Entity.Models;
using Student.Repository.Contracts;
using Student.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Business.Business
{
	public class StudentBusiness : IStudentBusiness
	{
		private readonly IStudentRepository _studentRepository;
		public StudentBusiness(IStudentRepository studentRepository)
		{
			this._studentRepository = studentRepository;
		}
		public StudentMaster GetById(int id)
		{
			return _studentRepository.GetById(id);
		}

		public List<StudentMaster> GetList()
		{
			return _studentRepository.GetList();
		}

		public void Add(StudentModel student)
		{
			_studentRepository.Add(student);
		}

		public void Delete(int id)
		{
			_studentRepository.Delete(id);
		}
	}
}
