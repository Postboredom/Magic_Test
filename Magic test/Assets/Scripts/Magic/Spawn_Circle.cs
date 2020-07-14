using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Circle : Magic_Decorator
{
    public GameObject obj;
    public Transform pos;
    private Magic_interface _spell;


    public Spawn_Circle(Magic_interface magic) : base(magic) { }

    public override GameObject SpawnItem()
    {
        obj = GameObject.Find("Sphere");
        Object.Instantiate(obj, base.SpawnItem().transform);
        obj.transform.position = Vector3.zero;
      //  Object.Destroy(base.SpawnItem(), 1f);
        return obj;
    }
}
