﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace BrannbollApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // Skapa variablernma för lagen
    int poängInne = 0;
    int poängUte = 0;

    public MainWindow()
    {
        InitializeComponent();

    }

    private void KlickFrivarv(object sender, RoutedEventArgs e)
    {
        // Lägg till 5 poäng
        poängInne += 5;

        // Skriv ut poängen
        txbInne.Text = $"{poängInne}";

        // Vad är klockan just nu?
        DateTime nu = DateTime.Now;

        // Skriv ut i historiken
        txbHistorik.Text = $"{nu.ToString("HH:mm:ss")}: Lag inne +5, totalt: {poängInne} \n" + txbHistorik.Text;
    }
    private void KlickBränning(object sender, RoutedEventArgs e)
    {
        poängUte += 2;
        txbUte.Text = $"{poängUte}";
        // Vad är klockan just nu?
        DateTime nu = DateTime.Now;
        txbHistorik.Text = $"{nu.ToString("HH:mm:ss")}: Bränning +2 poäng, totalt: {poängUte} \n" + txbHistorik.Text;
    }
    private void KlickLyra(object sender, RoutedEventArgs e)
    {
        poängUte += 3;
        txbUte.Text = $"{poängUte}";
        // Vad är klockan just nu?
        DateTime nu = DateTime.Now;
        txbHistorik.Text = $"{nu.ToString("HH:mm:ss")}: Lyra +3 poäng, totalt: {poängUte} \n" + txbHistorik.Text;
    }
    private void KlickVarv(object sender, RoutedEventArgs e)
    {
        poängInne += 1;
        txbInne.Text = $"{poängInne}";
        // Vad är klockan just nu?
        DateTime nu = DateTime.Now;
        txbHistorik.Text = $"{nu.ToString("HH:mm:ss")}: Varv +1 poäng, totalt: {poängInne} \n" + txbHistorik.Text;
    }
    private void KlickSpara(object sender, RoutedEventArgs e)
    {
        // Filnamn för att spara historiken
        string filnamn = "Historik.txt";

        // Skriv innehållet i txbHistorik till filen
        File.WriteAllText(filnamn, txbHistorik.Text);
    }
}