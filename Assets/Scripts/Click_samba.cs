using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class click_samba : MonoBehaviour
{
    public static int money
    {
        get => _money;
        set
        {
            _money = value;
            PlayerPrefs.SetInt("money", _money);
        }
    }

    private static int _money;
    public static int rate = 2000;
    public Button buyButton_samba;
    public GameObject buyButton_gm_samba;
    public Image buyButtonImage_samba;
    private void Start()
    {
        money = PlayerPrefs.GetInt("money", 0);
        rate = PlayerPrefs.GetInt("rate", 2000);
        int buttonenabled_samba = PlayerPrefs.GetInt("ButtonUnlocked_Samba", -1);
        if (buttonenabled_samba != -1)
        {
            buyButton_samba.enabled = true;
            buyButtonImage_samba.raycastTarget = true;
            buyButton_gm_samba.SetActive(true);
        }
        else
        {
            buyButton_samba.enabled = false;
            buyButtonImage_samba.raycastTarget = false;
            buyButton_gm_samba.SetActive(false);

        }

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
            rate += 2000;
            PlayerPrefs.SetInt("money", money);
            PlayerPrefs.SetInt("rate", rate);
        }
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