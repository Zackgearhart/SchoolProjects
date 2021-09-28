#Zack Gearhart
#Lab2prg1
#Determine the amount of the bonus based off the number of units produced

producedUnits = int(input("Enter the number of Units Produced: "));

if producedUnits <= 10 or producedUnits >= 10001:
    print("Units produced must be greater than or equal to 10 and less than 10000");
else:
    if producedUnits >= 6001:
        bonus = 200.00
    elif producedUnits >=3001:
        bonus = 100.00
    elif producedUnits >= 1001:
        bonus = 50.00
    elif producedUnits >= 10:
        bonus = 25.00
    else:
        bonus = 0
    print("This year's production bonus will be \n$", format(bonus,".2f"), sep='');
