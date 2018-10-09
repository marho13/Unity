using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 10f;

    private Transform target;
    private int wpIndex = 0;
    public int health = 0;
    
    void Start()
    {
        target = Waypoints.wp[0];
    }

    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.3f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (wpIndex > Waypoints.wp.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        wpIndex++;
        target = Waypoints.wp[wpIndex];

    }
}
