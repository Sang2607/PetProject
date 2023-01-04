using PetProject.Model.Model;

namespace PetProject.Interfaces.Interfaces
{
    public interface IListTeacher<T>
    {
       
        public Task<T> Create(T _object);
        public void Update(T _object);
        public void Delete(T _object);
        public IEnumerable<T> GetAll();
        public T GetById(int id);

    }
}


