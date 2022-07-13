using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newrotation : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject refObject;
private Vector3 startPosition;
private Vector3 currentPosition;
private Vector3 diffPosition;
private Vector3 currentRotation;
 private Vector3 rotposition;
private Vector3 lastTransformPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update(){
          string objectName = gameObject.name;
          rotposition = transform.eulerAngles;
            
     if (Input.GetMouseButton(1)){
  
        currentPosition = Input.mousePosition;
        diffPosition = currentPosition - startPosition;
        float xRotation = currentRotation.x - diffPosition.y /2;
        float zRotation = currentRotation.z - diffPosition.x /2;
        refObject.transform.rotation = Quaternion.Euler(xRotation, 0, zRotation);
        var diffVector = transform.position - lastTransformPos;
         if (diffVector.magnitude >= 0.1f){
        Debug.Log("Player rotated " + objectName);
        }
     }
            }
}
   

