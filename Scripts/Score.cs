using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int scoreBlue;
    public int scoreRed;


    public static Score instance;
    public void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void Poin(string sideWallName)
    {
        if (sideWallName == "Left") scoreRed += 10;
        else scoreBlue += 10;
    }
}

//Tidak di pakai