using System.Collections.Generic;
using System.Diagnostics;

namespace Highscore___Testing___Dev;


public class Highscore
{
   
    const string DATAFILE = "highscores.csv";
    public Highscore()
    {
        PlayerName = string.Empty;
        PlayerFinalScore = 0;
        CaveType = string.Empty ;
    }
    public Highscore(string n, int s, string c)
    {
        PlayerName = n;
        PlayerFinalScore = s;
        CaveType = c;

    }
    public string PlayerName {get; set;}
    public int PlayerFinalScore {get; set;}
    public string CaveType {get; set;}  
    public List<Highscore> PlayerList = new List<Highscore>();
    

    public void TestAdding(List<Highscore> ac)
    {
        Highscore highscore;
        highscore = new Highscore("Kellen1", 10, "Cave1");
        highscore = new Highscore("Derek2", 20, "Cave2");
        highscore = new Highscore("Maxim(3)", 30, "Cave3");

        SavetoFile(highscore);
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
