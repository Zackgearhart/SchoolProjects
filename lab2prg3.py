#Zack Gearhart
#Lab2Prg3
#This application will calculate the total charge for a meal with a 15% tip

STATE_SALES_TAX = 0.07
MEAL_TIP_PERCENTAGE = 0.15

costOfMeal = float(input('Enter the cost of your meal: '));
salesTax = costOfMeal * STATE_SALES_TAX;
mealTip = costOfMeal * MEAL_TIP_PERCENTAGE;
totalCost = costOfMeal + salesTax + mealTip;

print('\nAlfred Packer Cafe\n\nCost of meal: $',format(costOfMeal, '.2f'),'\nTax: $', format(salesTax, '.2f'), '\nTip: $', format(mealTip, '.2f'),'\n\nTotal Due: $', format(totalCost, '.2f'));
