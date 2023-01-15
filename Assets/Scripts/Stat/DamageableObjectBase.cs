using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Stat.Test
{
    public class DamageableObjectBase : MonoBehaviour, IDamageable
    {
        [SerializeField] private Collider _collider;
        public int InstanceId { get; private set; }

        protected virtual void Awake()
        {
            InstanceId = _collider.GetInstanceID();
            this.InitializeDamageable();
        }

        public virtual void Damage(float dmg)
        {
            Debug.Log("you damaged me : " + dmg);
        }
    }
}

