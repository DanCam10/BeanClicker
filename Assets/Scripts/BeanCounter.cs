using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeanCounter : MonoBehaviour
{
    public Text BeansCountText;
    public Text BeansPerClickText;

    void OnMouseDown()
    {
        Global.numBeans += Global.beansPerClick;
        BeansCountText.text = "Beans: " + Global.numBeans.ToString();
    }

    public void Upgrade1()
    {
        //if (Global.numBeans >= Global.upgrade1Cost)
        //{
        //    Global.beansPerClick += Global.upgrade1Increase;
        //    Global.numBeans -= Global.upgrade1Cost;
        //    BeansCountText.text = "Beans: " + Global.numBeans.ToString();
        //    BeansPerClickText.text = "BPC: " + Global.beansPerClick.ToString();
        //}
        UpgradeHelper(Global.upgrade1Cost, Global.upgrade1Increase);
    }

    public void Upgrade2()
    {
        if (Global.numBeans >= Global.upgrade2Cost)
        {
            Global.beansPerClick += Global.upgrade2Increase;
            Global.numBeans -= Global.upgrade2Cost;
            BeansCountText.text = "Beans: " + Global.numBeans.ToString();
            BeansPerClickText.text = "BPC: " + Global.beansPerClick.ToString();
        }
    }

    void UpgradeHelper(int cost, int increase)
    {
        if (Global.numBeans >= cost)
        {
            Global.beansPerClick += increase;
            Global.numBeans -= cost;
            BeansCountText.text = "Beans: " + Global.numBeans.ToString();
            BeansPerClickText.text = "BPC: " + Global.beansPerClick.ToString();
        }
    }
}
