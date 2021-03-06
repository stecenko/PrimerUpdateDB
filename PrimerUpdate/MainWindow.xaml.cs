﻿using PrimerUpdate.Model;
using System.Data.Entity;
using System.Windows;

namespace PrimerUpdate
{
    public partial class MainWindow : Window
    {
        PrimerRepository primerRepository;

        public MainWindow()
        {
            InitializeComponent();
            primerRepository = new PrimerRepository();

            GridTovar.ItemsSource = primerRepository.GetTovars();
            GridTovarType.ItemsSource = primerRepository.GetViewTovarTypes();
            //GridViewTovar.ItemsSource = primerRepository.GetViewTovars();
        }


        private void AddTovar_Click(object sender, RoutedEventArgs e)
        {
            primerRepository.InsertTovar(tbName.Text);
            GridTovar.ItemsSource = null;
            GridTovar.ItemsSource = primerRepository.GetTovars();

            GridTovarType.ItemsSource = null;
            GridTovarType.ItemsSource = primerRepository.GetViewTovarTypes();
            //GridViewTovar.ItemsSource = null;
            //GridViewTovar.ItemsSource = primerRepository.GetViewTovars();
        }

        private void UpdateTovar_Click(object sender, RoutedEventArgs e)
        {
            Tovar tovar = (Tovar)GridTovar.SelectedItem;
            //tovar.IdTovar; tbName
            primerRepository.UpdateTovar(tovar.IdTovar, tbName.Text);

            GridTovar.ItemsSource = null;
            GridTovar.ItemsSource = primerRepository.GetTovars();

            GridTovarType.ItemsSource = null;
            GridTovarType.ItemsSource = primerRepository.GetViewTovarTypes();

            //GridViewTovar.ItemsSource = null;
            //GridViewTovar.ItemsSource = primerRepository.GetViewTovars();

        }
    }
}
