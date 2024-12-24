//T1
using ConsoleT8.Models;

Student usrIn = new Student()
{
    Name = "John",
    Major = "Computer Science",
    Gpa = 3.5f
};

//T2
usrIn.print();

//T2.Bonus
GraduateStudent usrIn2 = new GraduateStudent()
{
    Name = "Jane",
    Major = "Computer Science",
    Gpa = 3.4f
};

usrIn2.print();