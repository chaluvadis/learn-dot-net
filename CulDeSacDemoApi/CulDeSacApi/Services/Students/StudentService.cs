using CulDeSacApi.Brokers.Storages;
using CulDeSacApi.Models.Students;
namespace CulDeSacApi.Services.Students
{
    public class StudentService : IStudentService
    {
        private readonly IStorageBroker storageBroker;
        public StudentService(IStorageBroker storageBroker) => this.storageBroker = storageBroker;
        ValueTask<Student> IStudentService.AddStudentAsync(Student student)
            => throw new NotImplementedException();
    }
}