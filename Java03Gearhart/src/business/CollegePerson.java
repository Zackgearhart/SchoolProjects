package business;

public abstract class CollegePerson {
    private String firstName;
    private String lastName;
    private int collegeID;

    public CollegePerson(){
        firstName = "Default";
        lastName = "Default";
        collegeID = -1;
    }
    public CollegePerson(String firstName, String lastName, int collegeID) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.collegeID = collegeID;
    }
    public abstract String getEmail();
    
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

    public int getCollegeID() {
        return collegeID;
    }

    public void setCollegeID(int collegeID) {
        this.collegeID = collegeID;
    }



}
