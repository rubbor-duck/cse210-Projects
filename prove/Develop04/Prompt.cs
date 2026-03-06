using System.Data.SqlTypes;
using System.Globalization;
using System.Numerics;

public class Prompt
{
    private List<string> _randomPrompt = new List<string>();
    private List<int> _usedPrompt = new List<int>();
    private int _num;

    // constructor for creating a prompt list
    public Prompt(List<string> prompts)
    {
        _randomPrompt = prompts;
    }

    // blank constructor for prompt list
    public Prompt(){}

    public void SetRandomPrompt(List<string> prompt)
    {
        _randomPrompt = prompt;
    }

    // Picks a random prompt from a list of prompts, not picking duplicates
    public string GetRandomPrompt()
    {
        while(true){
            Random random = new Random();
            
            _num = random.Next(_randomPrompt.Count);
            if (IsPromptUsed() == false)
            {
                string chosenprompt = _randomPrompt[_num];
                return chosenprompt;
            }
        }
    }

    // checks to see if the prompt has already been used
    public bool IsPromptUsed()
    {
        // counts the total count for _usedPrompt, the iterates through the list looking to see if that index has already been used
        int totalUsed = _usedPrompt.Count();
        for (int i = totalUsed; i>0; i--)
        {
            int x = _usedPrompt[i-1]; // i-1 because the list index starts with zero
            if (x == _num)
            {
                return true;
            }

            else
                continue;
        }

        return false;
    }


}