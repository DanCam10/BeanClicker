using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameButton : MonoBehaviour
{
    public void SetupNewGame()
    {
        //General Beans
         Global.numBeans = 0;
         Global.beansPerClick = 1;
         Global.beansPerSec = 0;
         Global.hasStartedGame = false;

        //Upgrade 1
         Global.upgrade1Increase = 1;
         Global.upgrade1Cost = 50;
         Global.upgrade1CostInc = 1;
         Global.upgrade1MaxCost = 100;

        //Upgrade 2
         Global.upgrade2Increase = 5;
         Global.upgrade2Cost = 500;
         Global.upgrade2CostInc = 5;
         Global.upgrade2MaxCost = 750;

        //Upgrade 3
         Global.upgrade3Increase = 20;
         Global.upgrade3Cost = 2500;
         Global.upgrade3CostInc = 50;
         Global.upgrade3MaxCost = 10000;

        //Upgrade 4
         Global.upgrade4Increase = 50;
         Global.upgrade4Cost = 10000;
         Global.upgrade4CostInc = 100;
         Global.upgrade4MaxCost = 30000;

        //Upgrade 5
         Global.upgrade5Increase = 100;
         Global.upgrade5Cost = 50000;
         Global.upgrade5CostInc = 500;
         Global.upgrade5MaxCost = 150000;

        //Upgrade 6
         Global.upgrade6Increase = 1;
         Global.upgrade6Cost = 250;
         Global.upgrade6CostInc = 5;
         Global.upgrade6MaxCost = 500;

        //Upgrade 7
         Global.upgrade7Increase = 5;
         Global.upgrade7Cost = 1000;
         Global.upgrade7CostInc = 20;
         Global.upgrade7MaxCost = 2000;

        //Upgrade 8
         Global.upgrade8Increase = 20;
         Global.upgrade8Cost = 5000;
         Global.upgrade8CostInc = 100;
         Global.upgrade8MaxCost = 10000;

        //Upgrade 9
         Global.upgrade9Increase = 50;
         Global.upgrade9Cost = 20000;
         Global.upgrade9CostInc = 200;
         Global.upgrade9MaxCost = 30000;

        //Upgrade 10
         Global.upgrade10Increase = 100;
         Global.upgrade10Cost = 100000;
         Global.upgrade10CostInc = 1000;
         Global.upgrade10MaxCost = 150000;

        SceneManager.LoadScene("Main");
    }
}
