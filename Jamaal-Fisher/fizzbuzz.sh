#!/bin/bash

echo "Input a number between 1 to 20:"
read number

if [ $number -lt 1 ] || [ $number -gt 20 ]
then
	echo "Invalid number.  Please input a number between 1 to 20:"
	read number
    while [ $number -lt 1 ] || [ $number -gt 20 ]
    do
        echo "Invalid number.  Please input a number between 1 to 20:"
	    read number
    done
fi

if [ $((number%3)) -eq 0 ] && [ $((number%5)) -eq 0 ]
then
	echo "FizzBuzz"
elif [ $((number%3)) -eq 0 ]
then
	echo "Fizz"
elif [ $((number%5)) -eq 0 ]
then
	echo "Buzz"
else
	echo $number
fi