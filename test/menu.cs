public class Menu {

    public void Display(List<Goal> goals, string filename){
        while (true)
        {
            Console.WriteLine("Choose an option below:\n1.Create New Goal\n2. List Goals\n3. Delete Goals\n4. Record Event\n5. Save to file\n 6.Display User Stats\n 7.Quit");
            string userChoice = Console.ReadLine() ?? string.Empty;

            if(userChoice == "1"){
                Console.WriteLine("What is the Goal Type (checklist, eternal, or simple)? ");
                string goalType = Console.ReadLine() ?? string.Empty;
                if(goalType == "checklist"){
                    Checklist goal = new Checklist(goalType);
                    goals.Add(goal);
                    Console.WriteLine("Goal Saved");
                }
                else if (goalType == "simple")
                {
                    Simple goal = new Simple(goalType);
                    goals.Add(goal);
                    Console.WriteLine("Goal Saved");
                }
                else if (goalType == "eternal")
                {
                    Eternal goal = new Eternal(goalType);
                    goals.Add(goal);
                    Console.WriteLine("Goal Saved");
                }

            }
            else if(userChoice == "2"){
                foreach(Goal goal in goals){
                    goal.Display();
                }
            }
            else if(userChoice == "3"){
                if (goals.Count>0){

                    foreach(Goal goal in goals){
                        goal.Display();
                    }

                    Console.WriteLine("Which goal would you like to delete (enter a number)");
                    int remove = int.Parse(Console.ReadLine() ?? string.Empty);
                    int i = remove - 1;
                    goals.RemoveRange(i, i);
                }

               else if(goals.Count == 0){
                    Console.WriteLine("No goals have been made yet.");
               }
            }
            else if(userChoice == "4"){
                // record event 
                foreach(Goal goal in goals){
                    int i = 1;
                    //could probs make this a method somewhere if i rlly wanted to
                    if (goal.GetComplete() == false){
                        Console.Write(i);
                        Console.WriteLine($"[ ]{goal}");
                        i =+ 1;
                    }
                    else{
                        Console.Write(i);
                        Console.WriteLine($"[X]{goal}");
                        i =+ 1;
                    }
                }

                Console.WriteLine("Which goal would you like to complete/add an event for? (enter a number)");
                int completedGoal = int.Parse(Console.ReadLine() ?? string.Empty); 
                
            }

            else if (userChoice == "5"){
                // save to file
                string[] lines = System.IO.File.ReadAllLines(filename);
                
                foreach (Goal goal in goals){
                    string goalDesc = goal.GetDescription();
                    string description = "";
                    
                    /// i need to figure out how to add the new goals to the text file afterwards so it saves.
                    foreach (string line in lines){ 
                        string[] parts = line.Split(":");
                        string goalType = parts[0];
                        string[] parts2 = parts[1].Split(",");
                        description = parts2[2];

                        
                    }
                }
                

            }

            else if(userChoice == "6"){
                // get user and display their info ya know? maybe just read it straight from the file rather.
            }
            else if(userChoice == "7"){
                break;
            }
        }
    }
}