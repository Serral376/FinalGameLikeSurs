using System;


[Serializable]
public class Score 
{
    public string Name;
    public int score;
    public Score(string name, int score)
    {
        Name = name;
        this.score = score;
    }
    
}
