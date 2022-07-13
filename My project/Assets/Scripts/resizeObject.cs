

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resizeObject : MonoBehaviour
{   
     
    void Start()
    {
        
    }
     void Update(){
        string objectName = gameObject.name;
       if (Input.GetAxis("Mouse ScrollWheel") < 0) {
      transform.localScale = transform.localScale + new Vector3(-7f,-7f,-7f) * Time.deltaTime; 
      Debug.Log("player resized " + objectName);
     } 
      if (Input.GetAxis("Mouse ScrollWheel") > 0) {
      transform.localScale = transform.localScale + new Vector3(7f,7f,7f) * Time.deltaTime;
       Debug.Log("player resized " + objectName);  
 
}
    

   

}     
       
}


