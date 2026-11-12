using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("What was the best thing that happened to you today?");
        _prompts.Add("What are you grateful for today?");
        _prompts.Add("What did you learn today?");
        _prompts.Add("What is something you would like to improve about yourself?");
        _prompts.Add("What is a challenge you are facing right now?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}