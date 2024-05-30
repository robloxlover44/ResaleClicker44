using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class movegameobject : MonoBehaviour
{
    public Animator animator;
    public click _click;
    public int _cost;
    public GameObject soldout;
    public GameObject locked;
    public GameObject cost;
    public Image nextImage;
    public Sprite nextSprite;
    public Button nextButton;
    public GameObject nextPrice;
    public int ItemID;
    public Button _button;

    public void OnClick()
    {

        if (_click.BuyItem(_cost))
        {
            animator.SetBool("Disabled", true);
            soldout.SetActive(true);
            locked.SetActive(false);
            cost.SetActive(false);
            nextImage.sprite = nextSprite;
            nextButton.enabled = true;
            nextPrice.SetActive(true);
            PlayerPrefs.SetInt("ButtonUnlocked", 1);
            _button.enabled = false;
            
        }
        
    }
}
