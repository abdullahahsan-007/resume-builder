using BlazorApp2.Models;

namespace BlazorApp2.Services
{
    public class ResumeService
    {
        public Resume ResumeData { get; private set; } = new Resume();

        public void UpdateResume(Resume newResume)
        {
            ResumeData = newResume;
        }
    }
}
