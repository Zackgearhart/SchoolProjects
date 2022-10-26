/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package presentation;
import validation.Console;
import business.*;

/**
 *
 * @author Zack
 */
public class Java03 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        String stuFirstName = Console.getNonEmptyString("Enter Student First Name: ");
        String stuLastName = Console.getNonEmptyString("Enter Student Last Name: ");
        int stuID = Console.getInt("Enter Student ID Number: ", 100, 999999999);
        int creditHours = Console.getInt("Enter Student Credit Hours: ", 0, 25);
        double creditHourCost = Console.getDouble("Enter Student Credit Hour Cost: ", 50.25, 200.99);
        String facFirstName = Console.getNonEmptyString("Enter Faculty First Name: ");
        String facLastName = Console.getNonEmptyString("Enter Faculty Last Name: ");
        int facID = Console.getInt("Enter Faculty ID Number: ", 100, 999999999);
        double salary = Console.getDouble("Enter Faculty Salary: ", 15000, 300001);
        Student student = new Student(stuFirstName, stuLastName, stuID, creditHours, creditHourCost);
        System.out.println(student.calcSemesterCost());
        Faculty faculty = new Faculty(facFirstName, facLastName, facID, salary);
        System.out.println(student + " Semester Cost:" + student.semesterCostFormatted());
        System.out.println(faculty + " Negative Half of Salary: " + faculty.semesterCostFormatted());
        double balancedBudget = faculty.calcSemesterCost()/ -(student.calcSemesterCost());
        System.out.println("It would take " + balancedBudget + " of the entered student to balance the budget.");
    }
    
}
