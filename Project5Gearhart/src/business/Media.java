/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package business;

import java.text.NumberFormat;

/**
 *
 * @author Zack
 */
public class Media {

    private String title;
    private double score;
    private double price;
    private String genre;
    public Media(){
        title = "Default";
        score = -1;
        price = -1;
        genre = "Default";
    }
    public Media(String title, double score, double price, String genre){
        this.title = title;
        this.score = score;
        this.price = price;
        this.genre = genre;
    }
    @Override
    public String toString(){
        NumberFormat priceFormatter = NumberFormat.getCurrencyInstance();
        return "Title: "+title + "\nAudience Score: "+ score + "\nPrice: " + priceFormatter.format(price) + "\nGenre: " + genre;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public double getScore() {
        return score;
    }

    public void setScore(double score) {
        this.score = score;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public String getGenre() {
        return genre;
    }

    public void setGenre(String genre) {
        this.genre = genre;
    }
    
}
