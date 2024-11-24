using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    


    }

    /*
    private void OnCollisionEnter(Collision infoCollision)
    {

        //Debug.Log("Estoy colisionando con " + infoCollision.gameObject.name);

        if (infoCollision.collider.CompareTag("Enemy"))
        {

            Debug.Log("Estoy colisionando con " + infoCollision.gameObject.name);
            //Destroy(infoCollision.gameObject);

        }

    }
    */

    private void OnTriggerEnter(Collider infoAccess)
    {

        Debug.Log("Colisión tipo Trigger con: " + infoAccess.gameObject.tag);

        if (infoAccess.CompareTag("Enemy")) 
        {

            Destroy(infoAccess.gameObject);

        }
        
    }
}
