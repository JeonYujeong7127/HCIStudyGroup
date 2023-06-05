using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Chat : MonoBehaviour
{
    public TMP_Text chatText = null;
    public GameObject inputField = null;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Chatting()
    {
        TMP_InputField inputText = inputField.GetComponent<TMP_InputField>();
        chatText.SetText(chatText.GetParsedText().Split("\n")[1] + "\n" + inputText.text);
        inputText.SetTextWithoutNotify("");
    }
}
