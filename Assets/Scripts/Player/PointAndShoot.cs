using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndShoot : MonoBehaviour
{
    public GameObject crosshairs;
    public GameObject player;
    public GameObject bulletPrefab;
    public GameObject bulletStart;

    public float bulletSpeed = 60.0f;

    private Vector3 target;

    

    /*void Start()
    {
        Cursor.visible = false;
        InputReader.ShootEvent += OnShoot;

        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3());
        Vector3 difference = target - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
    }

    // Update is called once per frame
    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3());

        Vector3 difference = target - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        player.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

    }

    void OnDestroyed()
    {
        InputReader.ShootEvent -= OnShoot;
    }

    void OnShoot()
    {
        FireBullet();
    }

    void FireBullet()
    {
        float distance = difference.magnitude;
        Vector3 direction = difference / distance;
        direction.Normalize();
        FireBullet(direction, rotationZ);

        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = bulletStart.transform.position;
        b.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
        b.GetComponent<Rigidbody>().velocity = direction * bulletSpeed;
    }*/
}
