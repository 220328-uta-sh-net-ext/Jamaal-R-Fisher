#!/bin/bash

read -r N

f0=0
f1=1

for (( i=0; i<N; i++ ))
    do
        echo -n "$f1, "
        fn=$(( f0 + f1 ))
        f0=$f1
        f1=$fn
    done

Num=(${output[${#output[@]}-1]})
sum=$Num
x=0
 
while [ $Num -gt 0 ]
    do
        y=$(( $Num % 10 ))
        Num=$(( $Num / 10 ))
        x=$(( $x + $y ))
    done
echo  "$x"