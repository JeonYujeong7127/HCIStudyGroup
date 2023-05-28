using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NumberScript : MonoBehaviour
{
    public Text ScriptTxt;

    int Number = 2;
    void Start()
    {
        ScriptTxt.text = "2";

    }
    public void NumberPlus()
    {
        Number += 1;
        ScriptTxt.text = Number.ToString();
    }
    public void NumberMinus()
    {
        if(Number!=0)
            Number -= 1;
        ScriptTxt.text = Number.ToString();
    }
}
