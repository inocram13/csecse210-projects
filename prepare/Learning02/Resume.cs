using System.Collections.Generic;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    
    public void Display()
    {
        Console.WriteLine($"Name: {_name} \nJobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
    
}

// public class Scripture
// {
//     private Reference _reference;
//     private List<word> _words = new List<word>();
//     public Scripture()
//     {

//     }
//     public void HideRandomWord(int numberToHide)
//     {

//     }
//     public string GetDisplayText()
//     {

//     }
//     public bool IsCompletelyHidden()
//     {

//     }

    


    
// }