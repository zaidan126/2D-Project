using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class exitmenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void exit()
    {
       // EditorApplication.ExitPlaymode();
        Application.Quit();
    }
}
