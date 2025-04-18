using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VisionCone2 : MonoBehaviour
{
    private Enemy enemy;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponentInParent<Enemy>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //set is in vision to true
            enemy.SetPlayerInVisionCone(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //set is in vision cone to false
            enemy.SetPlayerInVisionCone(false);
        }
    }
}
