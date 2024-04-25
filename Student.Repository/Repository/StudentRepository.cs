using Microsoft.EntityFrameworkCore;
using Student.Entity.Models;
using Student.Repository.Contracts;
using Student.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Repository.Repository
{
	public class StudentRepository : IStudentRepository
	{
		private readonly StudentDbContext _dbContext;
		public StudentRepository(StudentDbContext dbContext)
		{
			this._dbContext = dbContext;
		}

		public List<StudentMaster> GetList()
		{
			List<StudentMaster> studentList = new();
			studentList = _dbContext.Students.ToList();
			return studentList;
		}

		public StudentMaster GetById(int id)
		{
			StudentMaster std = new();
			std = _dbContext.Students.First(p => p.StudentId == id);
			return std;
		}

		public void Add(StudentModel student)
		{
			StudentMaster newStudent = new();
			newStudent.Name = student.Name;
			newStudent.JoinDate = student.JoinDate;
			newStudent.Standard = student.Standard;

			_dbContext.Students.Add(newStudent);
			_dbContext.SaveChanges();
		}

		public void Delete(int id)
		{
			var x = _dbContext.Students.FirstOrDefault(p=>p.StudentId==id);
			_dbContext.Students.Remove(x);
			_dbContext.SaveChanges();
		}
	}
}
