using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    // config params
    WaveConfig waveConfig;
    List<Transform> waypoints;
    int waypointindex = 0;

    // Start is called before the first frame update
    void Start()
    {
        waypoints = waveConfig.GetWayPoints();
        transform.position = waypoints[waypointindex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void SetWaveConfig(WaveConfig waveConfig)
    {
        this.waveConfig = waveConfig;
    }

    private void Move()
    {
        if (waypointindex <= waypoints.Count - 1)
        {
            var targetPosition = waypoints[waypointindex].transform.position;
            var movementThisFrame = waveConfig.GetMooveSpeed() * Time.deltaTime;
            transform.position = Vector2.MoveTowards
                (transform.position, targetPosition, movementThisFrame);
            if (transform.position == targetPosition)
            {
                waypointindex++;
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
