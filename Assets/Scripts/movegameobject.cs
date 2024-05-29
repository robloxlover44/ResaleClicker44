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
    public Image nextSprite;
    public GameObject nextButton;
    public GameObject nextPrice;
    public GameObject nextShoe;

    public void OnClick()
    {

        if (_click.BuyItem(_cost))
        {
            animator.SetBool("Disabled", false);
            soldout.SetActive(true);
            locked.SetActive(false);
            cost.SetActive(false);
            nextButton.SetActive(true);
            nextPrice.SetActive(true);
            
        }
        
    }
}
