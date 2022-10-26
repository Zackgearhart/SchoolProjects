/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package practice2gearhart;

import java.text.NumberFormat;
import java.util.Scanner;

/**
 *
 * @author Zack Practice 2 8/27/22
 */
public class Practice2Gearhart {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        String choice = "y";
        while (choice.toLowerCase().equals("y")) {
            Scanner sc = new Scanner(System.in);
            
            System.out.println("What is your name?");
            String name = sc.nextLine();

            System.out.println("What is your email?");
            String email = sc.nextLine();
            
            byte selection = 0;
            byte amount = 0;
            double price = 0;
            boolean noSelection = true;
            
            while (noSelection) {
                System.out.println("Which Item Would You like? "
                        + "Enter the number corresponding to the item. \n"
                        + "1)  T-Shirt = $14.50 \n"
                        + "2)  Sweatshirt = $24.95 \n"
                        + "3)  Coffee Mug = $8.25");
                selection = Byte.parseByte(sc.nextLine());

                if (selection == 1) {
                    price = 14.50;
                    noSelection = false;
                } else if (selection == 2) {
                    price = 24.95;
                    noSelection = false;
                } else if (selection == 3) {
                    price = 8.25;
                    noSelection = false;
                } else {
                    System.out.println("Unknown Item, Try Again \n");
                }
            }
            System.out.println("How Many Would You Like?");
            amount = Byte.parseByte(sc.nextLine()) ;

            price *= amount;

            System.out.println("Name: " + name);
            System.out.println("Email: " + email);
            System.out.println("Total Amount: "
                    + NumberFormat.getCurrencyInstance().format(price));
            System.out.print("Continue? (y/n): ");
            choice = sc.next();
            System.out.println();
        }

    }

}
