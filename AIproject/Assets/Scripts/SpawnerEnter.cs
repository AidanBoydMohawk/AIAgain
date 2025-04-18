using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnerEnter : MonoBehaviour
{
    private Spawner spawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    /* This script does not work. Leaving here to show what I was thinking
     
    public void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<Spawner>();
        if (other.gameObject.name == "Player")
        {
          if (other.gameObject.GetComponent<Spawner>().spawningBool == false)
            {
                other.gameObject.GetComponent<Spawner>().spawningBool = true;
            }
        }
    }
    the goal was to try to set an event where once you enter the box collider space, it will trigger the spawningBool be set to true 
    and spawn some AI to shoot at. 
    */
}
