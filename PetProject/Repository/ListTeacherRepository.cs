using PetProject.Interfaces.Interfaces;
using PetProject.Model.Model;
using PetProject.Models;

namespace PetProject.Repository
{
    public class ListTeacherRepository : IListTeacher<ListTeacher>
    {
        MyDbContext _dbContext;
        public ListTeacherRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ListTeacher> Create(ListTeacher _object)
        {
            var objAdd = await _dbContext.ListTeachers.AddAsync(_object);
            _dbContext.SaveChanges();
            return objAdd.Entity;
        }

        public void Delete(ListTeacher _object)
        {
            _dbContext.Remove(_object);
            _dbContext.SaveChanges();
        }

        public IEnumerable<ListTeacher> GetAll()
        {
            try
            {
                return _dbContext.ListTeachers.Where(x => x.Status == true).ToList();
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public ListTeacher GetById(int id)
        {
            return _dbContext.ListTeachers.Where(x => x.Status == false && x.IdTeacher == id).FirstOrDefault();
        }

        public void Update(ListTeacher _object)
        {
            _dbContext.ListTeachers.Update(_object);
            _dbContext.SaveChanges();
        }
    }


}
