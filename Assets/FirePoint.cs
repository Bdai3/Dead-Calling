using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.EventSystems;

public class FirePoint : MonoBehaviour
{
    public Camera sceneCamera;
    public Transform pistol;
    private UnityEngine.Vector2 mousePosition;
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
        UnityEngine.Vector2 aimDirection = mousePosition - new UnityEngine.Vector2(pistol.position.x, pistol.position.y);

        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;

        transform.rotation = UnityEngine.Quaternion.Euler(0, 0, aimAngle);
    }
}