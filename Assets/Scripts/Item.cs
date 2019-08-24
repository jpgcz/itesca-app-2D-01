using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Player")){
            //Player = Player = other.GetComponent<Player>(); //other.gameObject.GetComponent<Player>();
            Destroy(gameObject);
        }
    }
}
