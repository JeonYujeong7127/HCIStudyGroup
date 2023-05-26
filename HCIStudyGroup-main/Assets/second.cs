using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class second : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("ASearch");
    }

}
