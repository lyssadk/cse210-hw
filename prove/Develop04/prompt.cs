public class Prompt{

    private List<string> _usedPrompts = new List<string>();
    public void prompt(){

    }

    public void GetRandomPrompt(List<string> listOfPrompts){
        while(true){

            if(listOfPrompts.Count != 0){
                //_usedPrompts.Count() != listOfPrompts.Count()){
                Random random = new Random();
                int index = random.Next(listOfPrompts.Count);
                if(_usedPrompts.Contains(listOfPrompts[index])){
                    
                }
                else{
                Console.WriteLine($"{listOfPrompts[index]}");
                _usedPrompts.Add(listOfPrompts[index]);
                listOfPrompts.RemoveAt(index);
                break;
                }

            }

            // if the count of the list is 0 then this would loop through each prompt in the used prompts list and add it back
            // to the listofPrompts, but the code doesnt like this??????

            // other question: is there a way to make a method for the date time stuff and call it rather than copying and pasting it again and again?
            else if(listOfPrompts.Count == 0){
                foreach (string prompt in _usedPrompts)
                {   
                    listOfPrompts.Add(prompt);
                    _usedPrompts.Remove(prompt);
                }
            }
            else{
                Random random = new Random();
                int index = random.Next(listOfPrompts.Count);
                Console.WriteLine($"{listOfPrompts[index]}");
            }
        }
    }

    public void AddPrompt(){
        
    }
}