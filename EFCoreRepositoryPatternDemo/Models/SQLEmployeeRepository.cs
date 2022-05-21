using System.Linq;
using System.Collections.Generic;

namespace EFCoreRepositoryPatternDemo.Models
{
    public class SQLEmployeeRepository: IEmployeeRepository
    {

        private readonly AppDBContext context;
        public SQLEmployeeRepository(AppDBContext context)
        {
            this.context = context;

        }
        public ClsEmployee Add(ClsEmployee employee)
        {
            context.CoreEmployees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public void AddSkill(ClsSkill skill)
        {
            context.CoreSkills.Add(skill);
            context.SaveChanges();

        }

        public ClsEmployee Delete(int id)
        {
            ClsEmployee employee = context.CoreEmployees.Find(id);
            if (employee != null)
            {
                context.CoreEmployees.Remove(employee);
                context.SaveChanges();

            }
            return employee;

        }

        public void DeleteSkill(int id)
        {
            ClsSkill skill = context.CoreSkills.Find(id);
            if (skill != null)
            {
                context.CoreSkills.Remove(skill);
                context.SaveChanges();
            }
        }

        public IEnumerable<ClsEmployee> GetAllEmployee()
        {
            IEnumerable<ClsEmployee> employees = context.CoreEmployees;

            return context.CoreEmployees;
        }

        public IEnumerable<ClsSkill> GetAllSkill(int Id)
        {
            return context.CoreSkills.Where(s => s.EmpID == Id).ToList<ClsSkill>();


        }

        public ClsEmployee GetEmployee(ClsEmployee employee)
        {
            return context.CoreEmployees.FirstOrDefault(e => e.Email == employee.Email && e.Password == employee.Password);

        }

        public ClsEmployee GetEmployeeByID(int id)
        {

            return context.CoreEmployees.FirstOrDefault(e => e.EmpID == id);
        }

        public ClsSkill GetSkill(int Id)
        {
            return context.CoreSkills.FirstOrDefault(s => s.SkillId == Id);
        }

        public ClsEmployee Update(ClsEmployee employeeChanges)
        {
            ClsEmployee employee = context.CoreEmployees.FirstOrDefault(e => e.EmpID == employeeChanges.EmpID);
            if (employee != null)
            {
                employee.FirstName = employeeChanges.FirstName;
                employee.LastName = employeeChanges.LastName;
                employee.Password = employeeChanges.Password;
                employee.CellNumber = employeeChanges.CellNumber;
                employee.Email = employeeChanges.Email;

            }
            var emp = context.CoreEmployees.Attach(employee);
            emp.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return employee;


        }
    }
}
