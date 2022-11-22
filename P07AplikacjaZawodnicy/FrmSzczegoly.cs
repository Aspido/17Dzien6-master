using P07AplikacjaZawodnicy.Domain;
using P07AplikacjaZawodnicy.Repositories;
using P06BibliotekaPolaczenieZBaza;
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
    public partial class FrmSzczegoly : Form
    {
        private Zawodnik zawodnik;
        private FrmStartowy fs;

        public FrmSzczegoly(Zawodnik zawodnik, FrmStartowy fs)
        {
            InitializeComponent();
            UzupelnijFormularz(zawodnik);
            this.zawodnik = zawodnik;
            this.fs = fs;
        }

        public void UzupelnijFormularz(Zawodnik zawodnik)
        {
            txtImie.Text = zawodnik.Imie;
            txtNazwisko.Text = zawodnik.Nazwisko;
            txtKrajZawodnika.Text = zawodnik.Kraj;
            txtDataUr.Text = zawodnik.DataSformatowana;
            txtWzrost.Text = zawodnik.Wzrost.ToString();
            txtWaga.Text = zawodnik.Waga.ToString();
        }

        private void FrmSzczegoly_FormClosed(object sender, FormClosedEventArgs e)
        {
            fs.frmSzczegoly = null;
        }

        private async void btnZapisz_Click(object sender, EventArgs e)
        {
            ZczytytajFormularz();

            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.Edytuj(zawodnik);
        }

        private void ZczytytajFormularz()
        {
            zawodnik.Id_trenera = Convert.ToInt32(txtIdTrenera.Text);
            zawodnik.Imie = txtImie.Text;
            zawodnik.Nazwisko = txtNazwisko.Text;
            zawodnik.Kraj = txtKrajZawodnika.Text;


            
            if (string.IsNullOrEmpty(txtDataUr.Text))
                zawodnik.DataUrodzenia = null;
            else
                zawodnik.DataUrodzenia = Convert.ToDateTime(txtDataUr.Text);



            zawodnik.Waga = Convert.ToInt32(txtWaga.Text);
            zawodnik.Wzrost = Convert.ToInt32(txtWzrost.Text);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ZczytytajFormularz();

            //ZawodnicyRepository nz = new ZawodnicyRepository();
            PolaczenieZBaza pb = new PolaczenieZBaza();

            // string pid = "SELECT MAX id_zawodnika  FROM zawodnicy";

            //string wys = "insert into zawodnicy (id_zawodnika,id_trenera,imie, nazwisko, kraj,data_ur, wzrost, waga) " + "VALUES('" + Convert.ToInt32("select max(id_zawodnika) from zawodnicy") + "','" + zawodnik.Id_trenera + "','" + zawodnik.Imie + "','" + zawodnik.Nazwisko + "','" + zawodnik.Kraj + "' ,  '" + Convert.ToString(zawodnik.DataSformatowana) + "' , '" + zawodnik.Waga.ToString() + "' , '" + zawodnik.Wzrost.ToString() + "'   );";
            string wys = "insert into zawodnicy (id_trenera,imie, nazwisko, kraj,data_ur, wzrost, waga) " + "VALUES('" + zawodnik.Id_trenera + "','" + zawodnik.Imie + "','" + zawodnik.Nazwisko + "','" + zawodnik.Kraj + "' ,  '" + Convert.ToString(zawodnik.DataSformatowana) + "' , '" + zawodnik.Waga.ToString() + "' , '" + zawodnik.Wzrost.ToString() + "'   );";


            pb.WyslijPolecenieSQL(wys);
        }
    }
}
