using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass : MonoBehaviour
{
    private int health;
    private int strength;
    private int intelligence;
    private int agility;
    private int damage;
    private bool shoot;

    private string className;

    public string ClassName{
        get {return className;}
        set {className = value;}
    }

    public int Health{
        get {return health;}
        set {health = value;}
    }

    public int Strength{
        get {return strength;}
        set {strength = value;}
    }

    public int Intelligence{
        get {return intelligence;}
        set {intelligence = value;}
    }

    public int Agility{
        get {return agility;}
        set {agility = value;}
    }

    public int Damage{
        get {return damage;}
        set {damage = value;}
    }

    public bool Shooting{
        get {return shoot;}
        set {shoot = value;}
    }
}
