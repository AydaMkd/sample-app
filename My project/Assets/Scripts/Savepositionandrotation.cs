using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Savepositionandrotation : MonoBehaviour
{
   //position
   public float ObjectsXposition;

   public float ObjectsYposition;

   public float ObjectsZposition;

   //rotation
   public float ObjectsXrotation;

   public float ObjectsYrotation;

   public float ObjectsZrotation;
   //current position and rotation
   public void Awake(){
     ObjectsXposition = PlayerPrefs.GetFloat("MyPositionX");
     ObjectsYposition = PlayerPrefs.GetFloat("MyPositionY");
    ObjectsZposition = PlayerPrefs.GetFloat("MyPositionZ");

    ObjectsXrotation = PlayerPrefs.GetFloat("MyRotationX");
    ObjectsYrotation = PlayerPrefs.GetFloat("MyRotationY");
    ObjectsZrotation = PlayerPrefs.GetFloat("MyRotationZ");
   }
   // setting values for current position and rotation
   public void Start(){
     transform.position = new Vector3(ObjectsXposition,ObjectsYposition,ObjectsXposition);//positions of transform object

     transform.rotation = Quaternion.Euler(ObjectsXrotation,ObjectsYrotation,ObjectsZrotation);
   }
// saving value for current position and rotation
   public void Update(){
    PlayerPrefs.SetFloat("MyPositionX", transform.position.x);
    PlayerPrefs.SetFloat("MyPositionY", transform.position.y);
    PlayerPrefs.SetFloat("MyPositionZ", transform.position.z);

    PlayerPrefs.SetFloat("MyRotationX", transform.eulerAngles.x);
    PlayerPrefs.SetFloat("MyRotationY", transform.eulerAngles.y);
    PlayerPrefs.SetFloat("MyRotationZ", transform.eulerAngles.z);
   }
}
