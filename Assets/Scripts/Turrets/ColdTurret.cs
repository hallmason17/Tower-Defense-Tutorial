using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColdTurret : Turret
{
    public override Debuff GetDebuff()
    {
        Enemy targ = target.GetComponent<Enemy>();
        return new ColdDebuff(targ);
    }
}
