#!/usr/bin/env python3

fahrenheit = float(input("Please enter the temperature in Fahrenheit"))

celsius = ((fahrenheit - 32) / 9) * 5

print("%.2f F is %.2f C" % (fahrenheit, celsius))
