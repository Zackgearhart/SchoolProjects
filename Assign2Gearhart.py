#Zack Gearhart
#Assign 2
#Calculate the cost of a desk

START_PRICE = 200
SQFT_CHARGE_THRESHOLD = 15
ADDITIONAL_CHARGE = 50
PINE_COST = 7.50
OAK_COST = 10.75
MAHOGANY_COST = 20.25
OTHER_WOOD_CHARGE = 35
DRAWER_CHARGE_PRICE = 50
DRAWER_CHARGE_THRESHOLD = 2

print("EZ Build Furniture Comapny\n");
print("Design a desk\n");
print("***********************************\n");
surfaceArea = float(input("Enter the surface area of the desk: \n"));
wood = input("Enter type of wood: \n");
drawers = int(input("Enter the number of drawers: \n"));
cost = START_PRICE;
discount = 0;

if surfaceArea >= SQFT_CHARGE_THRESHOLD:
    cost = cost + ADDITIONAL_CHARGE
    
if wood == "PINE" or wood == "pine" or wood == "Pine":
    woodChg = PINE_COST * surfaceArea
elif wood == "OAK" or wood == "oak" or wood == "Oak":
    woodChg = OAK_COST * surfaceArea
elif wood == "MAHOGANY" or wood == "mahogany" or wood == "Mahogany":
    woodChg = MAHOGANY_COST * surfaceArea
else:
    woodChg = OTHER_WOOD_CHARGE * surfaceArea
    
cost = cost + woodChg
    
if drawers > DRAWER_CHARGE_THRESHOLD:
    drawerChg = (drawers - DRAWER_CHARGE_THRESHOLD) * DRAWER_CHARGE_PRICE
    cost = cost + drawerChg
    
if surfaceArea > 15 and (woodChg == MAHOGANY_COST * surfaceArea or woodChg == OAK_COST * surfaceArea):
    discountPercentage = "24%"
    discount = cost * .24
elif woodChg == OAK_COST * surfaceArea and drawers >= 3:
    discountPercentage = "15%"
    discount = cost * .15
elif cost > 500:
    discountPercentage = "5%"
    discount = cost *.05
    
discountCost = cost - discount
    
if discount > 0:
    print("\nTotal price of the desk is: $", format(cost, ",.2f"));
    print("\nDiscount price of the desk is: $", format(discountCost, ",.2f"));
    print("\nYou qualified for a",discountPercentage,"discount and saved $", format(discount, ",.2f"));
else: 
    print("\nTotal price of the desk is: $", format(cost, ",.2f"))
