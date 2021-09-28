#Zack Gearhart
#Assignment 1
#Figure out the amount of each coins in the inputed amount of change

DOLLAR = 100
QUARTER = 25
DIME = 10
NICKEL = 5
PENNY = 1

inputChange = int(input("Enter the amount of change (in cents): "));

dollar = inputChange // DOLLAR
newChange = inputChange % DOLLAR
q = newChange // QUARTER
newChange = newChange % QUARTER
d = newChange // DIME
newChange = newChange % DIME
n = newChange // NICKEL
newChange = newChange % NICKEL
p = newChange


print("\nThat Makes Cents\n")
print ("Amount of change entered: ", inputChange,"\n",dollar,"Dollars\n", q, "Quarters\n",d, "Dimes\n", n, "Nickel\n", p, "Pennies")