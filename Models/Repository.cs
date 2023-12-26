namespace basics.Models{
    public class Repository{

         private static readonly List<Course> _courses = new(); // new List<Course>(); : kısa yolu

        static Repository(){
            _courses = new List<Course>()
            {
                new Course() {
                    Id=1, 
                    Title= "C# Kursu", 
                    Description="Online C# Kursu", 
                    Images="1.jpg",
                    Tags = new string[] {"aspnet", "web geliştirme"},
                    isActive = true,
                    isHome = true
                    },
                new Course() {
                    Id=2, 
                    Title= "Angular Kursu", 
                    Description="Online Angular Kursu", 
                    Images="2.jpg",
                    Tags = new string[] {"php", "web geliştirme"},
                    isActive = false,
                    isHome = true
                    },
                new Course() {
                    Id=3, 
                    Title= "Java Kursu", 
                    Description="Online Java Kursu", 
                    Images="3.jpg",
                    Tags = new string[] {"dart", "web geliştirme"},
                    isActive = true,
                    isHome = true
                    },
                new Course() {
                    Id=4, 
                    Title= "Angular Kursu", 
                    Description="Online Angular Kursu", 
                    Images="1.jpg",
                    Tags = new string[] {"angular", "front-end geliştirme"},
                    isActive = true,
                    isHome = false
                    }
            };
        }
        public static List<Course> Courses{
            get{
                return _courses;
            }
        }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}