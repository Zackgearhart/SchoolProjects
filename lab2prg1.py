#Zack Gearhart
#lab2Prg1
#This application will calculate the remaining number of credits a student needs to complete their program

TOTAL_COURSE_CREDITS = 70

studentName = input("What is the name of the Student?: ");
degreeName = input("What is the name of the Student's Degree?: ");
currentCredits = float(input("How many credits has the student taken currently?: "));
remainingCredits = TOTAL_COURSE_CREDITS - currentCredits;

print("Pass'em College student", studentName, "is in the", degreeName, "program and has", remainingCredits, "left to graduate");
