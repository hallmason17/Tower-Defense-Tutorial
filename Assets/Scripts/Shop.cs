using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint TurretGray;
    public TurretBlueprint TurretBlue;

    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret()
    {
        buildManager.SelectTurretToBuild(TurretGray);
    }

    public void SelectTurretBlue()
    {
        buildManager.SelectTurretToBuild(TurretBlue);
    }
}
