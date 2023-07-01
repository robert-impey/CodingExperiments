#!/usr/bin/env ruby

# See Page 30 of "Linear Algebra for Dummies"
# Calculate the magnitude of a vector.

xs = [3.0, 2.0, 4.0]

xs.each { | x | puts x }

sum_of_squares = 0.0

xs.each { |x| sum_of_squares += x * x }

mag = Math.sqrt(sum_of_squares)

puts mag
