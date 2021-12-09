#Zack Gearhart
#Assign 4
#Investment Calculator

import assign4module

def main():
    print("\nInvest The Rest Investment Company\n")
    keepGoing = "y"

    while keepGoing == "y":
        monthInvest = assign4module.getFloat(100, 10000, "Monthly Investment")
        yearIRate = assign4module.getFloat(5, 20, "Yearly Interest Rate")
        years = assign4module.getInt(2,30,"Duration of Investment")

        futureInvestment = assign4module.calcFuture(monthInvest, yearIRate, years)

        print("\n****************** Investment Results ******************")
        print("Monthly Investment: $", assign4module.formatDollar(monthInvest))
        print("Interest Rate:", assign4module.formatPercentage(assign4module.convertRate(yearIRate)))
        print("Duration in Years:", years)
        print("Future value of Investment: $", assign4module.formatDollar(futureInvestment))

        keepGoing = input("Another Investment? (Y for yes, N for no): ").lower()

main()