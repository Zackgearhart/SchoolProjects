/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package practice1gearhart;
import java.util.Scanner;
/**
 *
 * @author Zack
 * 8/25/22
 */
public class Practice1Gearhart {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        System.out.println("What is your favorite band?");
        
        Scanner sc = new Scanner(System.in);
        
        String band = sc.nextLine();
        String favorite = "Revocation";
        String hated = "Def Leppard";
        
        if(band.equalsIgnoreCase(favorite)){
            System.out.println(band + " is my favorite band!");
        }else if(band.equalsIgnoreCase(hated)){
            System.out.println("I hate "+band+"!");
        }else{
            System.out.println("I have never listened to "+band+".");
        }
    }
    
}
