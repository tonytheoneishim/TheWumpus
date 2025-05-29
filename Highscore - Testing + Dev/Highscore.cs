using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Transactions;
using static System.Formats.Asn1.AsnWriter;

namespace Highscore___Testing___Dev;
/// <summary>
/// class highscore
/// </summary>
public class Highscore
{
    const string DATAFILE = "highscores.csv";
    public Highscore()
    {
        PlayerName = string.Empty;
        CaveType = string.Empty;
        HasCOVID = false;
    }
    /// <summary>
    /// creates parameters for highscore function
    /// </summary>
    /// <param name="pn"></player name>
    /// <param name="sc"></player's final score>
    /// <param name="ct"></cave played>
    /// <param name="tn"></times player turned>
    /// <param name="ar"></arrows left>
    /// <param name="gc"></coins left>
    /// <param name="kw"></wumpus killed boolean>
    public Highscore(string pn, int sc, string ct, int tn, int ar, int gc, bool kw)
    {
        PlayerName = pn;
        PlayerFinalScore = sc;
        CaveType = ct;
        Turns = tn;
        ArrowsLeft = ar;
        GoldCoinsLeft = gc;
        KilledWumpus = kw;
    }
    /// <summary>
    /// creates playerdata for highscore processing
    /// </summary>
    public string PlayerName { get; set; }
    public int PlayerFinalScore { get; set; }
    public string CaveType { get; set; }
    public int Turns { get; set; }
    public int ArrowsLeft { get; set; }
    public int GoldCoinsLeft {  get; set; } 
    public bool KilledWumpus { get; set; }
    /// <summary>
    /// list where player highscore data is stored to a .csv file
    /// </summary>
    public List<Highscore> PlayerList = new List<Highscore>();

    /// <summary>
    /// test dummies for highscore listbox sorting
    /// </summary>
    public void TestAdding()
    {
        PlayerList.Add(new Highscore("Kellen1", 10, "Cave1", 5, 10, 10, true));
        PlayerList.Add(new Highscore("Derek2", 20, "Cave2", 5, 10, 10, true));
        PlayerList.Add(new Highscore("Maxim3", 69, "Cave4", 5, 10, 10, true));
        PlayerList.Add(new Highscore("5", 120, "Cave5", 5, 10, 10, false));
        PlayerList.Add(new Highscore("7", 155, "Cave3", 5, 10, 10, false));
        PlayerList.Add(new Highscore("samestats", 30, "Cave1", 5, 10, 10, false));
        PlayerList.Add(new Highscore("samestats", 30, "Cave1", 5,  10, 10, false));
        PlayerList.Add(new Highscore("8", 2, "Cave2", 5, 10, 10, false));
        PlayerList.Add(new Highscore("9", 111, "Cave3", 5, 10, 10, false));
        PlayerList.Add(new Highscore("ten", 150, "Cave1", 5, 10, 10, true));
        PlayerList.Add(new Highscore("ELEVEN", 3, "Cave6", 5, 10, 10, false));
        PlayerList.Add(new Highscore("George", 696715, "Cave5", 2, 1010, 20000, true));
        SavetoFile(PlayerList);
    }
    /// <summary>
    /// Creates the highscore array in list PlayerList
    /// </summary>
    /// <param name="pn"></player name>
    /// <param name="sc"></player's final score>
    /// <param name="ct"></cave played>
    /// <param name="tn"></times player turned>
    /// <param name="ar"></arrows left>
    /// <param name="gc"></coins left>
    /// <param name="kw"></wumpus killed boolean>
    public void AddHighscore(string pn, int sc, string ct, int tn, int ar, int gc, bool kw)
    {
        PlayerList.Add(new Highscore(pn, sc, ct, tn, ar, gc, kw));
        SortHighs();
        if (PlayerList.Count > 10)
        {
            PlayerList.RemoveAt(10);
        }
        
        SavetoFile(PlayerList);
    }
    /// <summary>
    /// Sorts highscores in list PlayerList from highest score to lowest
    /// </summary>
    public void SortHighs()
    {
        for (int i = 0; i < 11; i++)
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
    /// <summary>
    /// Retrieves scores from .csv file to list PlayerList for GC to fetch
    /// </summary>
    /// <param name="scores"></highscores in list PlayerList>
    /// <returns></highscores from list PlayerList>
    public static List<Highscore> GetHighscores(List<Highscore> scores)
    {
        FileInfo fileInfo = new FileInfo(DATAFILE);
        if (fileInfo.Exists)
        {
            scores = OpenFromFile("highscores.csv");
            return scores;
        }
        else return scores;
    }
    /// <summary>
    /// puts name and highscore into listbox-ready string
    /// </summary>
    /// <returns></string>
    public override string ToString()
    {
        return PlayerName + "\t\t" + PlayerFinalScore;
    }
    /// <summary>
    /// saves highscore to .csv file
    /// </summary>
    /// <param name="players"></player data in list PlayerList>
    public static void SavetoFile(List<Highscore> players)
    {
        StreamWriter sw = new StreamWriter(DATAFILE);
        foreach (Highscore player in players)
        {
            string output = player.PlayerName + "," + player.PlayerFinalScore.ToString() + "," + player.CaveType
                + "," + player.Turns + "," + player.ArrowsLeft + "," + player.GoldCoinsLeft + "," + player.KilledWumpus;
            sw.WriteLine(output);
        }
        sw.Flush();
        sw.Close();
    }
    /// <summary>
    /// gets highscore data from .csv file
    /// </summary>
    /// <param name="filename"></.csv file>
    /// <returns></highscores to list PlayerList>
    public static List<Highscore> OpenFromFile(string filename)
    {
        List<Highscore> list = new List<Highscore>();
        StreamReader sr = new StreamReader(filename);
        string line = sr.ReadLine();
        
        while (line != null)
        {
            string[] record = line.Split(',');
            Highscore thehigh = new Highscore(record[0], int.Parse(record[1]), record[2],
                int.Parse(record[3]), int.Parse(record[4]), int.Parse(record[5]), bool.Parse(record[6]));
            list.Add(thehigh);

            line = sr.ReadLine();
        }
        sr.Close();
        return list;
    }




    



    /*
    BAT COVID
    */
    public bool HasCOVID { get; set; }

    public bool ChanceCOVID()
    {
        bool ret = false;
        int infectnum;
        int trigger = 2;
        Random randint = new Random();
        infectnum = randint.Next(1, 5);
        if (infectnum == trigger)
        {
            ret = true;
            HasCOVID = true;
        }
        else ret = false; HasCOVID = false;
        return ret;
    }
    public bool SneezeTimer()
    {
        bool sneeze = false;
        int expellnum;
        Random randint = new Random();
        expellnum = randint.Next(5, 100);
        for (int i = 0; i < 101; i++)
        {
            if (i == expellnum)
            {
                sneeze = true;
                break;
            }
            Thread.Sleep(100);
        }
        return sneeze;
    }
    public bool COVIDDebuff()
    {
        bool ret = false;
        if (HasCOVID == true)
        {
            int tripnum;
            int trigger = 9;
            Random randint = new Random();
            tripnum = randint.Next(1, 10);
            if (tripnum == trigger)
            {
                ret = true;
            }
        }
        else ret = false; HasCOVID = false;
        return ret;
    }
}


    //Game.cs DEBUFF FUNCTIONS

    //    Highscore highscore = new Highscore();
    //    public void TripDebuff()
    //    {
    //        highscore.COVIDDebuff();
    //        if (highscore.COVIDDebuff() != true)
    //        {
    //            // Run: move room
    //        }
    //        else MessageBox.Show("You tripped on the ground.", "Ouch!"); 
    //        return;
    //    }
    //    public void MissAttack()
    //    {
    //        highscore.COVIDDebuff();
    //        if (highscore.COVIDDebuff() != true)
    //        {
    //            // Run: attack wumpus
    //        }
    //        else MessageBox.Show("Your arrow missed.", "Whif!");
    //        return;
    //    }
    //    public void SneezeAttack()
    //    {
    //        highscore.SneezeTimer();
    //        while (true)
    //        {
    //            if (highscore.SneezeTimer() == true)
    //            {
    //                break;
    //            }
    //        }
    //        // Label show you sneezed
    //      //if /* player smelling wumpus */
    //        {
    //            // "the wumpus heard you!"
    //            // put player into wumpus fight
    //        }
    //    }
