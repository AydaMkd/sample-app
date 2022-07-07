using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logout : MonoBehaviour
{
    
    public void endsession(){
       Debug.Log("Game saved") ;
       DBmanager.LogOut();
       UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    
    }
}
