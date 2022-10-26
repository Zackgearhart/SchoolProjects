/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package business;

/**
 *
 * @author Zack
 */
public class Album extends Media {
    private String artist;
    private int releaseYear;
    
    public Album(){
        super();
        artist = "default";
        releaseYear = -1;
    }
    public Album(String title, double score, double price, String genre, String artist, int releaseYear){
        super(title, score, price, genre);
        this.artist = artist;
        this.releaseYear = releaseYear;
    }
    @Override
    public String toString(){
        return "\nAlbum \n\n" + super.toString() + "\nArtist: " + artist + "\nReleased: " + releaseYear;
        
    }

    public String getArtist() {
        return artist;
    }

    public void setArtist(String artist) {
        this.artist = artist;
    }

    public int getReleaseYear() {
        return releaseYear;
    }

    public void setReleaseYear(int releaseYear) {
        this.releaseYear = releaseYear;
    }
}
