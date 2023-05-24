using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToAlarmScene()
    {
        SceneManager.LoadScene("Alarm");
    }

    public void GoToStudyGroup1()
    {
        SceneManager.LoadScene("StudyGroup1");
    }

    public void GoToStudyGroup2()
    {
        SceneManager.LoadScene("StudyGroup2");
    }

    public void GoToASearch()
    {
        SceneManager.LoadScene("ASearch");
    }

    public void GoToBSearch()
    {
        SceneManager.LoadScene("BSearch");
    }


}
