﻿using Expectativas_de_Mercado.ViewModel;
using System.Windows;

namespace Expectativas_de_Mercado.WPF;
public partial class MainWindow : Window
{
    private readonly ExpectativasMercadoMensalViewModel viewModel;
    public MainWindow()
    {
        InitializeComponent();
        DpInicio.SelectedDate = DateTime.Now.AddDays(-30);
        DpFim.SelectedDate = DateTime.Now;
        this.viewModel = new ExpectativasMercadoMensalViewModel();
        this.DgExpectativaMercadoMensal.DataContext = viewModel;

    }
    private void BtnPesquisar_Click(object sender, RoutedEventArgs e)
    {
    }
    private void DpInicio_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        DpFim.SelectedDate = DpInicio.SelectedDate?.AddDays(+30);
    }
    private void DpFim_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        DpInicio.SelectedDate = DpFim.SelectedDate?.AddDays(-30);
    }
}