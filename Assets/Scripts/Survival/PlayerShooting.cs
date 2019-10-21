using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Survival
{
    public class PlayerShooting : MonoBehaviour
    {
        Weapon currentWeapon;

        Weapon[] carryingWeapons = new Weapon[2];

        private void Start()
        {
            carryingWeapons[0] = new Pistol(2, 1.25f, 15, 12);
            carryingWeapons[1] = new Rifle(4, 0.8f, 30, 8);

            currentWeapon = carryingWeapons[0];
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                ChangeWeapon(0);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                ChangeWeapon(1);
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                currentWeapon.ReloadBehavior();
            }

            if(Input.GetKeyDown(KeyCode.Space))
            {
                Shoot();
            }
        }

        void Shoot()
        {
            currentWeapon.ShotBehavior();
        }

        void ChangeWeapon(int val)
        {
            currentWeapon = carryingWeapons[val];

            Debug.Log("Equipped weapon: " + currentWeapon.Name);
        }

        void ChangeWeapon(Weapon weapon)
        {
            currentWeapon = weapon;
        }
    }
}
