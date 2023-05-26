using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class third : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Alarm");
    }
}
