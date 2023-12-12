using System;
using System.Diagnostics;

Guid myuuid = Guid.NewGuid();
string uuid = myuuid.ToString();


string firstName;
string lastName;
int age;
firstName = "henrik";
lastName = "alderman";
age = 56;
Console.Write(firstName + " " + lastName + " " + age + " " + uuid);