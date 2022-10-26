package presentation;/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
import java.util.Scanner;
import business.Media;
import business.Movie;
import business.Album;
import java.util.Scanner;

import static java.lang.Double.parseDouble;
import static java.lang.Integer.parseInt;

/**
 *
 * @author Zack
 */
public class Project5Gearhart {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("What do you want to make? (Enter the Number)\n\n1) Album\n2) Movie\n");
        int choice = parseInt( sc.nextLine());
        if (choice == 1){
            System.out.println("What is the title of the album?");
            String title = sc.nextLine();
            System.out.println("Who is the artist of the album?");
            String artist = sc.nextLine();
            System.out.println("What is the Audience Score of the album?");
            double score = parseDouble(sc.nextLine());
            System.out.println("What is the price of the album?");
            double price = parseDouble(sc.nextLine());
            System.out.println("What is the genre of the album");
            String genre = sc.nextLine();
            System.out.println("When was the album released?");
            int releaseYear = parseInt( sc.nextLine());
            Media album = new Album(title,score,price,genre,artist,releaseYear);
            System.out.println(album.toString());
        }else if (choice == 2){
            System.out.println("What is the title of the movie?");
            String title = sc.nextLine();
            System.out.println("Who is the director of the movie?");
            String director = sc.nextLine();
            System.out.println("What is the Audience Score of the movie?");
            double score = parseDouble(sc.nextLine());
            System.out.println("What is the price of the movie?");
            double price = parseDouble(sc.nextLine());
            System.out.println("What is the genre of the movie?");
            String genre = sc.nextLine();
            System.out.println("What was the movie rated by the MPAA?");
            String rating = sc.nextLine();
            Media movie = new Movie(title,score,price,genre,director,rating);
            System.out.println(movie.toString());
        }else{
            System.out.println("Unknown, Goodbye!");
        }
    }
    
}
