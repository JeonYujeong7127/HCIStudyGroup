using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class File : MonoBehaviour
{
    public GameObject fileButton;
    public GameObject checkButton;
    public GameObject fileImg;
    public GameObject newImg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void uploadComplete()
    {
        Invoke("removeBtn", 3f);
    }

    public void removeBtn()
    {
        fileButton.SetActive(false);
        checkButton.SetActive(false);
        fileImg.SetActive(true);
        newImg.SetActive(true);

    }
}
