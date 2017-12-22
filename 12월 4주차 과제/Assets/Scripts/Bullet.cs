using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 _target;
    private Vector3 direction; // 단위 벡터
    public Vector3 target
    {
        get
        {
            return _target;
        }
        set
        {
            _target = value;
            direction = (_target - transform.position).normalized;
            transform.LookAt(_target);
        }
    }
    public float speed = 10;
    public GameObject explosionPrefab;

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;

        if (Vector3.Dot(direction, target - transform.position) <= 0)
        {
            Collide();
        }
    }

    private void Collide()
    {
        Destroy(gameObject);
        Destroy(Instantiate(explosionPrefab, target, Quaternion.identity), 0.5f);
    }
}