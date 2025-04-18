using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public GameObject gameObject;
    int randomNum;
    public Transform spawnDes1, spawnDes2, spawnDes3, spawnDes4;
    public bool spawningBool = true;
    public float spawnTime;
   

    private void Start()
    {
        
        StartCoroutine(spawning()); 
        GameObject.FindGameObjectWithTag("Enemy"); //find object to spawn
        
    }
    IEnumerator spawning()
    {
        while (spawningBool == true)
        {
            yield return new WaitForSeconds(spawnTime); //set up time between spawning
           randomNum=(Random.Range(0,4)); //4 different spawn points
            if (randomNum == 0)
            {
                Instantiate(gameObject, spawnDes1.position, spawnDes1.rotation); // get the object, spawn position, and rotation
            }
            if (randomNum == 1)
            {
                Instantiate(gameObject, spawnDes2.position, spawnDes2.rotation);
            }
            if (randomNum == 2)
            {
                Instantiate(gameObject, spawnDes3.position, spawnDes3.rotation);
            }
            if (randomNum == 3) 
            {
                Instantiate(gameObject, spawnDes4.position, spawnDes4.rotation);
            }
            
        }

        // here is some code I was trying to set up with the Spanwer Enter
        //spawnerBool = false
        //if (spawnerBool == true) < set up rest of line 26-45

    }
}
