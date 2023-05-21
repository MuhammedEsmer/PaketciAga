using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Teleport : MonoBehaviour
{
    private bool portalActive = false;
    [SerializeField] private Transform teleporttostick;
    [SerializeField] GameObject player;
    private void Update()
    {
        teleport();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        portalActive = true;
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        portalActive = false;
    }
    void teleport()
    {
        if(portalActive == true && Input.GetKeyDown(KeyCode.E))
        { 
        player.transform.position = new Vector2(teleporttostick.transform.position.x , teleporttostick.transform.position.y );
        }
  
        else { }
    }
}
