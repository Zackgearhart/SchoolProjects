/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package practice4;

import java.text.NumberFormat;

/**
 *
 * @author Zack
 */
public class Coach {
    private String fullName;
    private String team;
    private int wins;
    private int loses;
    
    public Coach(){
        this.fullName = "Default";
        this.team = "Default";
        this.wins = -1;
        this.loses = -1;
    }
    
    public Coach(String fullName, String team, int wins, int loses){
        this.fullName = fullName;
        this.team = team;
        this.wins = wins;
        this.loses = loses;
        
    }
    
    public double getWinPerc(){
        int totalWins = this.getWins();
        int totalLoses = this.getLoses();
        double winPerc = (double) totalWins / (double)(totalWins + totalLoses);
        return winPerc;
    }
    public String getWinPercFormatted(){
        NumberFormat percentFormat = NumberFormat.getPercentInstance();
        return percentFormat.format(getWinPerc());
    }
    public String getFullName() {
        return fullName;
    }

    public String getTeam() {
        return team;
    }

    public int getWins() {
        return wins;
    }

    public int getLoses() {
        return loses;
    }

    public void setFullName(String fullName) {
        this.fullName = fullName;
    }

    public void setTeam(String team) {
        this.team = team;
    }

    public void setWins(int wins) {
        this.wins = wins;
    }

    public void setLoses(int loses) {
        this.loses = loses;
    }
}
