using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Pokemon/Create new move")]
public class SO_Moves : ScriptableObject
{
    public string name;

    [TextArea]
    public string description;

    public PokemonType type;
    public int power;
    public int accuracy;
    public int pp;

    public string Name { get { return name; } }
    public string Description { get { return description; } }
    public PokemonType Type { get { return type; } }
    public int Power { get { return power; } }
    public int Accuracy { get { return accuracy; } }
    public int PP { get { return pp; } }
}