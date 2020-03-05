using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Week_3_code_along.Properties
{
    class Goose
    {
        public string Name;
        public int Age;
        public int AttackDamage;

        public void Honk()
        {
      MessageBox.Show("Honk honk *my name is* " + Name + ".Hong *I am* " + Age + "honks *old*");
        }
        public void Attack()
        {
            MessageBox.Show("HONK HONK *I ATTACK YOU FOR* " + AttackDamage + " HONK *DAMAGE*");
        }
    }
}
