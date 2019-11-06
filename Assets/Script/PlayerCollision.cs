
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Ostacle")
        {
            Debug.Log("We hit Ostacle");
            movement.enabled = false;
        }
    }
}
