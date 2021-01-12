using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotateSpeed = 100f;
    int direction = 1;
    public GameObject pelletPrefab;
    public GameObject turret;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate(pelletPrefab, turret.transform.position, transform.rotation);
            direction *= -1;
        }

        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed * direction);
    }
}
