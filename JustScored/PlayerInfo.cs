namespace JustScored;

public class PlayerInfo
{
    private float maxScore;
    private int gamesPlayed;
    private int gamesWon;

    public float MaxScore
    {
        get => maxScore;
        set
        {
            if (value > maxScore) maxScore = value;
        }
    }
    
    public string Name { get; }

    public float RateOfSuccess
    {
        get
        {
            float rateOfSuccess = 0;
            if (gamesPlayed > 0) rateOfSuccess = gamesWon / gamesPlayed;

            return rateOfSuccess;
        }
    }

    public void AddGame(bool win)
    {
        gamesPlayed++;
        if (win == true) gamesWon++;
    }

    public PlayerInfo(string Name)
    {
        gamesWon = 0;
        gamesPlayed = 0;
        this.Name = Name;
        maxScore = 0;
    }
}    