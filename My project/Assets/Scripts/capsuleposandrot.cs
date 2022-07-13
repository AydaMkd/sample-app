using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsuleposandrot : MonoBehaviour
{
   //position
   public float capsuleXposition;

   public float capsuleYposition;

   public float capsuleZposition;

   //rotation
   public float capsuleXrotation;

   public float capsuleYrotation;

   public float capsuleZrotation;
   //current position and rotation
   public void Awake(){
     capsuleXposition = PlayerPrefs.GetFloat("capsulePositionX");
     capsuleYposition = PlayerPrefs.GetFloat("capsulePositionY");
    capsuleZposition = PlayerPrefs.GetFloat("capsulePositionZ");

    capsuleXrotation = PlayerPrefs.GetFloat("capsuleRotationX");
    capsuleYrotation = PlayerPrefs.GetFloat("capsuleRotationY");
    capsuleZrotation = PlayerPrefs.GetFloat("capsuleRotationZ");
   }
   // setting values for current position and rotation
   public void Start(){
     transform.position = new Vector3(capsuleXposition,capsuleYposition,capsuleZposition);//positions of transform object

     transform.rotation = Quaternion.Euler(capsuleXrotation,capsuleYrotation,capsuleZrotation);
   }
// saving value for current position and rotation
   public void Update(){
    PlayerPrefs.SetFloat("capsulePositionX", transform.position.x);
    PlayerPrefs.SetFloat("capsulePositionY", transform.position.y);
    PlayerPrefs.SetFloat("capsulePositionZ", transform.position.z);

    PlayerPrefs.SetFloat("capsuleRotationX", transform.eulerAngles.x);
    PlayerPrefs.SetFloat("capsuleRotationY", transform.eulerAngles.y);
    PlayerPrefs.SetFloat("capsuleRotationZ", transform.eulerAngles.z);
   }
}