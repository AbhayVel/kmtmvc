
		using KMISMEntities;
		using KMISMModels;
		using KMISMRepository;
		using System;
		using System.Collections.Generic;
		using System.Linq;
		using System.Text;
		using System.Threading.Tasks;

		namespace KMISMService
		{
		public class DepartmentService
		{

		public DepartmentRepository DepartmentRepository { get; set; }

		public DepartmentService(DepartmentRepository DepartmentRepository)
		{
		DepartmentRepository = DepartmentRepository;
		}
		public List<Department> GetAllDepartments()
		{

		return DepartmentRepository.GetAllDepartments();
		}


		public Department GetDepartmentById(int id)
		{
		DepartmentDepartment = DepartmentRepository.GetDepartmentById(id);
		return  Department;
		}

		//public List<Department> GetDepartments(DepartmentSearchModel DepartmentSearch)
		//{
		//    var lstDepartment= DepartmentRepository.GetDepartments(DepartmentSearch);
		//    DepartmentRepository.BindDepartment(lstDepartment);
		//    return DepartmentRepository.GetDepartments(DepartmentSearch);
		//}
		}
		}

	