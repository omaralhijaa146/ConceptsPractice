﻿namespace OOPInterfaces.Models;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

    public override string ToString()
    {
        return $@"
                  {Id}
                  {FirstName}-{LastName}
                  {Address}
                  {PhoneNumber}";
    }
}