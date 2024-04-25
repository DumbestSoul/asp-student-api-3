using Student.Entity.Models;
using Student.ViewModel;

namespace Student.Repository.Contracts
{
	public interface IStudentRepository
	{
		List<StudentMaster> GetList();
		StudentMaster GetById(int id);

		void Add(StudentModel student);
		void Delete(int id);
	}
}
