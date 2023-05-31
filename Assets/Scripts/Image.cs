using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image : MonoBehaviour
{
    public GameObject uploadImg;
    public GameObject uploadedImg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void upload()
    {
        Invoke("disappearImg", 2f);
    }

    public void disappearImg()
    {
        uploadImg.SetActive(false);
        uploadedImg.SetActive(true);
    }
}
