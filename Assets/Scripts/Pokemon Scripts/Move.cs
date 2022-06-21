using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
    public SO_Moves SO_base { get; set; }
    public int PP { get; set; }

    public Move(SO_Moves p_base, int p_PP)
    {
        SO_base = p_base;
        PP = p_PP;
    }
}
