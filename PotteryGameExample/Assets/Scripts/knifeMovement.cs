using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifeMovement : MonoBehaviour
{
    Vector3 mouseMovement;
    public float knifeSpeed;
    [SerializeField]
    Rigidbody rb;
    bool mouseTrue = false;
    public float damage = 0.3f;

    public itemSizeMesh itemMesh;

    private void Update()
    {
       mouseTrue = Input.GetMouseButton(0) ? true : false;
       if(mouseTrue)
       mouseMovement = new Vector3(Input.GetAxisRaw("Mouse X"),Input.GetAxisRaw("Mouse Y"));
    }
    private void FixedUpdate()
    {
        if (mouseTrue)
        rb.MovePosition(rb.position+mouseMovement * Time.fixedDeltaTime * knifeSpeed);
    }

    private void OnCollisionStay(Collision col)
    {
        colliderScript colliderScript = col.collider.GetComponent<colliderScript>();
        if (colliderScript != null)
        {
            colliderScript.colliderHit(damage);
            itemMesh.HitSizeMesh(colliderScript.index, damage);
        }
            
    }
}
