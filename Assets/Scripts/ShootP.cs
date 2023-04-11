using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootP : MonoBehaviour
{
    public float speed = 5;
    private int timeToDestroy = 5;
    void Start()
    {

    }

    void Update()
    {
        StartCoroutine(destroyBullet());
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    IEnumerator destroyBullet()
    {
        yield return new WaitForSeconds(timeToDestroy);
        Destroy(gameObject);
    }
}