using Evolent.DomainLayer.Models;
using Evolent.ServiceLayer.ICustomServices;
using Evolent.RepositoryLayer.IRepository;

namespace ServiceLayer.CustomServices
{
    public class EmployeeService : ICustomService<Employee>
    {
        private readonly IRepository<Employee> _employeeRepository;
        public EmployeeService(IRepository<Employee> studentRepository)
        {
            _employeeRepository = studentRepository;
        }
        public void Delete(Employee entity)
        {
            try
            {
                if(entity!=null)
                {
                    _employeeRepository.Delete(entity);
                    _employeeRepository.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Employee Get(int Id)
        {
            try
            {
                var obj = _employeeRepository.Get(Id);
                if(obj!=null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<Employee> GetAll()
        {
            try
            {
                var obj = _employeeRepository.GetAll();
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Insert(Employee entity)
        {
            try
            {
                if (entity != null)
                {
                    _employeeRepository.Insert(entity);
                    _employeeRepository.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Remove(Employee entity)
        {
            try
            {
                if(entity!=null)
                {
                  _employeeRepository.Remove(entity);
                  _employeeRepository.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Update(Employee entity)
        {
            try
            {
                if(entity!=null)
                {
                    _employeeRepository.Update(entity);
                    _employeeRepository.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
