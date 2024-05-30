using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class click : MonoBehaviour
{
    public static int money
    {
        get => _money;
        set 
        { 
            _money = value;
            PlayerPrefs.SetInt("money",_money);
        }
    }

    private static int _money;
    public static int rate = 1000;

    public Text moneyText;

    private void Start()
    {
        money = PlayerPrefs.GetInt("money", 0);
        rate = PlayerPrefs.GetInt("rate", 1000);
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
            rate += 1000;
            PlayerPrefs.SetInt("money", money);
            PlayerPrefs.SetInt("rate", rate);
        }
    }

    public void Update()
    {
        moneyText.text = money + "$";
    }

    public bool BuyItem(int itemCost)
    {
        if (money >= itemCost)
        {
            money -= itemCost;
            Debug.Log("Item bought successfully!");
            return true;
        }
        else
        {
            Debug.Log("Not enough money to buy this item!");
            return false;
        }
    }
    
    
    
    public static void SaveData(string money, string value)
    {
        PlayerPrefs.SetString(money, value);
        PlayerPrefs.Save();
    }

    // Load data from PlayerPrefs
    public static string LoadData(string money)
    {
        if (PlayerPrefs.HasKey(money))
        {
            return PlayerPrefs.GetString(money);
        }
        else
        {
            return null;
        }
    }

    // Clear data from PlayerPrefs
    public static void ClearData(string money)
    {
        PlayerPrefs.DeleteKey(money);
        PlayerPrefs.Save();
    }

}