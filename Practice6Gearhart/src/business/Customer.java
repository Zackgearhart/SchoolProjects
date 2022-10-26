package business;

import java.text.NumberFormat;

/**
 *
 * @author Fred Scott SCC INFO1414
 */
public class Customer implements Comparable{

    private static int idCounter = 1;
    private int id;
    private String firstName, lastName, email;
    private double balance;

    public Customer() {
        id = idCounter++;
        firstName = null;
        lastName = null;
        email = null;
        balance = 0;
    }

    public Customer(String firstName, String lastName, String email, double balance) {
        this.id = idCounter++;
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        this.balance = balance;
    }
    
    @Override
    public String toString(){
        return "#" + this.id + " " + this.lastName + "," + this.firstName + ": " + this.getBalanceFormatted();
    }

    public int getId() {
        return id;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public double getBalance() {
        return balance;
    }

    public void setBalance(double balance) {
        this.balance = balance;
    }

    public String getBalanceFormatted() {
        NumberFormat currency = NumberFormat.getCurrencyInstance();
        return currency.format(balance);
    }

    @Override
    public int compareTo(Object o) {
       Customer c = (Customer) o;
       int compLast = this.lastName.compareTo(c.getLastName());
       if(compLast !=0){
           return compLast;
       }else{
           int compFirst = this.firstName.compareTo(c.getFirstName());
           if (compFirst != 0){
               return compFirst;
           }else{
                return ((Integer)this.id).compareTo((Integer)c.getId());
           }
       }
    }


}
