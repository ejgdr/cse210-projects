using System;
using System.Collections.Generic;
public class PromptGenerator
{
    // List of selections for the user to pick from
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What impression of the Holy Spirit did I follow today?",
        "What from the scriptures could I apply to one of my experiences today?",
        "Did I serve someone other than myself today? What it was?",
        "How could apply the Atonement of Jesus Christ today?"
    };

    Random random = new Random();
    public PromptGenerator()
    {
    }
    // Random selection of the prompt
    public string GenerateAleatoryPrompt()
    {
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }
}