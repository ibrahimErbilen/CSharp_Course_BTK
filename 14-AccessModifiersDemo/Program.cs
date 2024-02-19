using System;
// Course course = new Course(); // error !! 
// for use another projects class
// 1 - go to references in this project
// 2 - under the Projetcs -> Solutions select project
// which includes class that you want to use

// but you need to write something to start of Other projects Program.cs like Console.Readline()
// otherwise you can not run this project
Course course = new Course();

course.Create();

Console.ReadLine();
