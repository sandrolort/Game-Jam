using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // This script is responsible for following the player. The camera shouldn't go out of bounds, and it should follow the player smoothly.
    public GameObject Player;
    public float Smoothness = 0.01f;
    public float CameraSpeed = 2f;
    //X corresponds to starting position, Y corresponds to ending position in X coordinates.
    public Vector2 CameraBounds = new Vector2(0, 10);

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(Mathf.Clamp(Player.transform.position.x, CameraBounds.x, CameraBounds.y), transform.position.y, transform.position.z), Smoothness);
    }
}
