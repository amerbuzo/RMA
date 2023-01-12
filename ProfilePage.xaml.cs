using Test1.Models;

namespace Test1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public List<Course> courses { get; set; }

        public ProfilePage()
        {
            courses = new List<Course>
            {
                new Course {name="Web Development", category="IT", description="", icon=""},
                new Course {name="Web Development", category="IT", description="", icon=""}
            };
        }
    }
}