using BasicLogin.Models;

namespace BasicLogin.Data.Interfaces
{
    public interface IPersonRepository
    {
        public void Create(Person personToSave, Address addressToSave, Email emailToSave, Personal personalToSave);
        public void Create(Person personToSave, Address addressToSave, Email emailToSave, Corporation corporationToSave);
        public void Update();
        public void Delete();
    }
}
