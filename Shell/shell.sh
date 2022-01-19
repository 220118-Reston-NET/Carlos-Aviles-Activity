mac=5
bynd=6
balance=0
cash=100
bought="false"
repeat="true"

while [ "$repeat" == true ]
do
echo "Welcome to Mcdonalds"
echo "Pick an option"
echo "Enter 1: Order Big Mac"
echo "Enter 2: Order Beyond Burger"
echo "Enter 3: Pay"
echo "Enter 4: Exit"
read ans

if [ "$ans" == "1" ]
then
echo "You ordered a big mac (Cost $mac)."
bought="true"
balance=$(($balance+$mac))
echo "Press any key to continue"
read nothing
elif [ "$ans" == "2" ]
then
echo "You ordered a beyond burger (Cost $bynd)."
bought="true"
balance=$(($balance+$bynd))
echo "Press any key to continue"
read nothing
elif [ "$ans" == "3" ]
then
if [ "$bought" == "false" ]
then
echo "You haven't bought anything!"
echo "Press any key to continue."
read nothing
clear
fi
echo "Your cart total is $balance!"
echo "You held $cash in cash."
cash=$(($cash-$balance))
if [ "$cash" -le "0" ]
then
echo "You don't have the cash to buy that!"
else
echo "You now have $cash left."
balance=0
fi
echo "Press any key to continue"
read nothing
elif [ "$ans" == "4" ]
then
repeat="false"
else
echo "No such command!"
fi

clear
done
