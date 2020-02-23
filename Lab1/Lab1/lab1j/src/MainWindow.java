import dto.*;
import model.ComputerBuilder;
import sun.plugin2.gluegen.runtime.CPU;

import java.util.LinkedList;
import java.util.List;

/// <summary>
/// Логика взаимодействия для MainWindow.xaml
/// </summary>
public class MainWindow
        {
        ComputerBuilder computerBuilder = new ComputerBuilder();
public MainWindow()
        {

       List<MotherboardDto> d= computerBuilder.Motherboards();
            List<MotherboardDto> d= computerBuilder.SystemUnits();
            List<CPUDto> w=computerBuilder.CPUs();
            List<RAMDto> e= computerBuilder.RAMs();
            List<PowerSupplyDto> t=computerBuilder.PowerSupplies();

            SystemUnitDto b= computerBuilder.ComponResult();
        }



private void ChooseIDSistemUnitButton_Click()
        {
        computerBuilder.setChooseSystemUnit(1);
        }

private void ReloadCompone_Click()
        {
         computerBuilder.ComponResult().ToString();
        }

private void Button_Click()
        {
        computerBuilder.setChooseMotherboard(1);
        }

private void ChooseCPU_Click()
        {
        computerBuilder.setChooseCPU(1);
        }

private void ChooseRam_Click()
        {
        computerBuilder.setChooseRAM(1);
        }

private void ChoosePowerSuplie_Click()
        {
        computerBuilder.setChoosePowerSupply(1);
        }

private void CheckButton_Click( )
        {
         computerBuilder.checkIsCanBeComponeSuchComputer();
        }
        }

