using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public string name;
    public string description;
    public int AttackLevel;
    public int strength;
    public int intellect;
    public int agility;
    public int stamina;
    public int hp;
    public int mp;
    public int AC;
    private List<Item> items;//角色穿戴的装备
    private static Player instance;
    public float addStrength;
    public float addIntellect;
    public float addAgility;
    public float addStamina;
    public float addAc;

    public static Player Instance
    {
        get
        {
            return instance;
        }
    }

    public Player(string name, string description, int strength, int intellect, int agility, int stamina, int hp, int mp)
    {
        this.name = name;
        this.description = description;
        this.strength = strength;
        this.intellect = intellect;
        this.agility = agility;
        this.stamina = stamina;
        this.hp = hp;
        this.mp = mp;
    }

    

    void UpdateAdditionData()
    {
        throw new NotImplementedException();
    }

    void DeleteAdditionData()
    {
        throw new NotImplementedException();
    }
}
