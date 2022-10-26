/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package business;

/**
 *
 * @author Zack
 */
public class Faculty extends CollegePerson implements BudgetItem{
    private double salary;

    public Faculty() {
        super();
        this.salary = -1;
    }

    public Faculty(String firstName, String lastName, int collegeID, double salary) {
        super(firstName, lastName, collegeID);
        this.salary = salary;
    }
    

    @Override
    public String getEmail() {
        return this.getFirstName().toLowerCase() +"." + this.getLastName().toLowerCase() + "@college.edu";
    }
    @Override
    public String toString(){
        return this.getFirstName() + " " + this.getLastName() + " " + this.getEmail();
    }

    public double getSalary() {
        return salary;
    }

    public void setSalary(double salary) {
        this.salary = salary;
    }

    @Override
    public double calcSemesterCost() {
        return -(this.salary/2);
    }
    
    
}
