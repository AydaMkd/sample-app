using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelect : MonoBehaviour
{  

   public int currentShapeIndex  ;
    public GameObject[] shapes;
     Rigidbody rb;
    void Start()
    {  

         
        currentShapeIndex = PlayerPrefs.GetInt("SelectedShape", 0);
        foreach ( GameObject shape in shapes)
        shape.SetActive(false);
        shapes[currentShapeIndex].SetActive(true);
    }

    
    public void ChooseNext(){
        shapes[currentShapeIndex].SetActive(false);
        currentShapeIndex++;
        if(currentShapeIndex== shapes.Length)
        currentShapeIndex = 0;
        shapes[currentShapeIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedShape", currentShapeIndex);

    }

      public void ChoosePrevious(){
        shapes[currentShapeIndex].SetActive(false);
        currentShapeIndex--;
        if(currentShapeIndex== -1)
        currentShapeIndex = shapes.Length-1;
        shapes[currentShapeIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedShape", currentShapeIndex);
    }
    public void setPosition(){
        shapes[currentShapeIndex].transform.position = new Vector3(0f,0f,0f);
    }

    // Update is called once per frame
//     void Update()
//     {
//          float rotSpeed = 50.0f;
//     // Update is called once per frame
   
//         if (Input.GetAxis("Mouse ScrollWheel") > 0) {
//    shapes[currentShapeIndex].transform.Rotate(Vector3.right * rotSpeed,Space.Self);
//    Debug.Log("Playe rotated " + shapes[currentShapeIndex]);
// }
// if (Input.GetAxis("Mouse ScrollWheel") < 0) {
//    shapes[currentShapeIndex].transform.Rotate(Vector3.left * rotSpeed, Space.Self);
//    Debug.Log("Player rotated " + shapes[currentShapeIndex]);
// }
//     if (Input.GetKey(KeyCode.A)) {
//    shapes[currentShapeIndex].transform.Rotate(Vector3.up * rotSpeed, Space.Self);
//    Debug.Log("Playe rotated " + shapes[currentShapeIndex]);
// }
// if (Input.GetKey(KeyCode.D)) {
//    shapes[currentShapeIndex].transform.Rotate(Vector3.down * rotSpeed, Space.Self);
//    Debug.Log("Player rotated " + shapes[currentShapeIndex]);
// }
    
//     }

    


}