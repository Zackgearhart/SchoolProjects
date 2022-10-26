package presentation;

import business.CustomerHelpers;
import business.Customer;
import java.util.ArrayList;
import java.util.Collections;
import validation.Console;

/**
 *
 * @author Fred Scott SCC INFO1414
 */
public class Practice6 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        System.out.println("Practice 6");
        
        ArrayList<Customer> customers = new ArrayList();
        
        customers.add(new Customer("Hicks", "Deondra", "dee@moobys.biz", -1.25));
        customers.add(new Customer("Hicks", "Dante", "clerk@moobys.biz", -37));
        customers.add(new Customer("Graves", "Randal", "berzerker@rstvideo.biz", 8999.99));
        customers.add(new Customer("Hicks", "Dante", "dhicks@quickstop.us", -7.11));
        customers.add(new Customer("Zack", "Gearhart", "zg@zack.com",30000.99));
        customers.add(new Customer("Mac", "Bearhart", "mb@mack.com",-300.99));
        
        String looping = Console.getNonEmptyString("Do you want to add a customer? (y or n): ");
        while(looping.equalsIgnoreCase("y")){
             Customer customer = CustomerHelpers.createCustomer();
             customers.add(customer);
             looping = Console.getNonEmptyString("Do you want to continue? (y or n): ");
        }
        
        Collections.sort(customers);
        System.out.println("\nNegitive Balance:\n");
        CustomerHelpers.iterateCustomers(customers, true);
        System.out.println("\nPositive Balance:\n");
        CustomerHelpers.iterateCustomers(customers, false);

    }

}
