using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    //General Beans
    public int numBeans;
    public int beansPerClick;
    public int beansPerSec;
    public bool hasStartedGame;

    //Upgrade 1
    public int upgrade1Increase;
    public int upgrade1Cost;
    public int upgrade1CostInc;
    public int upgrade1MaxCost;

    //Upgrade 2
    public int upgrade2Increase;
    public int upgrade2Cost;
    public int upgrade2CostInc;
    public int upgrade2MaxCost;

    //Upgrade 3
    public int upgrade3Increase;
    public int upgrade3Cost;
    public int upgrade3CostInc;
    public int upgrade3MaxCost;

    //Upgrade 4
    public int upgrade4Increase;
    public int upgrade4Cost;
    public int upgrade4CostInc;
    public int upgrade4MaxCost;

    //Upgrade 5
    public int upgrade5Increase;
    public int upgrade5Cost;
    public int upgrade5CostInc;
    public int upgrade5MaxCost;

    //Upgrade 6
    public int upgrade6Increase;
    public int upgrade6Cost;
    public int upgrade6CostInc;
    public int upgrade6MaxCost;

    //Upgrade 7
    public int upgrade7Increase;
    public int upgrade7Cost;
    public int upgrade7CostInc;
    public int upgrade7MaxCost;

    //Upgrade 8
    public int upgrade8Increase;
    public int upgrade8Cost;
    public int upgrade8CostInc;
    public int upgrade8MaxCost;

    //Upgrade 9
    public int upgrade9Increase;
    public int upgrade9Cost;
    public int upgrade9CostInc;
    public int upgrade9MaxCost;

    //Upgrade 10
    public int upgrade10Increase;
    public int upgrade10Cost;
    public int upgrade10CostInc;
    public int upgrade10MaxCost;

    public PlayerData()
    {
        //General Beans
        numBeans = Global.numBeans;
        beansPerClick = Global.beansPerClick;
        beansPerSec = Global.beansPerSec;
        hasStartedGame = true;

        //Upgrade 1
        upgrade1Increase = Global.upgrade1Increase;
        upgrade1Cost = Global.upgrade1Cost;
        upgrade1CostInc = Global.upgrade1CostInc;
        upgrade1MaxCost = Global.upgrade1MaxCost;

        //Upgrade 2
        upgrade2Increase = Global.upgrade2Increase;
        upgrade2Cost = Global.upgrade2Cost;
        upgrade2CostInc = Global.upgrade2CostInc;
        upgrade2MaxCost = Global.upgrade2MaxCost;

        //Upgrade 3
        upgrade3Increase = Global.upgrade3Increase;
        upgrade3Cost = Global.upgrade3Cost;
        upgrade3CostInc = Global.upgrade3CostInc;
        upgrade3MaxCost = Global.upgrade3MaxCost;

        //Upgrade 4
        upgrade4Increase = Global.upgrade4Increase;
        upgrade4Cost = Global.upgrade4Cost;
        upgrade4CostInc = Global.upgrade4CostInc;
        upgrade4MaxCost = Global.upgrade4MaxCost;

        //Upgrade 5
        upgrade5Increase = Global.upgrade5Increase;
        upgrade5Cost = Global.upgrade5Cost;
        upgrade5CostInc = Global.upgrade5CostInc;
        upgrade5MaxCost = Global.upgrade5MaxCost;

        //Upgrade 6
        upgrade6Increase = Global.upgrade6Increase;
        upgrade6Cost = Global.upgrade6Cost;
        upgrade6CostInc = Global.upgrade6CostInc;
        upgrade6MaxCost = Global.upgrade6MaxCost;

        //Upgrade 7
        upgrade7Increase = Global.upgrade7Increase;
        upgrade7Cost = Global.upgrade7Cost;
        upgrade7CostInc = Global.upgrade7CostInc;
        upgrade7MaxCost = Global.upgrade7MaxCost;

        //Upgrade 8
        upgrade8Increase = Global.upgrade8Increase;
        upgrade8Cost = Global.upgrade8Cost;
        upgrade8CostInc = Global.upgrade8CostInc;
        upgrade8MaxCost = Global.upgrade8MaxCost;

        //Upgrade 9
        upgrade9Increase = Global.upgrade9Increase;
        upgrade9Cost = Global.upgrade9Cost;
        upgrade9CostInc = Global.upgrade9CostInc;
        upgrade9MaxCost = Global.upgrade9MaxCost;

        //Upgrade 10
        upgrade10Increase = Global.upgrade10Increase;
        upgrade10Cost = Global.upgrade10Cost;
        upgrade10CostInc = Global.upgrade10CostInc;
        upgrade10MaxCost = Global.upgrade10MaxCost;
    }
}
