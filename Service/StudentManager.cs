using System;
using VariableBasic.Models;

namespace VariableBasic.Service;

public class StudentManager
{
    private readonly List<Student> _students;

    public StudentManager(){
        _students = new List<Student>();
    }
}