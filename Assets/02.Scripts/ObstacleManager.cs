using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;

    public GameObject obstaclePrefab;

    float currTime = 0.0f;
    float createTime = 3.0f;

    // Update is called once per frame
    private void FixedUpdate()
    {
        //StartCoroutine(CreateObt());
        currTime += Time.deltaTime;


        if (currTime >= createTime)
        {
            CreateObstacle();
        }

    }

    IEnumerator CreateObt()
    {
        yield return new WaitForSeconds(1.0f);
        CreateObstacle();
    }

    void CreateObstacle()
    {
        GameObject obtp1 = Instantiate(obstaclePrefab);
        GameObject obtp2 = Instantiate(obstaclePrefab);
        obtp1.transform.position = pos1.position;
        obtp2.transform.position = pos2.position;
    }
}
