using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int playerMoney = 100;
    public Text moneyText;

    private void Start()
    {
        UpdateMoneyText();
    }

    public void BuyItem(int itemCost)
    {
        if (playerMoney >= itemCost)
        {
            playerMoney -= itemCost;
            UpdateMoneyText();
            Debug.Log("Item bought successfully!");
        }
        else
        {
            Debug.Log("Not enough money to buy this item!");
        }
    }

    private void UpdateMoneyText()
    {
        moneyText.text = "Money: $" + playerMoney.ToString();
    }
}
