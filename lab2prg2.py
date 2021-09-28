#Zack Gearhart
#Lab2Prg2
#This application will calculate the miles per gallon for a vehicle

startOdometer = float(input("Enter the beginning odometer reading: "));
endOdometer = float(input("Enter the ending odometer reading: "));
gallonsUsed = float(input("Enter the about of gallons used: "));

milesDriven = endOdometer - startOdometer;
mPerGal = milesDriven / gallonsUsed;

print("\nU Auto Know\nThe MPG for the last", format(milesDriven, '.2f'), "miles is", format(mPerGal, '.2f'));