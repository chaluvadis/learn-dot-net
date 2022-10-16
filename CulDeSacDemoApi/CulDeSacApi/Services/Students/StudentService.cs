using CulDeSacApi.Brokers.Storages;
using CulDeSacApi.Models.Students;
namespace CulDeSacApi.Services.Students
{
    public class StudentService : IStudentService
    {
        private readonly IStorageBroker storageBroker;
        public StudentService(IStorageBroker storageBroker) => this.storageBroker = storageBroker;
        async ValueTask<Student> IStudentService.AddStudentAsync(Student student)
            => await storageBroker.InsertStudentAsync(student);
    }
}