using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GroupInfo : MonoBehaviour
{
    public GameObject information;
    public GameObject group_name;
    public GameObject group_goal;
    public GameObject limit_num;
    // Start is called before the first frame update
    void Start()
    {
        information = GameObject.Find("Information");
        if (information.GetComponent<DontDestroyOnLoad>().gname != null)
        {
            group_name.GetComponent<TMP_InputField>().SetTextWithoutNotify(information.GetComponent<DontDestroyOnLoad>().gname);
        }
        if (information.GetComponent<DontDestroyOnLoad>().g_goal != null)
        {
            group_goal.GetComponent<TMP_InputField>().SetTextWithoutNotify(information.GetComponent<DontDestroyOnLoad>().g_goal);
        }
        if (information.GetComponent<DontDestroyOnLoad>().gnum != null)
        {
            limit_num.GetComponent<Text>().text = information.GetComponent<DontDestroyOnLoad>().gnum;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
