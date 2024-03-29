﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;

namespace OWL_LEARN
{
    /// <summary>
    /// Interaction logic for lesWijzigen.xaml
    /// </summary>
    public partial class lesWijzigen : Window
    {
        string user;
        string lesID;
        string loID;
        DBS dbs = new DBS();
        public lesWijzigen(string sloID, string username, string leswijzigID)
        {
            InitializeComponent();
            user = username;
            lesID = leswijzigID;
            getlesInformatie();
            loID = sloID;
            PopulateListBox();
        }

        struct Vragen
        {
            public string vID { get; set; }
            public string vraag { get; set; }
        }

        private void getlesInformatie()
        {
            DataTable dtGegevens = dbs.Search("les", "lesID", lesID);
            foreach (DataRow row in dtGegevens.Rows)
            {
                tbNaam.Text = row["lesNaam"].ToString();
                rbUitleg.Document.Blocks.Add(new Paragraph(new Run(row["Uitleg"].ToString())));
            }
        }

        private void btTerug_Click(object sender, RoutedEventArgs e)
        {
            LesonderwerpWijzig terug = new LesonderwerpWijzig(loID, user);
            terug.Show();
            this.Close();
        }

        private void btWijzigNaam_Click(object sender, RoutedEventArgs e)
        {
            string sUitleg = new TextRange(rbUitleg.Document.ContentStart, rbUitleg.Document.ContentEnd).Text;
            dbs.changeLesInfo(lesID, tbNaam.Text, sUitleg);
        }

        private void btBewerk_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btVerwijder_Click(object sender, RoutedEventArgs e)
        {
            if (lbLijst.SelectedIndex == -1)
            {
                MessageBox.Show("Selecteer eerst een les om deze te verwijderen.", "Let op!");
            }
            else
            {
                string vraagID = ((Vragen)(lbLijst.SelectedItem)).vID;
                dbs.DeleteVraag(vraagID); ;
                PopulateListBox();
            } 
        }

        private void btVoegToe_Click(object sender, RoutedEventArgs e)
        {
            addVraag newVraag = new addVraag(lesID, user, loID);
            newVraag.Show();
            this.Close();

        }
        private void PopulateListBox()
        {
            List<Vragen> lstLes = new List<Vragen>();
            DataTable dtLes = dbs.Search("vragen", "LesID", lesID);

            foreach (DataRow row in dtLes.Rows)
            {
                lstLes.Add(new Vragen() { vID = row["VraagID"].ToString(), vraag = row["Vraag"].ToString() });
            }
            lbLijst.ItemsSource = lstLes;
        }

    }
}

