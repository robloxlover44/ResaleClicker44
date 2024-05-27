using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class click : MonoBehaviour
{
    public static int money;
    public static int rate = 1;

    public Text moneyText;

    private void Start()
    {
        money = PlayerPrefs.GetInt("money", 0);
        rate = PlayerPrefs.GetInt("rate", 1);
    }

    public void Click()
    {
        money += rate;
        PlayerPrefs.SetInt("money", money);
    }
    public void UpgradeClick()
    {
        if (money >= 15)
        {
            money -= 15;
            rate += 1;
            PlayerPrefs.SetInt("money", money);
            PlayerPrefs.SetInt("rate", rate);
        }
    }

    public void Update()
    {
        moneyText.text = money + "$";
    }

    public void BuyItem(int itemCost)
    {
        if (money >= itemCost)
        {
            money -= itemCost;
            Debug.Log("Item bought successfully!");
        }
        else
        {
            Debug.Log("Not enough money to buy this item!");
        }
    }

}