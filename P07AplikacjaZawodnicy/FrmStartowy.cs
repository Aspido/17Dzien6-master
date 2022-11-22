using P06BibliotekaPolaczenieZBaza;
using P07AplikacjaZawodnicy.Domain;
using P07AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07AplikacjaZawodnicy
{
    public partial class FrmStartowy : Form
    {
        public FrmSzczegoly frmSzczegoly { get; set; }
        public FrmStartowy()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            lbDane.DataSource = zr.PodajZawodnikow();
            lbDane.DisplayMember = "DaneRaportowe";                        
        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            Zawodnik zaznaczony =
                (Zawodnik)lbDane.SelectedItem;

            if (frmSzczegoly==null)
            {
                frmSzczegoly = new FrmSzczegoly(zaznaczony, this);
                frmSzczegoly.Show();
            }
            else
                frmSzczegoly.UzupelnijFormularz(zaznaczony);
            

            
        }

        private void btnUsunZawodnika_Click(object sender, EventArgs e)
        {

            PolaczenieZBaza polaczenie = new PolaczenieZBaza();

            Zawodnik zaznaczony = (Zawodnik)lbDane.SelectedItem;

            string usuniecie  = "Delete from zawodnicy where id_zawodnika= '" + Convert.ToString(zaznaczony.Id_zawodnika) + "'";

            polaczenie.WyslijPolecenieSQL(usuniecie);


        }

        private void btnDodajZawodnika_Click(object sender, EventArgs e)
        {
            Zawodnik nowy = new Zawodnik();


            if (frmSzczegoly == null)
            {
                frmSzczegoly = new FrmSzczegoly(nowy, this);
                frmSzczegoly.Show();
            }
            else
                frmSzczegoly.UzupelnijFormularz(nowy);

        }
    }
}
