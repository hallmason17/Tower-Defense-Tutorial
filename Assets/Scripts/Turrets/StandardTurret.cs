using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardTurret : Turret
{
    public override Debuff GetDebuff()
    {
        Enemy targ = target.GetComponent<Enemy>();
        return new StandardDebuff(targ);
    }
}
