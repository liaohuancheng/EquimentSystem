using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
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

    public Character(string name, string description, int strength, int intellect, int agility, int stamina, int hp, int mp)
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

    public void Damage(Character c,int AttackLevel,int damage)
    {
        c.BeDamaged(AttackLevel,damage);
    }

    private void BeDamaged(int AttackLevel,int damage)
    {
        if (AttackLevel + RandomManager.Instance.D20() > this.AC)
            hp -= damage;
    }
}
