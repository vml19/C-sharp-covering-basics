class OutReferenceTypeExample
{
    static void Enroll(out Student student)
    {
        //We need to initialize the variable in the method before we can do anything
        student = new Student();
        student.Enrolled = false;
    }

    static void Invoke()
    {
        Student student;

        Enroll(out student); // student will be equal to the value in Enroll. Name will be null and Enrolled will be false.
    }
}