public class Job{
    //Responsibilities:
    //Keeps track of the company, job title, start year, and end year.
    public string company;
    public string job_title;
    public int startYear;
    public int endYear;



    //Behaviors:
    // Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
    public void job_info(){
        Console.WriteLine($"{job_title} ({company}) {startYear}-{endYear}");
    }  
}


public class Resume{
    // Responsibilities:
    //Keeps track of the person's name and a list of their jobs.
    public string name;
    public List<Job> list = new List<Job>();


    //Behaviors:
    //Displays the resume, which shows the name first, followed by displaying each one of the jobs.
    public void resume_dis(){
        Console.WriteLine($"{name}: {list}");
    }
}