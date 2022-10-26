package app;

import java.util.Scanner;
import java.text.NumberFormat;
//Zack Gearhart
//9/3/22
//Practice 3

public class Practice3 {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String choice = "y";
        int counter = 0;
        double totalPrice = 0;

        while (choice.toLowerCase().equals("y")) {
            double price = selectCD(sc);
            int amount = getIntWithinRange(sc, "Select Amount: \t", 0, 1001);
            price *= amount;
            totalPrice += price;
            System.out.print("\n"+amount + " CD(s) for " +  NumberFormat.getCurrencyInstance().format(price));
            System.out.print(" \nContinue? (y/n): ");
            choice = sc.nextLine();
            counter++;
        }

        System.out.println("\n" + counter + " Transaction(s) for a Total Amount of "
                + NumberFormat.getCurrencyInstance().format(totalPrice));

    }

    public static void printOptions() {
        System.out.println("\n1. Revocation CD \t $9.99 \n"
                + "2. Warbringer CD \t $8.99 \n"
                + "3. Nothingness CD \t $7.99 \n"
                + "4. Nickleback CD \t $0.99 \n");
    }

    public static double selectCD(Scanner sc) {
        printOptions();
        double price = 0;

        int selection = getIntWithinRange(sc, "Select CD: \t", 0, 5);
        if (selection == 1) {
            price = 9.99;
        }
        if (selection == 2) {
            price = 8.99;
        }
        if (selection == 3) {
            price = 7.99;
        }
        if (selection == 4) {
            price = 0.99;
        }

        return price;
    }

    public static double getDoubleWithinRange(Scanner sc, String prompt,
            double min, double max) {
        double d = 0;
        boolean isValid = false;
        while (!isValid) {
            d = getDouble(sc, prompt);
            if (d <= min) {
                System.out.println(
                        "Error! Number must be greater than " + min + ".");
            } else if (d >= max) {
                System.out.println(
                        "Error! Number must be less than " + max + ".");
            } else {
                isValid = true;
            }
        }
        return d;
    }

    public static double getDouble(Scanner sc, String prompt) {
        double d = 0;
        boolean isValid = false;
        while (!isValid) {
            System.out.print(prompt);
            if (sc.hasNextDouble()) {
                d = sc.nextDouble();
                isValid = true;
            } else {
                System.out.println("Error! Invalid number. Try again.");
            }
            sc.nextLine();  // discard any other data entered on the line
        }
        return d;
    }

    public static int getIntWithinRange(Scanner sc, String prompt,
            int min, int max) {
        int i = 0;
        boolean isValid = false;
        while (!isValid) {
            i = getInt(sc, prompt);
            if (i <= min) {
                System.out.println(
                        "Error! Number must be greater than " + min + ".");
            } else if (i >= max) {
                System.out.println(
                        "Error! Number must be less than " + max + ".");
            } else {
                isValid = true;
            }
        }
        return i;
    }

    public static int getInt(Scanner sc, String prompt) {
        int i = 0;
        boolean isValid = false;
        while (!isValid) {
            System.out.print(prompt);
            if (sc.hasNextInt()) {
                i = sc.nextInt();
                isValid = true;
            } else {
                System.out.println("Error! Invalid integer. Try again.");
            }
            sc.nextLine();  // discard any other data entered on the line
        }
        return i;
    }

}
