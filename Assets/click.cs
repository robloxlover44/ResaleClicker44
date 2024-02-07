using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click : MonoBehaviour
{
    [SerializeField] int money;
    public Text Dollaz;
    public void Onclick()
    {
        money++;
    }
    // Update is called once per frame
    void Update()
    {
        Dollaz.text = money.ToString();
    }
}
