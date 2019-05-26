using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomManager 
{
    System.Random random = new System.Random(DateTime.Now.Second*DateTime.Now.Minute/DateTime.Now.Year*DateTime.Now.Month);

    private static RandomManager _instance;

    public static RandomManager Instance {

        get {
            if (_instance == null) 
                _instance = new RandomManager();
            return _instance;
        }

        set => _instance = value;
    }

    public int D100()
    {
        return random.Next(1, 100);
    }

    public int D20() {
        return random.Next(1, 20);
    }



    public int D12()
    {
        return random.Next(1, 12);
    }

    public int D8()
    {
        return random.Next(1, 8);
    }

    public int D4()
    {
        return random.Next(1, 4);
    }
}
