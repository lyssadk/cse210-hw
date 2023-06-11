public class Prompt{

    private List<string> _usedPrompts = new List<string>();

    public void GetRandomPrompt(List<string> listOfPrompts){
        while(true){

            if(listOfPrompts.Count != 0){
                
                Random random = new Random();
                int index = random.Next(listOfPrompts.Count);

                if(_usedPrompts.Contains(listOfPrompts[index])){
                    
                }
                else{
                Console.WriteLine($"{listOfPrompts[index]}");
                _usedPrompts.Add(listOfPrompts[index]);
                // test: _usedPrompts.ForEach(p => Console.WriteLine(p));
                listOfPrompts.RemoveAt(index);
                break;
                }

            }
            // if the count of the list is 0 then this would loop through each prompt in the used prompts list and add it back
            // to the listofPrompts
            else if(listOfPrompts.Count == 0){
                foreach (string prompt in _usedPrompts)
                {   
                    listOfPrompts.Add(prompt);
                }
                _usedPrompts.Clear();
            }
            else{
                Random random = new Random();
                int index = random.Next(listOfPrompts.Count);
                Console.WriteLine($"{listOfPrompts[index]}");
            }
        }
    }
}