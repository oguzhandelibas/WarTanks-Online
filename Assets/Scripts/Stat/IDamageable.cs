using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Stat
{
    public static class DamageableHelper
    {
        public static Dictionary<int, IDamageable> DamageableList = new Dictionary<int, IDamageable>();
        public static void InitializeDamageable(this IDamageable damageable)
        {
            DamageableList.Add(damageable.InstanceId, damageable);
        }
    }

    public interface IDamageable
    {
        int InstanceId { get; }
        void Damage(float dmg);
    }
}

