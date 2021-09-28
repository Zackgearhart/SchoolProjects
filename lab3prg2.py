#Zack Gearhart
#lab3prg2
#Determine if a driver gets a discount based on accidents and age

DISCOUNT_AGE = 30
ACCIDENT_THRESHOLD = 5
DISCOUNT_PERCENTAGE = .10

currentRate = float(input("Enter the Current insurance rate: "));
if currentRate >=0 and currentRate <=3000:
    age = int(input("Enter the age of the driver: "));
    if age >= 16 and age <= 90:
        accidents = int(input("Enter the number of accidents the driver has been in: "));
        if accidents >= 0 and accidents <=5:
            if age >= DISCOUNT_AGE and accidents < ACCIDENT_THRESHOLD:
                discountRate = currentRate * DISCOUNT_PERCENTAGE
                print("\nCongratulations! you are entitled to a $", format(discountRate,",.2f"),"discount\n\nThank you for Driving Safely");
            else:
                print("\nYou do not qualify for a discount at this time\n\n Please remember to Drive Safely.");
        else:
            print("\nThe amount of accidents can only be between 0 and 5");   
    else:
        print("\nEnter an age that is between 16 and 90");
else:
    print("\nEnter a rate that is between 0 and 3000");