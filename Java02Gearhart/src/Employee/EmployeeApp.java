/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package Employee;

import java.text.NumberFormat;

/**
 *
 * @author Fred Scott SCC INFO1414
 */
public class EmployeeApp {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        String again = "Y";
        int counter = 0;
        double totalPay = 0;
        while (again.equalsIgnoreCase("Y")) {
            String firstName = Console.getNonEmptyString("Employee First Name: ");
            String lastName = Console.getNonEmptyString("Employee Last Name: ");
            String eMail = Console.getNonEmptyString("Employee Email: ");
            double hours = Console.getDouble("Employee Hours Worked: ", -1, 91);
            double rate = Console.getDouble("Employee Hourly Rate: ", 9, 43);
            Employee employee = new Employee(firstName, lastName, eMail, hours, rate);
            totalPay += employee.getEmployeePay();
            counter++;
            System.out.println(employee.getFirstName() + "'s pay is " + employee.getEmployeePayFormatted());
            again = Console.getNonEmptyString("Continue? (y/n): ");
        }
        double average = totalPay / counter;
        NumberFormat averageFormatter = NumberFormat.getCurrencyInstance();
        System.out.println(counter + " total employee(s) for an average pay of " + averageFormatter.format(average));
    }
}
