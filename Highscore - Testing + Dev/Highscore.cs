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
        PlayerList.Add(new Highscore("Kellen1", 10, "Cave1"));
        PlayerList.Add(new Highscore("Derek2", 20, "Cave2"));
        PlayerList.Add(new Highscore("Maxim3", 30, "Cave3"));

        SavetoFile(PlayerList);
    }

    public static void SortHighs(List<Highscore> scores)
    {
        string numbers = "";
        foreach (Highscore player in scores)
        {
            numbers += player.PlayerFinalScore + ", ";
        }
        int[] scores = { int.Parse(numbers) };
        Array.Sort(scores);


        string listboxhighscores = "";
        for (int i = 0; i < scores.Length; i++)
        {
            //listboxhighscores.selectedindex[i] = 
        }

        for (int i = 0; i < Scores.Count; i++)
      {

           /*
       for (int h = 0; h < Scores.Count - 1; h++)
       {
           Score scores1 = Scores[h];
           Score scores2 = Scores[h + 1];
      
        
           if (scores1.PlayerScore < scores2.PlayerScore)
           {
               Scores[h] = scores2;
               Scores[h + 1] = scores1;
              
           }
      
       } */
       
    }

    // REFERENCE

    //private void HighScoreForm_Load(object sender, EventArgs e)
    //{
    //    Highscore highscore = new Highscore();


    //    FileInfo fileInfo = new FileInfo("highscores.csv");
    //    highscore.PlayerList = Highscore.OpenFromFile("highscores.csv");

    //    foreach (Highscore player in highscore.PlayerList)
    //    {
    //        listBoxHighScores.Items.Add(player.PlayerName);
    //    }
    //}


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
