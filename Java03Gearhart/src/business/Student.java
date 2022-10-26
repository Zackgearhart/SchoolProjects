/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package business;

/**
 *
 * @author Zack
 */
public class Student extends CollegePerson implements BudgetItem {
    
    private int creditHours;
    private double creditHourCost;

    public Student(){
        super();
        creditHours = -1;
        creditHourCost = -1;
    }
    public Student(String firstName, String lastName, int collegeID, int creditHours, double creditHourCost){
        super(firstName, lastName, collegeID);
        this.creditHours = creditHours;
        this.creditHourCost = creditHourCost;
    }
    @Override
    public String getEmail(){
        return this.getFirstName().toLowerCase() +"." + this.getLastName().toLowerCase() + "@my.college.edu";
    }
    @Override
    public String toString(){
        return this.getFirstName() + " " + this.getLastName() + " " + this.getEmail();
    }

    public int getCreditHours() {
        return creditHours;
    }

    public void setCreditHours(int creditHours) {
        this.creditHours = creditHours;
    }

    public double getCreditHourCost() {
        return creditHourCost;
    }

    public void setCreditHourCost(double creditHourCost) {
        this.creditHourCost = creditHourCost;
    }

    @Override
    public double calcSemesterCost() {
        return ((double) this.creditHours) * this.creditHourCost;
    }
    
}
