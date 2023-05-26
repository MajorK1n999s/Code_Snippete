using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
    public GameObject shootPoint;
    public List<GameObject> vfx = new List<GameObject>();

    private GameObject effectToSpawn;
    public rotateToMouse _rotateToMouse;

    public ParticleSystem flash;

    // Start is called before the first frame update
    void Start()
    {
        effectToSpawn = vfx[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnVFX();
            flash.Play();
        }
    }

    void SpawnVFX()
    {
        GameObject vfx;

        if (shootPoint != null)
        {
            vfx = Instantiate(effectToSpawn, shootPoint.transform.position, Quaternion.identity);
            if (_rotateToMouse != null)
            {
                vfx.transform.localRotation = _rotateToMouse.getRotation();
            }
        }
        else
        {
            Debug.Log("no shoot point");
        }
    }
}
