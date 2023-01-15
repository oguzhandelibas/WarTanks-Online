using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using TopDownShooter.Stat;

namespace TopDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "Topdown Shooter/Inventory/Player Inventory Cannon Item Data")]
    public class PlayerInventoryCannonItemData : AbstractPlayerInventoryItemData<PlayerInventoryCannonItemMono>, IDamage
    {
        [SerializeField] private float _damage;
        public float Damage { get { return _damage; } }
        [SerializeField] private float _rpm = 1f;
        public float RPM { get { return _rpm; } }

        [Range(0.1f, 2)]
        [SerializeField] private float _armorPenetration = 3;
        public float ArmorPenetration { get { return _armorPenetration; } }

        [Header("Timed Base Damage")]
        [SerializeField] private float _timeBaseDamage = 0;
        public float TimedBaseDamage { get { return _timeBaseDamage; } }

        [SerializeField] private float _timeBaseDamageDuration = 3;
        public float TimedBaseDamageDuration { get { return _timeBaseDamageDuration; } }

        public PlayerStat Stat
        {
            get { return null; }
            //_inventoryController.PlayerStat; }
        }

        private float _lastShootTime;

        public override void Initialize(PlayerInventoryController targetPayerInventory)
        {
            base.Initialize(targetPayerInventory);
            InstantiateAndInitializePrefab(targetPayerInventory.CannonParent);
            targetPayerInventory.ReactiveShootCommand.Subscribe(OnReactiveShootCommand).AddTo(_compositeDisposable);
        }


        public override void Destroy()
        {
            base.Destroy();
        }

        private void OnReactiveShootCommand(Unit obj)
        {
            Shoot();
        }

        public void Shoot()
        {
            if (Time.time - _lastShootTime > _rpm)
            {
                _instantiated.Shoot(this, _inventoryController.PlayerStat);
                _lastShootTime = Time.time;
            }
        }
    }
}