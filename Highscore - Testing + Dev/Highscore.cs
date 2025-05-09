using System.Collections.Generic;
using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;

namespace Highscore___Testing___Dev;


public class Highscore
{

    const string DATAFILE = "highscores.csv";
    public Highscore()
    {
        PlayerName = string.Empty;
        CaveType = string.Empty;
    }
    public Highscore(string n, int s, string c)
    {
        PlayerName = n;
        PlayerFinalScore = s;
        CaveType = c;

    }
    public string PlayerName { get; set; }
    public int PlayerFinalScore { get; set; }
    public string CaveType { get; set; }
    public List<Highscore> PlayerList = new List<Highscore>();
    public List<Highscore> TopTenList = new List<Highscore>();

    public void TestAdding(List<Highscore> ac)
    {
        PlayerList.Add(new Highscore("Kellen1", 10, "Cave1"));
        PlayerList.Add(new Highscore("Derek2", 20, "Cave2"));
        PlayerList.Add(new Highscore("Maxim3", 30, "Cave3"));
        SavetoFile(PlayerList);
    }

    public void SortHighs()
    {
        for (int i = 0; i < PlayerList.Count; i++)
        {
            for (int increasing = 0; increasing < PlayerList.Count - 1; increasing++)
            {
                Highscore based = PlayerList[increasing];
                Highscore compared = PlayerList[increasing + 1];


                if (based.PlayerFinalScore < compared.PlayerFinalScore)
                {
                    PlayerList[increasing] = compared;
                    PlayerList[increasing + 1] = based;

                }
            }
        }
        
    }
    public static List<Highscore> GetHighscores(List<Highscore> scores)
    {
        FileInfo fileInfo = new FileInfo(DATAFILE);
        if (fileInfo.Exists)
        {
            scores = OpenFromFile("highscores.csv");

            return scores;
        }
        else
        {
            return scores;
        }
    }

    /* public void CheckTopTen()
    {
        if (PlayerFinalScore >= PlayerList[9].PlayerFinalScore 
            && PlayerList[9].PlayerFinalScore < PlayerList[8].PlayerFinalScore)
        {
            PlayerList[9] = new Highscore(PlayerName, PlayerFinalScore, CaveType);
        }
        else
        {

        }
        for (int i = 0; i < PlayerList.Count; i++)
        {
            if (PlayerFinalScore >= i) PlayerList[i] = new Highscore(PlayerName, PlayerFinalScore, CaveType);

            if (PlayerFinalScore < i) PlayerList[i + 1] = new Highscore(PlayerName, PlayerFinalScore, CaveType);

            if (PlayerFinalScore <= i) 

            if (PlayerFinalScore >= PlayerList[9].PlayerFinalScore
            && PlayerList[9].PlayerFinalScore < PlayerList[8].PlayerFinalScore)
        }
    }
    */

    public void AddScore(/*string pn, int fs, string ct*/)
    { 
        PlayerList.Add(new Highscore(PlayerName, PlayerFinalScore, CaveType   /*pn, fs, ct*/));
    }

    public static void SavetoFile(List<Highscore> players)
    {
        StreamWriter sw = new StreamWriter(DATAFILE);
        foreach (Highscore player in players)
        {
            string output = player.PlayerName + "," + player.PlayerFinalScore.ToString() + "," + player.CaveType;
            sw.WriteLine(output);
        }
        sw.Flush();
        sw.Close();
    }
    public static List<Highscore> OpenFromFile(string filename)
    {
        List<Highscore> list = new List<Highscore>();
        StreamReader sr = new StreamReader(filename);
        string line = sr.ReadLine();
        
        while (line != null)
        {
            string[] record = line.Split(',');
            Highscore thehigh = new Highscore(record[0], int.Parse(record[1]), record[2]);
            
            list.Add(thehigh);

            line = sr.ReadLine();

        }
        sr.Close();
        return list;
    }

}
