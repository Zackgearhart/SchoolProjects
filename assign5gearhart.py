#Zack Gearhart
#12/9/21
#Assign 5 accept multiple test scores from a users.

import validator

def main():
    scores=[]
    backup=[]
    option = 0

    while option != 7:
        option = displayMenu()

        if option == 1:
            addScore(scores)
        elif option ==2:
            displayScores(scores)
        elif option == 3:
            sortScores(scores,backup)
        elif option == 4:
            minMaxScores(scores)
        elif option == 5:
            resetOrder(scores,backup)
        elif option == 6:
            scores = clearScores(scores)
            backup = clearScores(backup)
            print("*****************")
            print("Scores have been cleared")
        else:
            option=getConfirmation()

def displayMenu():
    print("\nScore Calculator menu:")
    print("1. Add test score")
    print("2. Display results")
    print("3. Sort Scores")
    print("4. Low/High scores (Drop high and Low scores)")
    print("5. Reset order")
    print("6. Clear scores")
    print("7. Quit")
    return validator.getInteger(1,7,"Option: ")

def addScore(scores):
    scores.append(validator.getInteger(0,100, "Score: "))

def displayScores(scores):
    if len(scores) > 0:
        count = 0
        for score in scores:
            count +=score
        print("Scores ")
        for score in scores:
            print(score)
        print("Scores Total", count)
        print("Scores count", len(scores))
        avg = count / len(scores)
        print("Scores average is ", format(avg, '.3f'))
    else:
        print("\nNo scores")

def sortScores(scores, backup):
    if len(scores) > 0:
        for score in scores:
            backup.append(score)
        scores.sort()
        print("**************")
        print("Scores in ascending order")
        for score in scores:
            print(score)
    else:
        print("\nNo Scores")

def minMaxScores(scores):
    print("*****************")
    print("Lowest and Highest Scores")
    low = min(scores)
    high = max(scores)
    print("Low score:", low)
    print("High score:", high)
    scores.remove(low)
    scores.remove(high)
    
def resetOrder(scores,backup):
    if len(backup) > 0:
        for x in range(len(scores)):
            scores[x] = backup[x]
        print("**************")
        print("Original order of scores:")
        for score in scores:
            print(score)
    else:
        print("No scores")

def clearScores(scores):
    scores = []
    return scores

def getConfirmation():
    print("You are about to end the Score Calculator")
    confirm = validator.requiredEntry("Enter 'y' to confirm exit")
    if confirm.lower() != 'y':
        return 0
    else:
        return 7

main()