// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Job soft = new Job();

soft.company = "microsoft";
soft.endYear = 2021;
soft.startYear = 2019;
soft.job_title = "software engineer";


Job swim = new Job();
swim.company = "Mountain Wave Swimming";
swim.job_title = "Water Safety Instructor";
swim.startYear = 2016;
swim.endYear = 2018;


Resume person1 = new Resume();
person1.name = "Julia Ramsden";
person1.list.Add(swim);
person1.list.Add(soft);

person1.resume_dis();

