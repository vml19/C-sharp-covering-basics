class RefReferenceTypeExample
{
    static void Enroll(ref Student student)
    {
        // With ref, all three lines below alter the student variable outside the method.
        student.Enrolled = true;
        student = new Student();
        student.Enrolled = false;
    }

    static void Invoke()
    {
        var student = new Student
        {
            Name = "Susan",
            Enrolled = false
        };

        Enroll(ref student);

        // student.Name is now null since a value was not passed when declaring new Student() in the Enroll method
        // student.Enrolled is now false due to the ref modifier
    }
}
