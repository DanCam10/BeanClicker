using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeanCounter : MonoBehaviour
{
    public Text BeansCountText;
    public Text BeansPerClickText;

    public Text Upgrade1Text;
    public Text Upgrade2Text;
    public Text Upgrade3Text;
    public Text Upgrade4Text;
    public Text Upgrade5Text;

    void OnMouseDown()
    {
        Global.numBeans += Global.beansPerClick;
        BeansCountText.text = "Beans: " + Global.numBeans.ToString();
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
                Upgrade1Text.text = "Beans Per Click +" + Global.upgrade1Increase + "\nCosts: " + Global.upgrade1Cost + " Beans";
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
                Upgrade2Text.text = "Beans Per Click +" + Global.upgrade2Increase + "\nCosts: " + Global.upgrade2Cost + " Beans";
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
                Upgrade3Text.text = "Beans Per Click +" + Global.upgrade3Increase + "\nCosts: " + Global.upgrade3Cost + " Beans";
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
                Upgrade4Text.text = "Beans Per Click +" + Global.upgrade4Increase + "\nCosts: " + Global.upgrade4Cost + " Beans";
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
                Upgrade5Text.text = "Beans Per Click +" + Global.upgrade5Increase + "\nCosts: " + Global.upgrade5Cost + " Beans";
            }
        }
    }

    void UpgradeHelper(int cost, int increase, int costInc, int maxCost, Text text)
    {
        Global.beansPerClick += increase;
        Global.numBeans -= cost;
        BeansCountText.text = "Beans: " + Global.numBeans.ToString();
        BeansPerClickText.text = "BPC: " + Global.beansPerClick.ToString();
    }
}
