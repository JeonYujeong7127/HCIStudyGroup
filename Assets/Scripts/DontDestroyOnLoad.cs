using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DontDestroyOnLoad : MonoBehaviour
{
    public GameObject input_id = null;
    public GameObject input_pwd = null;
    public GameObject input_name = null;

    public string id = "";
    public string pwd = "";
    public string iname = "";

    public string gname = "";
    public string g_goal = "";
    public string gnum;
    private static DontDestroyOnLoad s_Instance = null;
    // Start is called before the first frame update
    private void Awake()
    {
        if (s_Instance)
        {
            DestroyImmediate(this.gameObject);
            return;
        }

        s_Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void Inform()
    {
        if (input_id != null)
            id = input_id.GetComponent<TMP_InputField>().text;
        if (input_pwd != null)
            pwd = input_pwd.GetComponent<TMP_InputField>().text;
        if (input_name != null)
            iname = input_name.GetComponent<TMP_InputField>().text;
    }
}
