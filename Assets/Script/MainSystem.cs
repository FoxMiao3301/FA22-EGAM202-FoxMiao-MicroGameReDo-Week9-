using Egam202;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSystem : MonoBehaviour
{
    public int BreakPoint;
    public int Bug;
    public int WinPoint;
    public bool Lose;
    public GameObject LoseEnd;
    public GameObject WinEnd;
    public GameObject RetryB;
    public MicrogameInstance Microgame;
    public enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }

    public Difficulty State;



    public class GameDS
    {
        public Difficulty difficulty;
    }

    void Start()
    {
        switch (State)
        {
            case Difficulty.Easy:
                BreakPoint = 20;

                break;

            case Difficulty.Medium:
                BreakPoint = 15;

                break;

            case Difficulty.Hard:
                BreakPoint = 10;

                break;

        }
        WinPoint = 0;
        Lose = false;
        Debug.Log(State + "Mode");
        if (Microgame._DEBUG_Difficulty == MicrogameInstance.Difficulty.Easy)
        {
            switch (State)
            {
                case Difficulty.Easy:
                    BreakPoint = 20;

                    break;
            }
        }

        if (Microgame._DEBUG_Difficulty == MicrogameInstance.Difficulty.Medium)
        {
            switch (State)
            {
                case Difficulty.Medium:
                    BreakPoint = 15;

                    break;
            }
        }

        if (Microgame._DEBUG_Difficulty == MicrogameInstance.Difficulty.Hard)
        {
            switch (State)
            {

                case Difficulty.Hard:
                    BreakPoint = 10;

                    break;
            }
        }



    }
    void Update()
    {
        if (WinPoint >= 8)
        {
            WinRound();
        }


        if (Lose==true)
        {
            LoseRound();
        
        }
    }




    void WinRound()
    { 
        WinEnd.SetActive(true);
        RetryB.SetActive(true);
    }

    void LoseRound()
    { 
        LoseEnd.SetActive(true);
        RetryB.SetActive(true);
    }
}
