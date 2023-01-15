using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Stat.Test
{
    public class DamageableObject : MonoBehaviour, IDamageable
    {
        [SerializeField] private Collider _collider;
        public int InstanceId { get; private set; }

        public void Damage(float dmg)
        {
            Debug.Log("you damaged me : " + dmg);
        }

        private void Awake()
        {
            InstanceId = _collider.GetInstanceID();
            this.InitializeDamageable();
        }
    }
}

