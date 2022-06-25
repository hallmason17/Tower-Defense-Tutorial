using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColdDebuff : Debuff
{
    public ColdDebuff(Enemy enemy): base(enemy)
    {

    }
    public override void Update()
    {
        enemy.SetSpeed(5);
        base.Update();
    }
}
