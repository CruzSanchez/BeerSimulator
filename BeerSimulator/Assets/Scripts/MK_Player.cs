using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MK_Player : MonoBehaviour
{
    [Header("Player Stats")]
    [SerializeField] [Range(1, 3)] float moveSpeed = 1f;
    [SerializeField] float padding = .5f;

    float xMin;
    float xMax;
    float yMin;
    float yMax;


    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey(KeyCode.LeftControl)) Move();
    }

    void Move()
    {
        float deltaX = 0 * Time.deltaTime * moveSpeed;
        float deltaY = 0 * Time.deltaTime * moveSpeed;

        if (Input.GetAxisRaw("Horizontal") < 0) deltaX = -1;
        else if (Input.GetAxisRaw("Horizontal") > 0) deltaX = 1;

        if (Input.GetAxisRaw("Vertical") < 0) deltaY = -1;
        else if (Input.GetAxisRaw("Vertical") > 0) deltaY = 1;

        transform.position = new Vector2(transform.position.x + deltaX * Time.deltaTime * moveSpeed, transform.position.y + deltaY * Time.deltaTime * moveSpeed);
    }
}
