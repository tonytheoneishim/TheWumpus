using System.Collections.Generic;

namespace Highscore___Testing___Dev;


public class Highscore
{
   
    const string DATAFILE = "highscores.csv";




    public Highscore()
    {
        PlayerName = string.Empty;
        PlayerFinalScore = 
    }
    public Highscore(string n, int s)
    {
        PlayerName = n;
        PlayerFinalScore = s;

    }
    public string PlayerName {get; set;}
    public int PlayerFinalScore {get; set;}
    public List<Highscore> PlayerList = new List<Highscore>();

    public string ConvertTheFinalScoreToAString()
    {
        string outp = PlayerFinalScore.ToString();
        return outp;
    }
    public static void SavetoFile(List<Highscore> players)
    {
        StreamWriter sw = new StreamWriter(DATAFILE);
        foreach (Highscore player in players)
        {
            string output = player.PlayerName + "," + player.PlayerFinalScore;
            sw.WriteLine(output);
        }
        sw.Flush();
        sw.Close();
    }
    private static List<Highscore> OpenFromFile(string filename)
    {

        List<Highscore> list = new List<Highscore>();
        StreamReader sr = new StreamReader(filename);
        string line = sr.ReadLine();

        while (line != null)
        {
            string[] record = line.Split(',');
            Highscore contact = new Highscore(record[0], record[1]);
            
            list.Add(contact);

            line = sr.ReadLine();

        }
        sr.Close();
        //OpenFromFile(line);
        return list;
    }

}
