using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPage : MonoBehaviour
{
    public void CreateAccount(){
        SceneManager.LoadScene(1);
    }

    public void LoginPage(){
        SceneManager.LoadScene(2);
    }

    
    

}
