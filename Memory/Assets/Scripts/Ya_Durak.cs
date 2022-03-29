using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ya_Durak : MonoBehaviour
{
      int x,y,z,w;
     bool f;
     
 private void Start() {
    
    
    for(x=0;x<2;x++)
    for(y=0;y<2;y++)
    for(z=0;z<2;z++)
    for(w=0;w<2;w++){
    f=( ( (x<=y) == (z<=w))||((x==1)&&(w==1)));
    if(f==false) 
     Debug.Log(x+""+y+""+z+""+w);
    }
}
}

  
