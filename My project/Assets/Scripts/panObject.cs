
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class panObject : MonoBehaviour
{   
     
  private Vector3 touchStart;
    public Camera cam;
    public float groundZ = 0;
  
    void Start()
    {
        
    }
  
    
 
    

     void Update() {
        
  
        
     
         if (Input.GetMouseButtonDown(2)){
       
         touchStart = GetWorldPosition(groundZ);
            
        }
     
        if (Input.GetMouseButton(2)){
           
            Vector3 direction = touchStart - GetWorldPosition(groundZ);
            cam.transform.position += direction;
        }
     }
    
    private Vector3 GetWorldPosition(float z){
        Ray mousePos = cam.ScreenPointToRay(Input.mousePosition);
        Plane ground = new Plane(Vector3.forward, new Vector3(0,0,z));
        float distance;
        ground.Raycast(mousePos, out distance);
        return mousePos.GetPoint(distance);
     
}
   
 
    }




