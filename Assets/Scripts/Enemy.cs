using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;
    public int health;
    public int armor;
    public int magic_resistance;

    private Transform target;
    private int waypointIndex = 0;

    void Start ()
    {
        target = Waypoints.points[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized*speed*Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <=0.4f)
        {
            GetNextWaypoint();
        }

    }
    void GetNextWaypoint()
    {
        if (waypointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        waypointIndex++;
        target = Waypoints.points[waypointIndex];
    }

    public void TakeDamage(int damage)
    {
        if(health > 0)
        {
            health -= damage;
        }
        else
        {
            Destroy(gameObject);
            PlayerStats.Money += 50;
        }

    }
}
