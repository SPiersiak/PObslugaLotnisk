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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
using System.Data.SQLite;

namespace Aplikacja
{
    /// <summary>
    /// Logika interakcji dla klasy RejPas.xaml
    /// </summary>
    public partial class RejPas : UserControl
    {
        string dbcon = @"Data Source = C:\Users\piers\Documents\GitHub\Aplikacja\LogReg.db;Version=3";
        string x;
        string y;
        public RejPas()
        {
            InitializeComponent();
            
        }

        public RejPas(string id, string typ) : this()
        {
            x = id;
            y = typ;

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            string query = "SELECT Nazwa_Lot, Dzien, Godzina, Nr_pas, Typ_sam, Koszt FROM lotnisko WHERE  Nazwa_Lot ='" + Z.Text + "'";
            SQLiteCommand com = new SQLiteCommand(query, sqlcon);
            com.ExecuteNonQuery();
            SQLiteDataReader dr = com.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count++;
                Szukaj nazwa = new Szukaj { Lot = dr["Nazwa_Lot"].ToString(), Data=dr["Dzien"].ToString(), Godz=dr["Godzina"].ToString(), nrpas=dr["Nr_pas"].ToString(), TypSam=dr["Typ_sam"].ToString(), Koszt=dr["Koszt"].ToString() };
                Rezw.Items.Add(nazwa);
            }
            sqlcon.Close();
        }

        private void Rez_Click(object sender, RoutedEventArgs e)
        {
            Szukaj cos = (Szukaj)Rezw.SelectedItem;
            string f = cos.nrpas;
            SQLiteConnection sqlcon = new SQLiteConnection(dbcon);
            sqlcon.Open();
            if (((Nr_lot.Text == "") && (f == "")) || (Nr_lot.Text == "") || (f == ""))
            {
                MessageBox.Show("Pusty numer lotu lub nie zaznaczono lotniska");
            }
            else
            {

                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = @"UPDATE lotnisko SET Zarezerwowane = @tak, Nr_lot = @nr_lot, Id_prze = @id WHERE Nr_pas = @pas";
                cmd.Connection = sqlcon;
                cmd.Parameters.Add(new SQLiteParameter("@tak", "Tak"));
                cmd.Parameters.Add(new SQLiteParameter("@nr_lot", Nr_lot.Text));
                cmd.Parameters.Add(new SQLiteParameter("@id", x));
                cmd.Parameters.Add(new SQLiteParameter("@pas", f));
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Zaktualizowane dane");

                }
                else
                {
                    MessageBox.Show("error");
                }
                sqlcon.Close();
            }
        }
    }

    public class Szukaj
    {
        public string Lot { get; set; }
        public string Data { get; set; }
        public string Godz{ get; set; }
        public string nrpas { get; set; }
        public string TypSam { get; set; }
        public string Koszt { get; set; }
    }
}