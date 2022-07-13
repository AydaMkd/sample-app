using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dragAndmoveItems : MonoBehaviour
{
    
   public float changerate = 0.05f;
     private Vector3 lastTransformPos;
    
    
    
   
    void Start()
    {   
        
        lastTransformPos = transform.position;
       
    }
   
   public void OnMouseDrag() {
       
       
         string objectName = gameObject.name;
        
        
          float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
         transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen ));
         
            var diffVector = transform.position - lastTransformPos;
         if (diffVector.magnitude >= changerate)
         {
             lastTransformPos = transform.position;
             Debug.Log("Player moved" + objectName + "position at :" + transform.position);
         }
             
         
    }
}
