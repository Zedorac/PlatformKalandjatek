using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRanger : BaseClass
{
    public BaseRanger(){
        ClassName = "Ranger";
        Health = 8;
        Strength = 3;
        Intelligence = 2;
        Agility = 5;
        Damage = Agility * 5;
        Shooting = true;
    }
}
