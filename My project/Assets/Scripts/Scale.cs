using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    // Start is called before the first frame update
   public List<GameObject> itemtListobjects;
    void Start()
   {
     for (int i= 0; i< itemtListobjects.Count; i++)

        {   
           
            int x= -10;
            int y= -5;
            int z= 5 ;
            Instantiate(itemtListobjects[i], new Vector3(x+5*i, y, z+2*i), Quaternion.identity);
      
   
       
        }
    
    }

    // Update is called once per frame
 public   void Update()
    {
           for (int i= 0; i< itemtListobjects.Count; i++)

        {   
           
            int x= -10;
            int y= -5;
            int z= 5 ;
          itemtListobjects[i].transform.position = new Vector3(x+5*i, y, z+2*i);
           
      
   
       
        }
    }
   
}