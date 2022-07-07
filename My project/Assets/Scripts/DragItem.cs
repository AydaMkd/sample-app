using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragItem : MonoBehaviour
{
    // // Start is called before the first frame update
    // Rigidbody rb;
    void Start()
    {
        // rb = GetComponent<Rigidbody>();
    }
    public void OnMouseDrag() {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y , -Camera.main.transform.position.z + transform.position.z);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
        // rb.isKinematic = true; 
         string objectName = gameObject.name;
        // Debug.Log(objectName + transform.position);


      
       
      

 
    
    }

//     public void OnMouseUp() {
//         // rb.isKinematic = false;
//      this.transform.localScale = this.transform.localScale;
//   }
}
    
//     }
//   void Update()
// {
   
// // scale continuously
 
    
//     MouseWheel += ZoomIn;

// void ZoomIn( )
// {
   
//         // The user scrolled up.
//          this.transform.localScale = this.transform.localScale + new Vector3(1f,1f,1f) * Time.deltaTime;
   
   
// }

// }
    

    
//     //  void OnMouseUp() {
//     //     rb.isKinematic = false;
//     //     this.transform.localScale = this.transform.localScale;
//     // }
//    float rotSpeed = 20;


        
//     }

