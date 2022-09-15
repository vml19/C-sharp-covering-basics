class Program
{
    static void Main(string[] args)
    {
        #region PassByReference
        var studentPassByRef = new Student
        {
            Name = "Susan",
            Enrolled = false
        };

        Enroll(studentPassByRef);

        // student.Name is still Susan
        // student.Enrolled is now true
        #endregion

        #region PassByValue
        var studentPassByValue = new Student
        {
            Name = "Susan",
            Enrolled = false
        };

        Enroll(studentPassByValue.Enrolled);
        // student.Enrolled still equals false.
        #endregion
    }

    static void Enroll(Student student)
    {
        student.Enrolled = true; // This changes the student variable that was passed in outside of the method.
        student = new Student(); // This does not change the student variable outside of the method but creates a new reference.
                                 // Since student now points to a new reference,
                                 // the student variable outside of the method is no longer affected after this line.
        student.Enrolled = false; // This changes the local student inside the method.
    }

    static void Enroll(bool enrollmentStatus)
    {
        // This will not change any value outside the method.
        enrollmentStatus = true;
    }
}

public class Student
{
    public string? Name { get; set; }
    public bool Enrolled { get; set; }
}