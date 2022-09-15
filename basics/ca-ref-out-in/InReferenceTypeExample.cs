class InReferenceTypeExample
{
    static void Enroll(in Student student)
    {
        // With in assigning a new object would throw an error
        // student = new Student();

        // We can still do this with reference types though
        student.Enrolled = true;
    }

    static void Invoke()
    {
        var student = new Student
        {
            Name = "Susan",
            Enrolled = false
        };

        Enroll(student);
    }
}

