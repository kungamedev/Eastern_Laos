using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuStart : MonoBehaviour
{
    public Button btnstart;
    // Start is called before the first frame update
    void Start()
    {
        btnstart.onClick.AddListener(taskonclick);
    }
    void taskonclick()
    {
        Application.LoadLevel("CreateCharaters");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
