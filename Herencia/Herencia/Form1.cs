using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var thor = new Heroe();
            thor.Id = 01;
            thor.Nombre = "Thor Dios del trueno";
            thor.Poder = "Dios del trueno";

            var capitanAmerica = new Heroe();
            capitanAmerica.Id = 02;
            capitanAmerica.Nombre = "Steven Rogers";
            capitanAmerica.Poder = "Fuerza";

            var hulk = new Heroe();
            hulk.Id = 03;
            hulk.Nombre = "BruceBaner";
            hulk.Poder = "Fuerza";

            var ultron = new Villano();
            ultron.Id = 01;
            ultron.Nombre = "Ultron";
            ultron.Poder = "Hecho de vibranium";

            var thanos = new Villano();
            thanos.Id = 02;
            thanos.Nombre = "El Thanos";
            thanos.Poder = "Las gemas";

            var loki = new Villano();
            loki.Id = 03;
            loki.Nombre = " Loki El Dios de la Mentira";
            loki.Poder = "Arte del engaño";

            var listaheroes = new List<Heroe>();
            listaheroes.Add(capitanAmerica);
            listaheroes.Add(hulk);
            listaheroes.Add(thor);

            foreach (var h in listaheroes)
            {
                MessageBox.Show(h.Nombre);
            }
        }
    }
}
