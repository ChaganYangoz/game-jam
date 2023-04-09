using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour

{
    [SerializeField] private GameObject backgroundFollow;
    [SerializeField] private float speed = 1.5f;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, backgroundFollow.transform.position, speed * Time.deltaTime);
    }
}