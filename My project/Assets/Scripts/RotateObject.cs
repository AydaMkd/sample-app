using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateObject : MonoBehaviour
{
    
    public float changerate = 0.05f;
     private Vector3 lastTransformPos;
     private Vector3 rotposition;
    
    
   Rigidbody rb;
    void Start()
    {   
        rb = GetComponent<Rigidbody>();
        lastTransformPos = transform.position;
        rotposition = transform.eulerAngles; 
  
    }
    public void OnMouseDrag() {
       
        float rotSpeed = 20;
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y , -Camera.main.transform.position.z + transform.position.z);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
         string objectName = gameObject.name;
          var diffVector = transform.position - lastTransformPos;
         if (diffVector.magnitude >= changerate)
         {
             lastTransformPos = transform.position;
             Debug.Log("Player moved" + objectName + "position at :" + transform.position);
         }
        // rb.isKinematic = true; 
        
        
         
          
         float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
         float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;
        
         transform.RotateAround(Vector3.up, -rotX);
         transform.RotateAround(Vector3.right, rotY);
         var diffRotVector = transform.eulerAngles - rotposition;
         if (diffRotVector.magnitude >= changerate)
         {
             rotposition = transform.eulerAngles;
             Debug.Log("Player rotated" + objectName + "eulerAngles=: " + rotposition);
         }
       
   
        // Debug.Log(objectName + "position is :" + objPosition);
         
         

   
}
   
}
