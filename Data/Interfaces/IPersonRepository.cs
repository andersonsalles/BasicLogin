using System.Threading.Tasks;
using BasicLogin.Models;

namespace BasicLogin.Data.Interfaces
{
    public interface IPersonRepository
    {
        public Task Create(Person personToSave, Address addressToSave, Email emailToSave, Phone phoneNumberToSave,
            Personal personalToSave);
        public Task Create(Person personToSave, Address addressToSave, Email emailToSave, Phone phoneNumberToSave,
            Corporation corporationToSave);
        public void Update();
        public void Delete();
    }
}
