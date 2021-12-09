#This module contains Validation Functions
# these are generic validation and can be used with any program

def isNumeric( message):
    value = input("Enter " + message + " ")
    while not(value.isdigit()):
        value = input( message + " must be numeric " )
    # value returned is string    
    return value
        
def getInteger(min, max, message):
    value = int(input("Enter " + message + " "))
    while value < min or value > max:
        value = int(input( message + " must be within range of " +
                           str(min) + " to " + str(max)+ " "))
    return value

def getFloat(min, max, message):
    value = float(isNumeric(message))
    while value < min or value > max:
        value = float(input( message + " must be within range of " +
                             str(min) + " to " + str(max)+ " "))
    return value

def requiredEntry(message):
    value =  input("Enter " + message + " ")
    while value == "":
        value = input(message + " is required, Please re-enter ")
    return value

def isAlphabetic(message):
    entry = input("Enter " + message + " ")
    while not(entry.isalpha()):
        #print("Enter a Value within range of " + str(min) + " to " + str(max))
        entry = input(message + " must be alphabetic, Please re-enter ")
    return entry