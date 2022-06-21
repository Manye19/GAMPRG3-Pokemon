using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon/Create new Pokemon")]
public class SO_Pokemon : ScriptableObject
{    
    public string name;
    
    [TextArea]
    public string description;

    [Header("Pokemon Sprites")]
    public Sprite frontSprite;
    public Sprite backSprite;

    [Header("Pokemon Types")]
    public PokemonType type1;
    public PokemonType type2;

    [Header("Base Stats")]
    public int maxHp;
    public int attack;
    public int defense;
    public int spAttack;
    public int spDefense;
    public int speed;

    public List<LearnableMove> learnableMoves;

    public string Name { get { return name; } }
    public string Description { get { return description; } }
    // Stats
    public int MaxHp { get { return maxHp; } }
    public int Attack { get { return attack; } }
    public int Defense { get { return defense; } }
    public int SpAttack { get { return spAttack; } }
    public int SpDefense { get { return spDefense; } }
    public int Speed { get { return speed; } }

    public List<LearnableMove> LearnableMoves
    {
        get { return learnableMoves; }
    }
}

[System.Serializable]
public class LearnableMove
{
    public SO_Moves moveBase;
    public int level;

    public SO_Moves Base
    {
        get { return moveBase; }
    }
    public int Level
    {
        get { return level; }
    }
}

public enum PokemonType
{
    None,
    Fire,
    Grass,
    Normal,
    Water
}