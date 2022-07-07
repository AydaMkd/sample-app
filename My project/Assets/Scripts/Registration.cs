using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Registration : MonoBehaviour
{   

    public InputField usernameField;
    public InputField passwordField;
    // public InputField cpasswordField;
    public Button submitButton;
    public void CallRegister(){
        StartCoroutine(Register());
    }
    IEnumerator Register()
    { 
          WWWForm form = new WWWForm();
        
        form.AddField("username", usernameField.text);
        form.AddField("password", passwordField.text);
        //  form.AddField("cpassword", cpasswordField.text);
        WWW wwww = new WWW("https://first-page345.herokuapp.com/", form);
        yield return wwww;
       
        if(wwww.text == "0")
        {
            Debug.Log("Account created successfully");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else 
        {
            Debug.Log("Account creation failed. Error #" + wwww.text);
        }
    }
    public void VerifyInput(){
        submitButton.interactable = (usernameField.text.Length >= 4 && passwordField.text.Length >= 4);
    }

}
