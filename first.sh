# this is a comment
msg="hello world"
echo $msg

# control flow
# if statements
ten=10
five=5
thirteen=13

echo "First if"
if [ "$ten" -ge "$five" ]
then
echo "greater!"
fi

echo "Second if"
if [ "$five" -ge "$ten" ]
then
echo "lesser!"
fi

echo "Third if"
if [ "$five" -ge "$ten" ]
then
echo "lesser!"
elif [ "$ten" -ge "$five" ]
then
echo "greater!"
fi

echo "Fourth if"
if [ "$five" -ge "$ten" ]
then
echo "lesser!"
elif [ "$ten" -ge "$thirteen" ]
then
echo "greater!"
else
echo "nothing works!"
fi

# loop statement
# for
echo "For"
for num in {1...10}
do
echo "repeating in $num"
done

#while
echo "While"
while [ "$ten" -ge "$five" ]
do
echo "greater! $five"
five=$(($five+1))
done

#I/O
echo "I/O"
echo "What is your name?"
# read name
echo "Hello $name"

clear
repeat="true"
while [ "$repeat" == true ]
do
echo "Welcome to shell script"
echo "Pick an option below"
echo "enter 1 if you want to add two numbers"
echo "enter 2 if you want to exit"
read ans

if [ "$ans" == "1" ]
then
echo "Give me two numbers"
read num1
read num2
echo "The answer is $(($num1+$num2))"
echo "Press Enter to continue"
read pause
elif [ "$ans" == "2" ]
then
echo "Goodbye!"
repeat="false"
else
echo "Command not found"
fi

clear
done
