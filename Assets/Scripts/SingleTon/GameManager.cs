using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager 
{
    public static GameManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameManager();
            }
                
            

            return _instance;
        }
    }
    private static GameManager _instance;



    static public int pos = -1;
    static public int posAnsvers = 0;
    static public int posTerapia = 0;
    static public int pils = 0;
    static public int Language = 0;
    private GameManager() { }

}
