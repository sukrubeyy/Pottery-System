using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderScript : MonoBehaviour
{
    public int index;
    BoxCollider boxColl;
    private void Awake()
    {
        boxColl = GetComponent<BoxCollider>();
        index = transform.GetSiblingIndex();
    }
    
    public void colliderHit(float damageSize)
    {
        if (boxColl.size.y - damageSize > 0)
        {
            boxColl.size = new Vector3(boxColl.size.x, boxColl.size.y - damageSize, boxColl.size.z);
        }
        else
            Destroy(this);
    }
}
