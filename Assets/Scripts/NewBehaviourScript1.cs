using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class last_button_scriprt : MonoBehaviour
{
    public Animator animator;
    public click _click;
    public int _cost;
    public GameObject soldout;
    public GameObject cost;

    public void OnClick()
    {

        if (_click.BuyItem(_cost))
        {
            animator.SetBool("Pressed", true);
            soldout.SetActive(true);
            cost.SetActive(false);


        }

    }
}
