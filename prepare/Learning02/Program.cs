using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
         Job job1 = new Job();
         job1._jobTitle = "Software Engineer";
         job1._company = "Hex Headquarters";
         

         Job job2 = new Job();
         job2._jobTitle = "Mechanical Engineer";
         job2._company = "Faulty Factory";
         

        Resume resume1 = new Resume();
        resume1._name = "Billy Bucket";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}