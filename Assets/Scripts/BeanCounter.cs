using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeanCounter : MonoBehaviour
{
    public Text BeansCountText;
    public Text BeansPerClickText;
    public Text BeansPerSecText;

    public Text Upgrade1Text;
    public Text Upgrade2Text;
    public Text Upgrade3Text;
    public Text Upgrade4Text;
    public Text Upgrade5Text;
    public Text Upgrade6Text;
    public Text Upgrade7Text;
    public Text Upgrade8Text;
    public Text Upgrade9Text;
    public Text Upgrade10Text;

    private void Start()
    {
        StartCoroutine(Time());
    }
    IEnumerator Time()
    {
        while (true)
        {
            SecondCounter();
            yield return new WaitForSeconds(1);
        }
    }

    void SecondCounter()
    {
        Global.numBeans += Global.beansPerSec;
        BeansCountText.text = "Beans: " + Global.numBeans.ToString("n0");
    }

    void OnMouseDown()
    {
        Global.numBeans += Global.beansPerClick;
        BeansCountText.text = "Beans: " + Global.numBeans.ToString("n0");
    }

    public void Upgrade1()
    {
        if (Global.upgrade1Cost < Global.upgrade1MaxCost && Global.numBeans >= Global.upgrade1Cost)
        {
            UpgradeHelper(Global.upgrade1Cost, Global.upgrade1Increase, Global.upgrade1CostInc, Global.upgrade1MaxCost, Upgrade1Text);
            Global.upgrade1Cost += Global.upgrade1CostInc;
            if (Global.upgrade1Cost >= Global.upgrade1MaxCost)
            {
                Upgrade1Text.text = "Upgrade Max";
            }
            else
            {
                Upgrade1Text.text = "Beans Per Click +" + Global.upgrade1Increase.ToString("n") + "\nCosts: " + Global.upgrade1Cost.ToString("n") + " Beans";
            }
        }
    }

    public void Upgrade2()
    {
        if (Global.upgrade2Cost < Global.upgrade2MaxCost && Global.numBeans >= Global.upgrade2Cost)
        {
            UpgradeHelper(Global.upgrade2Cost, Global.upgrade2Increase, Global.upgrade2CostInc, Global.upgrade2MaxCost, Upgrade2Text);
            Global.upgrade2Cost += Global.upgrade2CostInc;
            if (Global.upgrade2Cost >= Global.upgrade2MaxCost)
            {
                Upgrade2Text.text = "Upgrade Max";
            }
            else
            {
                Upgrade2Text.text = "Beans Per Click +" + Global.upgrade2Increase.ToString("n") + "\nCosts: " + Global.upgrade2Cost.ToString("n") + " Beans";
            }  
        }
    }

    public void Upgrade3()
    {
        if (Global.upgrade3Cost < Global.upgrade3MaxCost && Global.numBeans >= Global.upgrade3Cost)
        {
            UpgradeHelper(Global.upgrade3Cost, Global.upgrade3Increase, Global.upgrade3CostInc, Global.upgrade3MaxCost, Upgrade3Text);
            Global.upgrade3Cost += Global.upgrade3CostInc;
            if (Global.upgrade3Cost >= Global.upgrade3MaxCost)
            {
                Upgrade3Text.text = "Upgrade Max";
            }
            else
            {
                Upgrade3Text.text = "Beans Per Click +" + Global.upgrade3Increase.ToString("n") + "\nCosts: " + Global.upgrade3Cost.ToString("n") + " Beans";
            }
        }
    }

    public void Upgrade4()
    {
        if (Global.upgrade4Cost < Global.upgrade4MaxCost && Global.numBeans >= Global.upgrade4Cost)
        {
            UpgradeHelper(Global.upgrade4Cost, Global.upgrade4Increase, Global.upgrade4CostInc, Global.upgrade4MaxCost, Upgrade4Text);
            Global.upgrade4Cost += Global.upgrade4CostInc;
            if (Global.upgrade4Cost >= Global.upgrade4MaxCost)
            {
                Upgrade4Text.text = "Upgrade Max";
            }
            else
            {
                Upgrade4Text.text = "Beans Per Click +" + Global.upgrade4Increase.ToString("n") + "\nCosts: " + Global.upgrade4Cost.ToString("n") + " Beans";
            }
        }
    }

    public void Upgrade5()
    {
        if (Global.upgrade5Cost < Global.upgrade5MaxCost && Global.numBeans >= Global.upgrade5Cost)
        {
            UpgradeHelper(Global.upgrade5Cost, Global.upgrade5Increase, Global.upgrade5CostInc, Global.upgrade5MaxCost, Upgrade5Text);
            Global.upgrade5Cost += Global.upgrade5CostInc;
            if (Global.upgrade5Cost >= Global.upgrade5MaxCost)
            {
                Upgrade5Text.text = "Upgrade Max";
            }
            else
            {
                Upgrade5Text.text = "Beans Per Click +" + Global.upgrade5Increase.ToString("n") + "\nCosts: " + Global.upgrade5Cost.ToString("n") + " Beans";
            }
        }
    }

    public void Upgrade6()
    {
        if (Global.upgrade6Cost < Global.upgrade6MaxCost && Global.numBeans >= Global.upgrade6Cost)
        {
            UpgradeHelper(Global.upgrade6Cost, Global.upgrade6Increase, Global.upgrade6CostInc, Global.upgrade6MaxCost, Upgrade6Text, true);
            Global.upgrade6Cost += Global.upgrade6CostInc;
            if (Global.upgrade6Cost >= Global.upgrade6MaxCost)
            {
                Upgrade6Text.text = "Upgrade Max";
            }
            else
            {
                Upgrade6Text.text = "Beans Per Second +" + Global.upgrade6Increase.ToString("n") + "\nCosts: " + Global.upgrade6Cost.ToString("n") + " Beans";
            }
        }
    }

    public void Upgrade7()
    {
        if (Global.upgrade7Cost < Global.upgrade7MaxCost && Global.numBeans >= Global.upgrade7Cost)
        {
            UpgradeHelper(Global.upgrade7Cost, Global.upgrade7Increase, Global.upgrade7CostInc, Global.upgrade7MaxCost, Upgrade7Text, true);
            Global.upgrade7Cost += Global.upgrade7CostInc;
            if (Global.upgrade7Cost >= Global.upgrade7MaxCost)
            {
                Upgrade7Text.text = "Upgrade Max";
            }
            else
            {
                Upgrade7Text.text = "Beans Per Second +" + Global.upgrade7Increase.ToString("n") + "\nCosts: " + Global.upgrade7Cost.ToString("n") + " Beans";
            }
        }
    }

    public void Upgrade8()
    {
        if (Global.upgrade8Cost < Global.upgrade8MaxCost && Global.numBeans >= Global.upgrade8Cost)
        {
            UpgradeHelper(Global.upgrade8Cost, Global.upgrade8Increase, Global.upgrade8CostInc, Global.upgrade8MaxCost, Upgrade8Text, true);
            Global.upgrade8Cost += Global.upgrade8CostInc;
            if (Global.upgrade8Cost >= Global.upgrade8MaxCost)
            {
                Upgrade8Text.text = "Upgrade Max";
            }
            else
            {
                Upgrade8Text.text = "Beans Per Second +" + Global.upgrade8Increase.ToString("n") + "\nCosts: " + Global.upgrade8Cost.ToString("n") + " Beans";
            }
        }
    }

    public void Upgrade9()
    {
        if (Global.upgrade9Cost < Global.upgrade9MaxCost && Global.numBeans >= Global.upgrade9Cost)
        {
            UpgradeHelper(Global.upgrade9Cost, Global.upgrade9Increase, Global.upgrade9CostInc, Global.upgrade9MaxCost, Upgrade9Text, true);
            Global.upgrade9Cost += Global.upgrade9CostInc;
            if (Global.upgrade9Cost >= Global.upgrade9MaxCost)
            {
                Upgrade9Text.text = "Upgrade Max";
            }
            else
            {
                Upgrade9Text.text = "Beans Per Second +" + Global.upgrade9Increase.ToString("n") + "\nCosts: " + Global.upgrade9Cost.ToString("n") + " Beans";
            }
        }
    }

    public void Upgrade10()
    {
        if (Global.upgrade10Cost < Global.upgrade10MaxCost && Global.numBeans >= Global.upgrade10Cost)
        {
            UpgradeHelper(Global.upgrade10Cost, Global.upgrade10Increase, Global.upgrade10CostInc, Global.upgrade10MaxCost, Upgrade10Text, true);
            Global.upgrade10Cost += Global.upgrade10CostInc;
            if (Global.upgrade10Cost >= Global.upgrade10MaxCost)
            {
                Upgrade10Text.text = "Upgrade Max";
            }
            else
            {
                Upgrade10Text.text = "Beans Per Second +" + Global.upgrade10Increase.ToString("n") + "\nCosts: " + Global.upgrade10Cost.ToString("n") + " Beans";
            }
        }
    }

    void UpgradeHelper(int cost, int increase, int costInc, int maxCost, Text text, bool isPerSec = false)
    {
        if (isPerSec)
        {
            Global.beansPerSec += increase;
        }
        else
        {
            Global.beansPerClick += increase;
        }
        Global.numBeans -= cost;
        BeansCountText.text = "Beans: " + Global.numBeans.ToString("n");
        BeansPerClickText.text = "BPC: " + Global.beansPerClick.ToString("n");
        BeansPerSecText.text = "BPS: " + Global.beansPerSec.ToString("n");
    }
}
