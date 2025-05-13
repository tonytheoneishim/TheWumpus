using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
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
    public Highscore(string pn, int sc, string ct, int ar, int gc, bool kw)
    {
        PlayerName = pn;
        PlayerFinalScore = sc;
        CaveType = ct;
        ArrowsLeft = ar;
        GoldCoinsLeft = gc;
        KilledWumpus = kw;
    }
    public string PlayerName { get; set; }
    public int PlayerFinalScore { get; set; }
    public string CaveType { get; set; }
    public int ArrowsLeft { get; set; }
    public int GoldCoinsLeft {  get; set; } 
    public bool KilledWumpus { get; set; }

    public List<Highscore> PlayerList = new List<Highscore>();

    public void TestAdding()
    {
        PlayerList.Add(new Highscore("Kellen1", 10, "Cave1", 10, 10, false));
        PlayerList.Add(new Highscore("Derek2", 20, "Cave2", 10, 10, false));
        PlayerList.Add(new Highscore("Maxim3", 30, "Cave4", 10, 10, false));
        PlayerList.Add(new Highscore("5", 120, "Cave5", 10, 10, false));
        PlayerList.Add(new Highscore("7", 30, "Cave3", 10, 10, false));
        PlayerList.Add(new Highscore("samestats", 30, "Cave1", 10, 10, false));
        PlayerList.Add(new Highscore("samestats", 30, "Cave1", 10, 10, false));
        PlayerList.Add(new Highscore("8", 2, "Cave2", 10, 10, false));
        PlayerList.Add(new Highscore("9", 111, "Cave3", 10, 10, false));
        PlayerList.Add(new Highscore("ten", 150, "Cave1", 10, 10, false));
        PlayerList.Add(new Highscore("ELEVEN", 1, "Cave6", 10, 10, false));
        SavetoFile(PlayerList);
    }
    public void AddHighscore(string pn, int sc, string ct, int ar, int gc, bool kw)
    {
        PlayerList.Add(new Highscore(pn, sc, ct, ar, gc, kw));
        SortHighs();
        if (PlayerList.Count > 10)
        {
            PlayerList.RemoveAt(10);
        }
        
        SavetoFile(PlayerList);
    }
    public void SortHighs()
    {
        for (int i = 0; i < 10; i++)
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
            Highscore thehigh = new Highscore(record[0], int.Parse(record[1]), record[2],
                int.Parse(record[3]), int.Parse(record[4]), bool.Parse(record[5]));
            //donnelly
            list.Add(thehigh);

            line = sr.ReadLine();

        }
        sr.Close();
        return list;
    }

}
