using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteprogress : MonoBehaviour
{
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }
}
