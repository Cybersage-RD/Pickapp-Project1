using System;
using System.Collections.Generic;

namespace StudentInternshipRegistration
{
    class StudentRegistration
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ResumePath { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list for the student registration details
            List<StudentRegistration> registrations = new List<StudentRegistration>();

            // Add a new student registration record
            StudentRegistration registration = new StudentRegistration
            {
                Name = "John Doe",
                Email = "johndoe@email.com",
                Phone = "555-555-5555",
                ResumePath = "/path/to/resume.pdf"
            };
            registrations.Add(registration);

            // Display the student registration records
            foreach (StudentRegistration reg in registrations)
            {
                Console.WriteLine("Name: " + reg.Name);
                Console.WriteLine("Email: " + reg.Email);
                Console.WriteLine("Phone: " + reg.Phone);
                Console.WriteLine("Resume Path: " + reg.ResumePath);
            }
        }
    }
}