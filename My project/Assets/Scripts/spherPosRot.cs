using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherPosRot : MonoBehaviour
{
   //position
   public float sphereXposition;

   public float sphereYposition;

   public float sphereZposition;

   //rotation
   public float sphereXrotation;

   public float sphereYrotation;

   public float sphereZrotation;
   //current position and rotation
   public void Awake(){
     sphereXposition = PlayerPrefs.GetFloat("spherePositionX");
     sphereYposition = PlayerPrefs.GetFloat("spherePositionY");
    sphereZposition = PlayerPrefs.GetFloat("spherePositionZ");

    sphereXrotation = PlayerPrefs.GetFloat("sphereRotationX");
    sphereYrotation = PlayerPrefs.GetFloat("sphereRotationY");
    sphereZrotation = PlayerPrefs.GetFloat("sphereRotationZ");
   }
   // setting values for current position and rotation
   public void Start(){
     transform.position = new Vector3(sphereXposition,sphereYposition,sphereXposition);//positions of transform object

     transform.rotation = Quaternion.Euler(sphereXrotation,sphereYrotation,sphereZrotation);
   }
// saving value for current position and rotation
   public void Update(){
    PlayerPrefs.SetFloat("spherePositionX", transform.position.x);
    PlayerPrefs.SetFloat("spherePositionY", transform.position.y);
    PlayerPrefs.SetFloat("spherePositionZ", transform.position.z);

    PlayerPrefs.SetFloat("sphereRotationX", transform.eulerAngles.x);
    PlayerPrefs.SetFloat("sphereRotationY", transform.eulerAngles.y);
    PlayerPrefs.SetFloat("sphereRotationZ", transform.eulerAngles.z);
   }
}
