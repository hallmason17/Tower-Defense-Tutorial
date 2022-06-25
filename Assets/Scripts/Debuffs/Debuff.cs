using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Debuff
{
    protected Enemy enemy;

    public Debuff(Enemy enemy)
    {
        this.enemy = enemy;
    }

    public virtual void Update()
    {

    }
}
