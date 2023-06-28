public class Menu{
   public void Display(List<Goal> goals, string filename, Person user, fileHandler filer){
        while (true)
        {
            Console.WriteLine("Choose an option below:\n1. Create New Goal\n2. List Goals\n3. Record Event\n4. Save to file\n5. Display User Stats\n6.Quit");
            string userChoice = Console.ReadLine() ?? string.Empty;
            // needs to set points and difficulty
            if(userChoice == "1"){
                Console.WriteLine("What is the Goal Type (checklist, eternal, or simple)? ");
                string goalType = Console.ReadLine() ?? string.Empty;
                if(goalType == "checklist"){
                    Checklist goal = new Checklist(goalType);
                    goal.setPoints();
                    goals.Add(goal);
                    Console.WriteLine("Goal Saved");
                }
                else if (goalType == "simple")
                {
                    Simple goal = new Simple(goalType);
                    goal.setPoints();
                    goals.Add(goal);
                    Console.WriteLine("Goal Saved");
                }
                else if (goalType == "eternal")
                {
                    Eternal goal = new Eternal(goalType);
                    goal.setPoints();
                    goals.Add(goal);
                    Console.WriteLine("Goal Saved");
                }

            }
            else if(userChoice == "2"){
                Console.Clear();
                Console.WriteLine("Goals:");
                
                foreach(Goal goal in goals){
                    int i = 1;
                    Console.Write($"{i}. ");
                    if (goal.GetComplete() == false){
                        Console.Write("[ ] ");
                        goal.Display();
                        i += 1;
                    }
                    else{
                        Console.Write("[X] ");
                        goal.Display();
                        i += 1;
                    }
                    
                }
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("");
            }
           
            else if(userChoice == "3"){
                // record event 
                foreach(Goal goal in goals){
                   int i = 1;
                    //could probs make this a method somewhere if i rlly wanted to
                    if (goal.GetComplete() == false){
                        Console.Write(i);
                        Console.Write($" [ ]");
                        goal.Display();
                        
                    }
                    else{
                        Console.Write(i);
                        Console.Write($" [X]");
                        goal.Display();
                        
                    }
                    i += 1;
                }

                Console.WriteLine("Which goal would you like to complete/add an event for? (enter a number)");
                int completedGoal = int.Parse(Console.ReadLine() ?? string.Empty); 
                int completeIndex = completedGoal - 1;
                Goal goalComplete = goals[completeIndex];
                if (goalComplete.GetGoalType() == "simple"){

                    goalComplete.SetComplete();
                    user.calculateScore(goals[completeIndex]);
                    // adjust the set complete in each checklist
                    Console.WriteLine($"You have been awarded {goals[completeIndex].GetPoint()} points. Good Job!");
                }
                else if(goalComplete.GetGoalType() == "eternal"){
                    goalComplete.SetComplete();
                    user.calculateScore(goals[completeIndex]);
                    Console.WriteLine($"You have been awarded {goals[completeIndex].GetPoint()} points. Good Job!");
                    goalComplete.SetFalse();
                }
                else if(goalComplete.GetGoalType() == "checklist"){
                    goalComplete.SetComplete();
                    user.calculateScore(goals[completeIndex]);
                    Console.WriteLine($"You have been awarded {goals[completeIndex].GetPoint()} points. Good Job!");
                }
            }

            else if (userChoice == "4"){
                // save to file

                using (StreamWriter sw = new StreamWriter(filename)){       
                    
                    sw.WriteLine(user.GetStringRep());
            
                    foreach (Goal goal in goals){
                        sw.WriteLine(goal.GetStringRepGoal());

                    }
                }
                

            }

            else if(userChoice == "5"){
                user.Display(goals);
                // get user and display their info ya know? maybe just read it straight from the file rather.
            }
            else if(userChoice == "6"){
                break;
            }
        }
    }
}

