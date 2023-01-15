using UnityEngine;
using TopDownShooter.Stat;
using UniRx;

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

        public void Shoot(Vector3 origin, Vector3 direction, IDamage damage, PlayerStat stat)
        {
            RaycastHit rHit;
            var physic = Physics.Raycast(origin, direction, out rHit);
            //MessageBroker.Default.Publish(new EventPlayerShoot(origin, stat));
            if (physic)
            {
                Debug.Log("Shoot : " + rHit.collider.name); ;
                int colliderInstanceId = rHit.collider.GetInstanceID();
                if (DamageableHelper.DamagebleList.ContainsKey(colliderInstanceId))
                {
                    DamageableHelper.DamagebleList[colliderInstanceId].Damage(damage);
                }
            }
        }
    }
}
