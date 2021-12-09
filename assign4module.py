#Zack Gearhart
#Assign4Module
#Module for Assign4

def getFloat(minValue,maxValue,entry):
    value = float(input("Enter "+ entry + ": "))
    while value < minValue or value > maxValue:
        value = float(input("The " + entry + " must be between " + str(minValue) + " and " + str(maxValue) + ": "))
    return value

def getInt(minValue,maxValue,entry):
    value = int(input("Enter "+ entry + ": "))
    while value < minValue or value > maxValue:
        value = int(input("The " + entry + " must be between " + str(minValue) + " and " + str(maxValue) + ": "))
    return value

def calcFuture(monthInvest, yearIRate, time):
    monthIRate = convertRate(yearIRate) /12
    months = time * 12
    futureValue = 0
    for m in range(months):
        futureValue = (futureValue + monthInvest) * (1 + monthIRate)
    
    return futureValue

def convertRate(value):
    return value * .01

def formatDollar(value):
    return format(value,",.2f")
    
def formatPercentage(value):
    return format(value, ".0%")