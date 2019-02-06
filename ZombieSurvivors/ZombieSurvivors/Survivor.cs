using System;
using System.Collections.Generic;
using System.Text;

namespace ZombieSurvivors
{
    public class Survivor
    {
        public string Name { get; private set; }
        private int _wounds = 0;
        public bool IsWounded => _wounds == 1;
        public bool IsDead => _wounds > 1;

        public int Actions { get; private set; }
        public List<string> _equipment = new List<string>();
        public IEnumerable<string> Equipment => _equipment;

        int MaxEquipment => 5 - _wounds;
        public Survivor(string name)
        {
            Name = name;
        }

        public void Wound()
        {
            _wounds++;

            while (_equipment.Count > MaxEquipment)
                _equipment.RemoveAt(_equipment.Count - 1);
        }

        public void StartTurn()
        {
            Actions = 3;
        }

        public void AddEquipment(string name)
        {
            if (_equipment.Count >= MaxEquipment)
                throw new Exception($"Cannot carry {name}");

            _equipment.Add(name);
        }
    }
}
