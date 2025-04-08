using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class Course
{
    public string code { get; set; }
    public string name { get; set; }
}

public class CourseList
{
    public List<Course> courses { get; set; }
}

public class KuliahMahasiswa103022300162
{
    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("tp7_2_103022300162.json");
        CourseList list = JsonSerializer.Deserialize<CourseList>(jsonString);

        Console.WriteLine("Daftar mata kuliah yang diambil:");
        int i = 1;
        foreach (var course in list.courses)
        {
            Console.WriteLine($"MK {i} {course.code} - {course.name}");
            i++;
        }
    }
}

class main
{
    static void Main(string[] args)
    {
        Console.WriteLine(); // pemisah
        KuliahMahasiswa103022300162.ReadJSON();
    }
}
