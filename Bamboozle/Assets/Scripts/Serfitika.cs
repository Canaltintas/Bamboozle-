using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Serfitika : MonoBehaviour
{
      private int coin = 0;
      public Text serfitikas;
       private void OnTriggerEnter(Collider other)
       {
          if (other.gameObject.CompareTag("Player"))
          {
             this.gameObject.transform.position = new Vector3(0, 0f, 15f);
             coin += 1;
          }
       }
    
       private void Update()
       {
          serfitikas.text = " " + coin;
       }
}
