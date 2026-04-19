using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.EventSystems;

public class FirePoint : MonoBehaviour
{
    public Camera sceneCamera;
    public Rigidbody2D rb;
    private Vector2 mousePosition;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        ProcressInput();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcressInput()
    {
        mousePosition = sceneCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    void Move()
    {
        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;
    }
}