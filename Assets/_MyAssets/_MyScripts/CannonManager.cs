using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonManager : MonoBehaviour
{

    [SerializeField] private GameObject _cannonBall;
    [SerializeField] private GameObject _fireEffect;
    [SerializeField] private Transform firePoint;

    private float fireRate = 2.5f;
    private float nextFire = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Fire();
        }
    }

    private void Fire()
    {
        GameObject cannonBall = Instantiate(
            _cannonBall,
            firePoint.position,
            Quaternion.identity);

        GameObject fireEffect = Instantiate(
            _fireEffect,
            firePoint.position,
            Quaternion.identity);
    }

}
