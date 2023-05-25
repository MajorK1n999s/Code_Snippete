using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MoveBullet : MonoBehaviour
{

    public Vector3 hitPoint;
    public GameObject dirt;
    public GameObject blood;
    public int Speed;


    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().AddForce((hitPoint - this.transform.position).normalized * Speed);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy2"))
        {
            Destroy(collision.gameObject);
            Debug.Log("collision detected");
        }
        else
        {
            Instantiate(dirt, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }

        Destroy(this.gameObject);
    }
}
//collision.gameObject.GetComponent<Health>().currentHealth -= 5;
//GameObject newBlood = Instantiate(blood, this.transform.position, this.transform.rotation);
//newBlood.transform.parent = collision.transform;
//Destroy(this.gameObject);
//Debug.Log("bullet touched");