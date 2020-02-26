using Lab1Code.model;
using System;
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
using Lab1.model;

namespace Lab1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IComputerBuilder computerBuilder = new ComputerBuilder();
        public MainWindow()
        {
            InitializeComponent();

            MotherboardGreedView.ItemsSource = computerBuilder.Motherboards();
            SystemUnitsGreedView.ItemsSource = computerBuilder.SystemUnits();
            CPUGreedView.ItemsSource = computerBuilder.CPUs();
            RamGreedView.ItemsSource = computerBuilder.RAMs();
            PowerSupplyGreedView.ItemsSource = computerBuilder.PowerSupplies();

            ResultChoosesTextBox.Text = computerBuilder.ComponResult().ToString();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void ChooseIDSistemUnitButton_Click(object sender, RoutedEventArgs e)
        {
            computerBuilder.setChooseSystemUnit(SystemUnitsGreedView.SelectedIndex);
        }

        private void ReloadCompone_Click(object sender, RoutedEventArgs e)
        {
            ResultChoosesTextBox.Text = computerBuilder.ComponResult().ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            computerBuilder.setChooseMotherboard(MotherboardGreedView.SelectedIndex); 
        }

        private void ChooseCPU_Click(object sender, RoutedEventArgs e)
        {
            computerBuilder.setChooseCPU(CPUGreedView.SelectedIndex);
        }

        private void ChooseRam_Click(object sender, RoutedEventArgs e)
        {
            computerBuilder.setChooseRAM(RamGreedView.SelectedIndex);
        }

        private void ChoosePowerSuplie_Click(object sender, RoutedEventArgs e)
        {
            computerBuilder.setChoosePowerSupply(PowerSupplyGreedView.SelectedIndex);
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            ResaltOfCheck.Text= computerBuilder.checkIsCanBeComponeSuchComputer().ToString();
        }
    }
}
