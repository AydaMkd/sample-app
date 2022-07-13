using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubePosRot : MonoBehaviour
{
   //position
   public float cubeXposition;

   public float cubeYposition;

   public float cubeZposition;

   //rotation
   public float cubeXrotation;

   public float cubeYrotation;

   public float cubeZrotation;
   //current position and rotation
   public void Awake(){
     cubeXposition = PlayerPrefs.GetFloat("cubePositionX");
     cubeYposition = PlayerPrefs.GetFloat("cubePositionY");
    cubeZposition = PlayerPrefs.GetFloat("cubePositionZ");

    cubeXrotation = PlayerPrefs.GetFloat("cubeRotationX");
    cubeYrotation = PlayerPrefs.GetFloat("cubeRotationY");
    cubeZrotation = PlayerPrefs.GetFloat("cubeRotationZ");
   }
   // setting values for current position and rotation
   public void Start(){
     transform.position = new Vector3(cubeXposition,cubeYposition,cubeZposition);//positions of transform object

     transform.rotation = Quaternion.Euler(cubeXrotation,cubeYrotation,cubeZrotation);
   }
// saving value for current position and rotation
   public void Update(){
    PlayerPrefs.SetFloat("cubePositionX", transform.position.x);
    PlayerPrefs.SetFloat("cubePositionY", transform.position.y);
    PlayerPrefs.SetFloat("cubePositionZ", transform.position.z);

    PlayerPrefs.SetFloat("cubeRotationX", transform.eulerAngles.x);
    PlayerPrefs.SetFloat("cubeRotationY", transform.eulerAngles.y);
    PlayerPrefs.SetFloat("cubeRotationZ", transform.eulerAngles.z);
   }
}