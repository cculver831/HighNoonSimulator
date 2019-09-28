using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject Spawn1;
    public GameObject Spawn2;
    public GameObject Spawn3;
    public GameObject Spawn4;
    public int spawnPoints = 4;

    public void respawn(GameObject player)
    {
        Debug.Log("Changing Spawn location");
        int spawnPoint = Random.Range(0, spawnPoints);
        switch(spawnPoint)
            {
            case 0:
                Debug.Log("Changing Spawn location 1");
                Vector3 Spawn_ = new Vector3(Spawn1.transform.position.x, Spawn1.transform.position.y, Spawn1.transform.position.z);
                Instantiate(player, Spawn_, Quaternion.identity);
                player.GetComponent<PlayerDamage>().enemyHealth = 10;
                break;
            case 1:
                Debug.Log("Changing Spawn location 2");
                Vector3 Spawn_2 = new Vector3(Spawn2.transform.position.x, Spawn2.transform.position.y, Spawn2.transform.position.z);
                Instantiate(player, Spawn_2, Quaternion.identity);
                player.GetComponent<PlayerDamage>().enemyHealth = 10;
                break;
            case 2:
                Debug.Log("Changing Spawn location 3");
                Vector3 Spawn_3 = new Vector3(Spawn3.transform.position.x, Spawn3.transform.position.y, Spawn3.transform.position.z);
                Instantiate(player, Spawn_3, Quaternion.identity);
                player.GetComponent<PlayerDamage>().enemyHealth = 10;
                break;
            case 4:
                Debug.Log("Changing Spawn location 4");
                Vector3 Spawn_4 = new Vector3(Spawn4.transform.position.x, Spawn4.transform.position.y, Spawn4.transform.position.z);
                Instantiate(player, Spawn_4, Quaternion.identity);
                player.GetComponent<PlayerDamage>().enemyHealth = 10;
                break;

        }   
    }
}
