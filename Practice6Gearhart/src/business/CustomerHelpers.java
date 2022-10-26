package business;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
import business.Customer;
import java.util.ArrayList;
import validation.Console;

/**
 *
 * @author zack
 */
public class CustomerHelpers {

    public static Customer createCustomer() {
        String firstName = Console.getNonEmptyString("Enter Customer First Name: ");
        String lastName = Console.getNonEmptyString("Enter Customer Last Name: ");
        String email = Console.getNonEmptyString("Enter Customer Email: ");
        double balance = Console.getDouble("Enter Customer Balance: ", -1000000, 1000000);
        return new Customer(firstName, lastName, email, balance);
    }
    
    public static void iterateCustomers(ArrayList<Customer> customers, boolean negativeBalance){
        for(Customer customer : customers){
            if(negativeBalance && customer.getBalance()<=0){
                System.out.println(customer);
            }else if (!negativeBalance && customer.getBalance() > 0){
                System.out.println(customer);
            }
        }
    }
}
