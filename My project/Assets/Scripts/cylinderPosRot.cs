
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderPosRot : MonoBehaviour
{
   //position
   public float cylinderXposition;

   public float cylinderYposition;

   public float cylinderZposition;

   //rotation
   public float cylinderXrotation;

   public float cylinderYrotation;

   public float cylinderZrotation;
   //current position and rotation
   public void Awake(){
     cylinderXposition = PlayerPrefs.GetFloat("cylinderPositionX");
     cylinderYposition = PlayerPrefs.GetFloat("cylinderPositionY");
    cylinderZposition = PlayerPrefs.GetFloat("cylinderPositionZ");

    cylinderXrotation = PlayerPrefs.GetFloat("cylinderRotationX");
    cylinderYrotation = PlayerPrefs.GetFloat("cylinderRotationY");
    cylinderZrotation = PlayerPrefs.GetFloat("cylinderRotationZ");
   }
   // setting values for current position and rotation
   public void Start(){
     transform.position = new Vector3(cylinderXposition,cylinderYposition,cylinderZposition);//positions of transform object

     transform.rotation = Quaternion.Euler(cylinderXrotation,cylinderYrotation,cylinderZrotation);
   }
// saving value for current position and rotation
   public void Update(){
    PlayerPrefs.SetFloat("cylinderPositionX", transform.position.x);
    PlayerPrefs.SetFloat("cylinderPositionY", transform.position.y);
    PlayerPrefs.SetFloat("cylinderPositionZ", transform.position.z);

    PlayerPrefs.SetFloat("cylinderRotationX", transform.eulerAngles.x);
    PlayerPrefs.SetFloat("cylinderRotationY", transform.eulerAngles.y);
    PlayerPrefs.SetFloat("cylinderRotationZ", transform.eulerAngles.z);
   }
}