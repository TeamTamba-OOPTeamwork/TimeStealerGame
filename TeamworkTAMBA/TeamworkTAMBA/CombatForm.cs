using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamworkTAMBA
{
    public partial class CombatForm : Form
    {
        Enemy enemy;
        Player player;
        bool isInCombat;

        // TO DO: da se inicializirat igra4a i gadinata v constructora
        // Da se vikne StartCombat
        // Da se napravi logika za bitka
        // Da se naredqt buttoni i poleta prez Disgna na Formata
        // Da se sloji text box i da se varje s butonite

        public CombatForm()
        {

        }

        public void StartCombat(Player player, Enemy enemy)
        { 
            isInCombat = true;

        }
    }
}
