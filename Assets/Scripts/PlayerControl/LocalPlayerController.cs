using System.Collections;
using System.Collections.Generic;
using TopDownShooter.Inventory;
using TopDownShooter.PlayerInput;
using UnityEngine;

namespace TopDownShooter
{
    public class LocalPlayerController : MonoBehaviour
    {
        [SerializeField] private PlayerInventoryController _inventoryController;
        [SerializeField] private InputData _shootInput;

        private void Update()
        {
            //Debug.Log(_shootInput.Horizontal);
            if (_shootInput.Horizontal > 0)
            {
                _inventoryController.ReactiveShootCommand.Execute();
            }
        }
    }
}