using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class Delivery : MonoBehaviour
{

    public TextMeshProUGUI Paketsayac;
    public TextMeshProUGUI uyuartik;
    public int totalDeliveredPackage;
    public float timeRemaining = 10;

    bool hasPackage ;
    [SerializeField] float packageDestroyTime = .5f  ;
  
    
   
    void OnTriggerEnter2D(Collider2D other)
    {
    if (other.tag == "Package" && !hasPackage)
        {

           
            hasPackage = true;
            Destroy(other.gameObject, packageDestroyTime);
            
        }
        
        if (other.tag == "Delivery Locations" && hasPackage)
        {

           
            hasPackage = false;
            totalDeliveredPackage +=1;
           

        }
      

    }
    private void Update()
    {
        Paketsayac.text = ("Teslim Edilen Paket : " + totalDeliveredPackage);

        if (totalDeliveredPackage == 5)
        {

            uyuartik.enabled = true;

            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;

            }
            if (timeRemaining <6)
            {
                uyuartik.text = ("Oyun kapanýyor son : " + Mathf.FloorToInt(timeRemaining) + " Saniye ");
            }
            
            if (timeRemaining <= 0)
            {
                Application.Quit();
                
            }

        }
    }
}

