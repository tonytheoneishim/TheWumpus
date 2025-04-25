namespace Highscore___Testing___Dev;


public class Highscore
{
    List<Highscore> PlayerList = new List<Highscore>();
    public Highscore()
    {
        PlayerName = string.Empty;
        PlayerScore = 0;
    }
    public Highscore(string n, int s)
    {
        PlayerName = n;
        PlayerScore = s;

    }
    public string PlayerName {get; set;}
    public int PlayerScore {get; set;}


    public void MainMenu_ShowHighscoreList()
    {
        
    }

    public void HighscoreMenu_RemoveHighscore()
    {
        //int i = listboxHighscore.SelectedIndex;
        //PlayerList[]
        
    }

    public void HighscoreMenu_ClearHighscores()
    {

    }

    public void GameEnd_GetHighscore()
    {

    }

    public void GameEnd_ShowHighscoreList()
    {

    }
}
