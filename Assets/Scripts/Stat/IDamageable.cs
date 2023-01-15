using System.Collections;
using System.Collections.Generic;
using TopDownShooter.Inventory;
using UnityEngine;


namespace TopDownShooter.Stat
{
    public static class DamageableHelper
    {
        public static Dictionary<int, IDamageable> DamagebleList = new Dictionary<int, IDamageable>();
        public static void InitializeDamageble(this IDamageable damageble)
        {
            DamagebleList.Add(damageble.InstanceId, damageble);
        }

        public static void DestroyDamageble(this IDamageable damageble)
        {
            DamagebleList.Remove(damageble.InstanceId);
        }
    }


    public interface IDamageable
    {
        int InstanceId { get; }
        void Damage(IDamage dmg);
    }
}