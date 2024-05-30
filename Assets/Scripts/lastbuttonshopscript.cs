using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lastbuttonshopscript : MonoBehaviour
{
    public Animator animator;
    public click _click;
    public int _cost;
    public GameObject soldout;
    public GameObject cost;
    public int ItemID;
    public Button _button;
    public itembutton sneakers;

    public void OnClick()
    {

        if (_click.BuyItem(_cost))
        {
            animator.SetBool("Disabled", true);
            soldout.SetActive(true);
            cost.SetActive(false);
            switch (sneakers)
            {
                case itembutton.superstar:
                    PlayerPrefs.SetInt("ButtonUnlocked_Superstar", 1);
                    break;
                case itembutton.samba:
                    PlayerPrefs.SetInt("ButtonUnlocked_Samba", 1);
                    break;
                case itembutton.niteball:
                    PlayerPrefs.SetInt("ButtonUnlocked_Niteball", 1);
                    break;
                case itembutton.yezzy:
                    PlayerPrefs.SetInt("ButtonUnlocked_Yeezy", 1);
                    break;
            }
            _button.enabled = false;

        }

    }
    public enum itembutton
    {
        superstar, samba, niteball, yezzy
    }
}