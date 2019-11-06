using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    void Update()
    {
        Debug.Log(player.position);
    }
}
