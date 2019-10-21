using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Survival
{
    public abstract class Weapon
    {
        protected float damage;
        protected float fireRate;
        protected float range;
        protected int maxClipAmmo;

        public int clipAmmo;
        public int carryAmmo;

        public string Name;

        public float Damage
        {
            get { return damage; }
        }

        public float FireRate
        {
            get { return fireRate; }
        }

        public float Range
        {
            get { return range; }
        }

        public virtual void ReloadBehavior()
        {
            if (carryAmmo > 0)
            {
                if (carryAmmo > maxClipAmmo)
                {
                    carryAmmo -= maxClipAmmo;
                    clipAmmo = maxClipAmmo;
                }
                else
                {
                    clipAmmo = 0;
                    clipAmmo += carryAmmo;
                    carryAmmo -= clipAmmo;
                }
            }
            else
            {
                Debug.Log("No ammo.");
            }
        }

        public virtual void ShotBehavior()
        {
            if (clipAmmo > 0)
            {
                clipAmmo--;

                Debug.Log("POW!");
            }
            else
            {
                ReloadBehavior();
            }

            Debug.Log("Ammo: " + clipAmmo + "/" + carryAmmo);
        }
    }

    public class Pistol : Weapon
    {


        public Pistol() { }

        public Pistol(float damage, float fireRate, float range, int maxClipAmmo)
        {
            this.damage = damage;
            this.fireRate = fireRate;
            this.range = range;
            this.maxClipAmmo = maxClipAmmo;

            clipAmmo = maxClipAmmo;
            carryAmmo = maxClipAmmo * 3;

            Name = "Pistol";
        }
    }

    public class Rifle : Weapon
    {
        public Rifle() { }

        public Rifle(float damage, float fireRate, float range, int maxClipAmmo)
        {
            this.damage = damage;
            this.fireRate = fireRate;
            this.range = range;
            this.maxClipAmmo = maxClipAmmo;

            clipAmmo = maxClipAmmo;
            carryAmmo = maxClipAmmo * 3;

            Name = "Rifle";
        }
    }
}