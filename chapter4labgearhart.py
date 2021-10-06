#Zack Gearhart
#Chapter 4 Lab
#Program to keep track of bottles collected by grocery store

DEPOSIT_PER_BOTTLE = .1

transaction = "y"

while transaction == 'y':
    totalBottles = 0
    dayCounter = 0
    for dayCounter in range(7):
        bottles = int(input("Enter Bottles Collected: "));
        totalBottles += bottles
    payout = totalBottles * DEPOSIT_PER_BOTTLE
    print("\ntotal number of bottles:", format(totalBottles,',.0f'));
    print("Payout for this transation: $", format(payout, ',.2f'));
    transaction = input("\nDo you want to complete another transation? (y or n): ").lower();
print("\nProcess Complete");
