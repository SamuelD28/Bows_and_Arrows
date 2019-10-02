using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Object;
    public GameObject Troop;

    public void Spawn()
    {
        var troop = Instantiate(this.Troop) as GameObject;

        var x = Object.transform.position.x - Random.Range(-7, 7);
        var y = 1;
        var z = Object.transform.position.z - Random.Range(-7, 7);

        var vec = new Vector3(x, y, z);
        troop.transform.position = vec;
    }
}
