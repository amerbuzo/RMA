namespace Test1;
using Test1.Models;
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
        InitializeComponent();
	}
}