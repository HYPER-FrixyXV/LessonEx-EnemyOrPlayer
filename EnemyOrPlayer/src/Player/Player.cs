using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BPascal.LessonEx3.ClassPlayer
{
    public class Player
    { //parte costruttore
        private string _Name;
        private int _Lv; //level
        private int _Exp; //experience
        private int _Health;
        private int _MaxHealth;
        private bool _IsAlive;
        private int _Gold;

        public string Name
        {
            get { return _Name; }
            set
            {
                if (value.IsWhiteSpace() || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty or blank.");
                }
            }
        }

        public int Lv
        {
            get { return _Lv; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Level cannot be less than 1.");
                }
            }
        }

        public int Exp
        {
            get { return _Exp; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Experience cannot be negative.");
                }
                if (value >= 100)
                {
                    Lv++;
                    _Exp = value - 100;
                }
                else
                {
                    _Exp = value;
                }
            }
        }

        public int Health
        {
            get { return _Health; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Health cannot be negative.");
                }
                if (value > _MaxHealth)
                {
                    _Health = _MaxHealth;
                }
                else
                {
                    _Health = value;
                }
            }
        }

        public int MaxHealth
        {
            get { return _MaxHealth; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("MaxHealth cannot be less than 1.");
                }
                _MaxHealth = value;
            }
        }

        public bool IsAlive
        {
            get { return _IsAlive; }
            private set
            {
                _IsAlive = value;
            }
        }

        public int Gold
        {
            get { return _Gold; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Gold cannot be negative.");
                }
                _Gold = value;
            }
        }

    public Player(string name)
        {
            Name = name;
            Lv = 1;
            Exp = 0;
            MaxHealth = 100;
            Health = MaxHealth;
            IsAlive = true;
            Gold = 0;
        }
        //metodi
        public void AddExp(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be positive.");
            }
            Exp += amount;
        }
        public void ResetExp()
        {
            Exp = 0;
        }
        public void TakeDamage(int amount)

        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be positive.");
            }
            Health -= amount;
            if (Health <= 0)
            {
                IsAlive = false;
                Health = 0;
            }
        }

        public void Heal(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be positive.");
            }
            Health += amount;
        }
        public void GainGold(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be positive.");
            }
            Gold += amount;
        }
        public void ResetHealth()
        {
            Health = MaxHealth;
            IsAlive = true;
        }
    }
}