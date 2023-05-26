using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupScript : MonoBehaviour
{
    public void Button()
    {
        if (gameObject.activeSelf == true)
        {
            gameObject.SetActive(false);
        }
        if (gameObject.activeSelf == false)
        {
            gameObject.SetActive(true);
        }
    }

}
