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
        public Survivor(string name)
        {
            Name = name;
        }

        public void Wound()
        {
            _wounds++;
        }

        public void StartTurn()
        {
            Actions = 3;
        }
    }
}
