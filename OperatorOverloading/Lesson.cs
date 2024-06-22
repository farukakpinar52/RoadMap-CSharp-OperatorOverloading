namespace OperatorOverloading
{

    public class Lesson 
    {
        public string Name { get; set; }

        public static Student operator +(Student s,Lesson l) {
            s.Lessons.Add(l);
            return s; 
        }
        public static Student operator +(Lesson l, Student s)
        {
            s.Lessons.Add(l);
            return s;
        }
    }
    
}
