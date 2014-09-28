#!/bin/bash

echo $1

if [ -z $1 ]; then
	echo "Nothing set!"
else
	echo $1
fi
