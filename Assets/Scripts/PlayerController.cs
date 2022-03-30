using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject[] obj;
    public Camera cam;
    public float speed = 20;

    public Transform bulletSpwanPoint;
    public GameObject bulletPrefab;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        bulletFire();
        
    }
 void bulletFire()
    {
        if (Input.GetMouseButtonUp(0)) 
        {
            Debug.Log("in mouse");
            //InvokeRepeating("bulletFire", StartDelay, repeatDelay);
            int index = Random.Range(0, obj.Length);
            GameObject bullet = Instantiate(obj[index], bulletSpwanPoint.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpwanPoint.forward * speed;
            //GameObject bullet = ObjectPool.SharedInstense.GetPooledObject();
            //bullet.GetComponent<Rigidbody>().velocity = bulletSpwanPoint.forward * speed;

            //    Debug.Log("in mouse2");
            //    bullet.transform.position = bulletSpwanPoint.transform.position;
            //    bullet.transform.rotation = bulletSpwanPoint.transform.rotation;
            //    bullet.SetActive(true);

        }
       
    }

    void Movement()
    {
        // Converting the mouse position to a point in 3D-space
        Vector3 point = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        // Using some math to calculate the point of intersection between the line going through the camera and the mouse position with the XZ-Plane
        float t = cam.transform.position.y / (cam.transform.position.y - point.y);
        Vector3 finalPoint = new Vector3(t * (point.x - cam.transform.position.x) + cam.transform.position.x, 1, t * (point.z - cam.transform.position.z) + cam.transform.position.z);
        //Rotating the object to that point
        transform.LookAt(finalPoint, Vector3.up);
    }


}
