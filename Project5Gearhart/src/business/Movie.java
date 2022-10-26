/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package business;

/**
 *
 * @author Zack
 */
public class Movie extends Media {
    private String director;
    private String rating;
    
    public Movie(){
        super();
        director = "Default";
        rating = "Default";
    }
    public Movie(String title, double score, double price, String genre, String director, String rating){
        super(title, score, price, genre);
        this.director = director;
        this.rating = rating;
    }
    @Override
    public String toString(){
        return "\nMovie \n\n" +super.toString() + "\nDirector: " + director + "\nRated: " + rating + " by MPAA.";
        
    }
    public String getDirector() {
        return director;
    }

    public void setDirector(String director) {
        this.director = director;
    }

    public String getRating() {
        return rating;
    }

    public void setRating(String rating) {
        this.rating = rating;
    }
    
}
