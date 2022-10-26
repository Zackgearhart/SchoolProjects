/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package practice4;

import java.text.NumberFormat;
import java.util.Scanner;

/**
 *
 * @author Fred Scott SCC INFO1414
 */
public class Practice4 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        String again = "Y";
        while (again.equalsIgnoreCase("Y")) {
            String coachAName = Console.getString("Enter name for the first Coach: ");
            String coachBName = Console.getString("Enter name for the second Coach: ");
            String coachATeam = Console.getString("Enter team name for the first Coach: ");
            String coachBTeam = Console.getString("Enter team name for the second Coach: ");
            int coachAWins = Console.getInt("Enter number of wins for the first Coach: ",-1,10001);
            int coachBWins = Console.getInt("Enter number of wins for the second Coach: ",-1,10001);
            int coachALoses = Console.getInt("Enter number of loses for the first Coach: ",-1,10001);
            int coachBLoses =  Console.getInt("Enter number of loses for the second Coach: ",-1,10001);
            
            Coach coachA = new Coach(coachAName, coachATeam, coachAWins, coachALoses);
            Coach coachB = new Coach(coachBName, coachBTeam, coachBWins, coachBLoses);
            
            if (coachA.getWinPerc() > coachB.getWinPerc()) {
                System.out.println(coachA.getFullName() + " the coach of the " + coachA.getTeam() + " has " + coachA.getWins() 
                        + " wins and " + coachA.getLoses() + " loses for a winning percentage of " + coachA.getWinPercFormatted());
            } else if (coachB.getWinPerc() > coachB.getWinPerc()) {
                System.out.println(coachB.getFullName() + " the coach of the " + coachB.getTeam() + " has " + coachB.getWins() 
                        + " wins and " + coachB.getLoses() + " loses for a winning percentage of " + coachB.getWinPercFormatted());
            } else {
                System.out.println(coachB.getFullName() + " has a win percentage of " + coachB.getWinPercFormatted()+ " and " 
                        + coachA.getFullName() + " has a win percentage of "+coachA.getWinPercFormatted() + ". They have the same record.");
            }
            
            again = Console.getString("Continue? (y/n): ");
        }

    }

}
