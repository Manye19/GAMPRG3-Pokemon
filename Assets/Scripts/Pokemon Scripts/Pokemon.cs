using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pokemon
{
    SO_Pokemon SO_base;
    int level;

    public SO_Pokemon Base
    {
        get { return SO_base; }
    }

    public int Level
    {
        get { return level; }
    }

    public Pokemon(SO_Pokemon p_base, int p_level)
    {
        SO_base = p_base;
        level = p_level;
    }

    public int Attack
    {
        get { return Mathf.FloorToInt((SO_base.Attack * level) / 100f) + 5; }
    }
    public int Defense
    {
        get { return Mathf.FloorToInt((SO_base.Defense * level) / 100f) + 5; }
    }
    public int SpAttack
    {
        get { return Mathf.FloorToInt((SO_base.SpAttack * level) / 100f) + 5; }
    }
    public int SpDefense
    {
        get { return Mathf.FloorToInt((SO_base.SpDefense * level) / 100f) + 5; }
    }

    public int Speed
    {
        get { return Mathf.FloorToInt((SO_base.Speed * level) / 100f) + 5; }
    }
    public int MaxHP
    {
        get { return Mathf.FloorToInt((SO_base.MaxHp * level) / 100f) + 10; }
    }
}
