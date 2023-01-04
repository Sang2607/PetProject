using PetProject.Interfaces.Interfaces;
using PetProject.Model.Model;
using System;

namespace PetProject.Interfaces.Service
{
    public class ListTeacherService
    {
        private readonly IListTeacher<ListTeacher> _listTeacher;

        public ListTeacherService(IListTeacher<ListTeacher> listTeacher)
        {
            _listTeacher = listTeacher;
        }
        public IEnumerable<ListTeacher> GetPersonByUserId(int UserId)
        {
            return _listTeacher.GetAll().Where(x => x.IdTeacher == UserId).ToList();
        }
        public IEnumerable<ListTeacher> GetAllTeacher()
        {
            try
            {
                return _listTeacher.GetAll().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public ListTeacher GetPersonByUserName(string UserName)
        {
            return _listTeacher.GetAll().Where(x => x.NameTeacher == UserName).FirstOrDefault();
        }
        public async Task<ListTeacher> AddPerson(ListTeacher listTeacher)
        {
            return await _listTeacher.Create(listTeacher);
        }
        public bool DeletePerson(int UserId)
        {

            try
            {
                var DataList = _listTeacher.GetAll().Where(x => x.IdTeacher == UserId).ToList();
                foreach (var item in DataList)
                {
                    _listTeacher.Delete(item);
                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }

        }
        public bool UpdatePerson(ListTeacher listTeacher)
        {
            try
            {
                var DataList = _listTeacher.GetAll().Where(x => x.Status != true).ToList();
                foreach (var item in DataList)
                {
                    _listTeacher.Update(item);
                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }
}
