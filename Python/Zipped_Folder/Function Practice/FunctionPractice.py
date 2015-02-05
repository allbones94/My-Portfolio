def outputMessage(name,age):

    if age != "1":
        print "Your name is",name,"and you are",age,"years old"
    else:
        print "Your name is",name,"and you are",age,"year old"

        
myName = raw_input("What is your name: ");
myAge = raw_input("How old are you: ");

outputMessage(myName,myAge)
