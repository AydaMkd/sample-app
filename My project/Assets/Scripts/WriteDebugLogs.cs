using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
public class WriteDebugLogs : MonoBehaviour
{    
    
    string filename = "";

     void OnEnable() {
        
         Application.logMessageReceived  += Log; 

    }
     void OnDisable() {
        
         Application.logMessageReceived  -= Log; 
        
    }
    // Start is called before the first frame update
    void Start()
    {
        filename = Application.dataPath + "/LogFile.text";
       
    }
    public void Log(string logString, string stackTrace, LogType type)
    {
        TextWriter tw = new StreamWriter(filename, true);
        tw.WriteLine("[" + System.DateTime.Now + "]" + logString);
        tw.Close();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
