using System;
using System.Collections.Generic;
using System.Text;

namespace SwordDamageProjectEncapsulated
{
    class SwordDamage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;
        private int roll;
        private bool flaming;
        private bool magic;

        public SwordDamage(int roll)
        {
            this.roll = roll;
            CalculateDamage();
        }

        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value; CalculateDamage();
            }
        }
        
        public bool Flaming
        {
            get { return flaming; }
            set 
            {
                flaming = value; CalculateDamage();
            }
        }

        public bool Magic
        {
            get { return magic; }
            set 
            {
                magic = value; CalculateDamage();
            }

        }
       
        public int Damage { get; private set; }
        
        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
   
            if (Magic)
            {
                magicMultiplier = 1.75M;
            }

            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            
            if (Flaming)
            {
                Damage  += FLAME_DAMAGE;
            }

        }        

    }
}
