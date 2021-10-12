#Zack Gearhart
#estimate the cost of tuition and fees to complete 2 years of college including one suummer term
#Assign3

CREDIT_HOUR_PRICE = 102.00;
FACILITY_FEE = 9.00;
STUDENT_ACTIVIES_FEE = 3.00;
GRADUATION_FEE = 35;
END = 'n';
terms = 5;
totalCredits = 0;

for term in range(1, terms + 1):
    credits = 1;
    termCredits = 0;
    courseCalculation = 'y';
    courseNumber = 1;
    while courseCalculation != END:
        credits = float(input("\nEnter credits for Course " + str(courseNumber) + " Term " + str(term) + ": "));
        while credits < .5 or credits > 4:
            credits = float(input("Please Re-Enter Credits, must be between .5 and 4.0: "));
        termCredits += credits;
        courseNumber += 1;
        courseCalculation = input("Enter ‘y’ to continue to the next course - Enter ‘n’ to calculate the total for the Term: ").lower();
    totalCredits += termCredits;
    tuitionPrice = termCredits * CREDIT_HOUR_PRICE;
    facilityPrice = termCredits * FACILITY_FEE 
    studentFee = termCredits * STUDENT_ACTIVIES_FEE;
    totalPrice = tuitionPrice + facilityPrice + studentFee;
    print ("\n**************** Total for Semester " + str(term) + " ********************\n");
    print ("Credfits:", format(termCredits, '.1f'), " Term Credits");
    print ("Tuition: $", format(tuitionPrice, ',.2f'),",Term Tuition Due");
    print ("Total Facility Fees: $", format(facilityPrice,'.2f'), "Term fees due");
    print ("Total Student Activity Fees: $", format(studentFee,'.2f'), "Term fees due");
    print ("Total Tuition Cost: $", format(totalPrice,'.2f'), "Term cost for the degree");
tuitionPrice = totalCredits * CREDIT_HOUR_PRICE;
feePrice = totalCredits * FACILITY_FEE + totalCredits * STUDENT_ACTIVIES_FEE;
totalPrice = tuitionPrice + feePrice + GRADUATION_FEE;
print ("\n**************** Total for degree ********************\n");
print ("Credits:", format(totalCredits,'.1f'), " Term Credits");
print ("Tuition: $", format(tuitionPrice,',.2f'),",Term Tuition due");
print ("Total Fees: $", format(feePrice,',.2f'), "Term fees due");
print ("Total Tuition Cost: $", format(totalPrice, ',.2f'), "Term cost for the degree");
    