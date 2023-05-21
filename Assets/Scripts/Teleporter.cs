using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

    [SerializeField] Transform portalToTeleport;
    [SerializeField] int offSetX;
    [SerializeField] int offSetY;
    [SerializeField] int rotation;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        { 
            other.transform.position = new Vector2(portalToTeleport.transform.position.x+offSetX,portalToTeleport.transform.position.y+offSetY);
            other.transform.rotation = Quaternion.Euler(0, 0, rotation);
        }
    }

}
