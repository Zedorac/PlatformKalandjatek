using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWizard : BaseClass
{
    public BaseWizard(){
        ClassName = "Wizard";
        Health = 9;
        Strength = 2;
        Intelligence = 5;
        Agility = 3;
        Damage = Intelligence * 5;
        Shooting = true;
    }
}
