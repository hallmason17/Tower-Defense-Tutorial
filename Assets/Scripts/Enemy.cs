using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public int health;
    public int armor;
    public int magic_resistance;
    public int killValue;

    private Transform target;
    private int waypointIndex = 0;

    private List<Debuff> debuffs = new List<Debuff>();

    void Start ()
    {
        target = Waypoints.points[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(speed * Time.deltaTime * dir.normalized, Space.World);

        if (Vector3.Distance(transform.position, target.position) <=0.4f)
        {
            GetNextWaypoint();
        }
        HandleDebuffs();

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
            int damageTaken = (int)Mathf.Round(damage * (1 - (armor / 100)));
            health -= damageTaken;
        }
        else
        {
            Destroy(gameObject);
            PlayerStats.Money += killValue;
            WaveSpawner.enemiesAlive--;
        }

    }
    private void HandleDebuffs()
    {
        foreach(Debuff debuff in debuffs)
        {
            debuff.Update();
        }
    }

    public void AddDebuff(Debuff debuff)
    {
        if (!debuffs.Exists(x => x.GetType() == debuff.GetType()))
        {
            debuffs.Add(debuff);
        }
    }
    public void SetSpeed(int newSpeed)
    {
        speed = newSpeed;
    }
}
