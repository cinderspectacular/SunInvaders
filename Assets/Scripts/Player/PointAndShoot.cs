using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;

public class PointAndShoot : MonoBehaviour
{
    [field: SerializeField] public InputReader InputReader { get; private set; }
    [field: SerializeField] public CinemachineVirtualCamera aimCamera { get; private set; }

    public GameObject player;
    public GameObject bulletPrefab;
    public GameObject bulletStart;

    public Vector3 mousePos;
    

    void Start()
    {
        InputReader.ShootEvent += OnShoot;

        mousePos = Mouse.current.position.ReadValue();
        Vector3 difference = mousePos - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Mouse.current.position.ReadValue();
        mousePos.z = aimCamera.transform.position.z;
        Debug.Log(mousePos.x);
    }

    void OnDestroyed()
    {
        InputReader.ShootEvent -= OnShoot;
    }

    void OnShoot()
    {
        //FireBullet();
        mousePos = Mouse.current.position.ReadValue();
        Vector3 aimDir = (mousePos - bulletStart.transform.position).normalized;

        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = bulletStart.transform.position;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
    }
}
