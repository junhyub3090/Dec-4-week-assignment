using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Gun : MonoBehaviour
{
    public GameObject target;
    public GameObject bulletPrefab;
    private float time;
    public float timeGap;

    void Update()
    {
        time += Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            if (time >= timeGap)
            {
                Shoot();
                time = time - timeGap;
            }
        }
       
    }

    private void Shoot()
    {
        GameObject bulletObject = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        bulletObject.GetComponent<Bullet>().target = target.transform.position;
    }
}