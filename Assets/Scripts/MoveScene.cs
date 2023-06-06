using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MoveScene : MonoBehaviour
{
    public GameObject in_id;
    public GameObject in_pwd;
    public GameObject information;
    public GameObject error;
    public string check_id;
    public string check_pwd;
    public GameObject group_name;
    public GameObject group_goal;
    public GameObject limit_num;

    // Start is called before the first frame update
    public void GoToLogin()
    {
        SceneManager.LoadScene("Login");
    }

    public void GoToSignUp()
    {
        SceneManager.LoadScene("SignUp");
    }

    public void GoToMain()
    {
        information = GameObject.Find("Information");
        check_id = information.GetComponent<DontDestroyOnLoad>().id;
        check_pwd = information.GetComponent<DontDestroyOnLoad>().pwd;
        TMP_InputField id_ = in_id.GetComponent<TMP_InputField>();
        TMP_InputField pwd_ = in_pwd.GetComponent<TMP_InputField>();
        if(id_.text==check_id && pwd_.text == check_pwd)
        {
            SceneManager.LoadScene("Main");
        }
        else
        {
            error.SetActive(true);
        }
    }

    public void GoToMain2()
    {
        SceneManager.LoadScene("Main");
    }

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

    public void GoToGenerationGroup()
    {
        SceneManager.LoadScene("GenerationGroup");
    }

    public void GoToSearch()
    {
        SceneManager.LoadScene("Search");
    }

    public void GoToAlarmSetting()
    {
        information = GameObject.Find("Information");
        information.GetComponent<DontDestroyOnLoad>().gname = group_name.GetComponent<TMP_InputField>().text; ;
        information.GetComponent<DontDestroyOnLoad>().g_goal = group_goal.GetComponent<TMP_InputField>().text;
        information.GetComponent<DontDestroyOnLoad>().gnum = limit_num.GetComponent<Text>().text;
        SceneManager.LoadScene("AlarmSetting");
    }

    public void GoToASearch()
    {
        SceneManager.LoadScene("ASearch");
    }

    public void GoToBSearch()
    {
        SceneManager.LoadScene("BSearch");
    }
    public void GoToAlarm()
    {
        SceneManager.LoadScene("AddAlarm");
    }
    public void GoToTimeSetting()
    {
        SceneManager.LoadScene("TimeSetting");
    }
    public void GoToAlarmSettingComplete()
    {
        SceneManager.LoadScene("AlarmSettingComplete");
    }
}
