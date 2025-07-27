using System.ComponentModel.DataAnnotations;

namespace OOPPartialTypes;

[MetadataType(typeof(StudentMetaData))]
public partial class Student
{
    partial void PrintName(string? extras)
    {
        Console.WriteLine($"{StudentName} {extras}");
    }
}


/// <summary>
/// @Author: Omar
/// <remarks> Assuming this is an auto generated class</remarks>
/// </summary>

public partial class Student
{
    public string StudentName { get; set; }
    public string HomeAddress { get; set; }
    public string BaseCountry { get; set; }

    partial void PrintName(string? extras);
}