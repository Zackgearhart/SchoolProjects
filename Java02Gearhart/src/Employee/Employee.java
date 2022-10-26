/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Employee;

import java.text.NumberFormat;

/**
 *
 * @author Zack
 */
public class Employee {
    String firstName, lastName,eMail;
    double hours, rate;

    public Employee() {
        firstName = "Default";
        lastName = "Default";
        eMail = "Default";
        hours = -1;
        rate = -1;
    }

    public Employee(String firstName, String lastName, String eMail, double hours, double rate) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.eMail = eMail;
        this.hours = hours;
        this.rate = rate;
    }
    public double getEmployeePay(){
        if (hours>40){
            return 40*rate + (hours - 40)*rate*1.5;
        }else{
            return hours*rate;
        }
    }
    public String getEmployeePayFormatted(){
        double pay = getEmployeePay();
        NumberFormat payFormatter = NumberFormat.getCurrencyInstance();
        return payFormatter.format(pay);
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public void seteMail(String eMail) {
        this.eMail = eMail;
    }

    public void setHours(double hours) {
        this.hours = hours;
    }

    public void setRate(double rate) {
        this.rate = rate;
    }

    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public String geteMail() {
        return eMail;
    }

    public double getHours() {
        return hours;
    }

    public double getRate() {
        return rate;
    }
    
}
