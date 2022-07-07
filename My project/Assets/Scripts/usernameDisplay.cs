using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class usernameDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public Text userdisplay;
   private void Start()
    {
       if (DBmanager.loggedIn) {
        userdisplay.text = "Hello "+ DBmanager.username;
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
