using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.Stat;

namespace TopDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "Topdown Shooter/Inventory/ScriptableShootManager")]
    public class ScriptableShootManager : AbstractScriptableManager<ScriptableShootManager>
    {
        public override void Initialize()
        {
            base.Initialize();
            Debug.Log("Scriptable Shoot Manager Activated");
        }

        public override void Destroy()
        {
            base.Destroy();
            Debug.Log("Scriptable Shoot Manager Destroyed");
        }

        public void Shoot(Vector3 origin, Vector3 direction)
        {
            RaycastHit rHit;
            var physic = Physics.Raycast(origin, direction, out rHit);
            if (physic)
            {
                Debug.Log("Collider: " + rHit.collider.name);
                int colliderInstanceId = rHit.collider.GetInstanceID();
                if (DamageableHelper.DamageableList.ContainsKey(colliderInstanceId))
                {
                    DamageableHelper.DamageableList[colliderInstanceId].Damage(5);
                }
            }
        }
    }
}
