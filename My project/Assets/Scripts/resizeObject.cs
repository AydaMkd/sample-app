

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resizeObject : MonoBehaviour
{   
     
    void Start()
    {
        
    }
     void OnMouseDown(){
      if (Input.GetMouseButtonDown(0))
      transform.localScale = transform.localScale + new Vector3(7f,7f,7f) * Time.deltaTime;  
    
 
}
    //  private void OnMouseUp() {
      
    // }

   

}     
       
  