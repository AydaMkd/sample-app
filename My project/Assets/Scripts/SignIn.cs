using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignIn : MonoBehaviour
{
 

    public InputField usernameField;
    public InputField passwordField;
    public Button submitButton;

    public void CallLogin(){
        StartCoroutine(Login());
    }
    IEnumerator Login()
    { 
          WWWForm form = new WWWForm();
        
        form.AddField("username", usernameField.text);
        form.AddField("password", passwordField.text);
        //  form.AddField("cpassword", cpasswordField.text);
        WWW wwww = new WWW("https://login-un.herokuapp.com/", form);
        yield return wwww;
        Debug.Log(wwww.text);
        if(wwww.text == "0")
        {
            DBmanager.username = usernameField.text;
            // DBmanager.userlogs= wwww.text.Split('\t')[1]
            Debug.Log("user logged in");
            UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        }
        else 
        {
            Debug.Log("Couldn't log in. Error #" + wwww.text);
        }
}
 public void VerifyInput(){
        submitButton.interactable = (usernameField.text.Length >= 4 && passwordField.text.Length >= 4);
    }
}