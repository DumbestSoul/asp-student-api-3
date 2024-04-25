using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.ViewModel
{
	public class StudentModel
	{
		public string Name { get; set; } = null!;

		public DateTime JoinDate { get; set; }

		public int Standard { get; set; }
	}
}
