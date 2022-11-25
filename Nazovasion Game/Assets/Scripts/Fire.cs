using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D bullet;

    [SerializeField]
    private Transform barrel;

    private float bulletSpeed = 500f;

    string currentWeaponName;

    private float fireRate = 0.4f;
    private float nextFire = 0f;
    private float fireRateShotgun = 1f;

    private void Start()
    {
        currentWeaponName = gameObject.name.Substring(0, name.IndexOf("_"));

    }
    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            WeaponFire(currentWeaponName);
        }
    }
    private void WeaponFire(string weaponName)
    {
        if (weaponName == "Pistol" && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            var spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
            spawnedBullet.AddForce(barrel.up * bulletSpeed);
        }
        else if (weaponName == "Shotgun" && Time.time > nextFire)
        {
            for (int i = 0; i <= 2; i++)
            {
                var spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
                nextFire = Time.time + fireRateShotgun;

                switch (i)
                {
                    case 0:
                        spawnedBullet.AddForce(barrel.up * bulletSpeed + new Vector3(0f, -90f, 0f));
                        break;
                    case 1:
                        spawnedBullet.AddForce(barrel.up * bulletSpeed + new Vector3(0f, 0f, 0f));
                        break;
                    case 2:
                        spawnedBullet.AddForce(barrel.up * bulletSpeed + new Vector3(0f, 90f, 0f));
                        break;
                }
            }
        }
    }
}
