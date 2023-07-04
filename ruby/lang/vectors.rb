#!/usr/bin/env ruby

# See Page 30 of "Linear Algebra for Dummies"
# Calculate the magnitude of a vector.

xs = [3.0, 2.0, 4.0]

xs.each { |x| puts x }

sum_of_squares = 0.0

xs.each { |x| sum_of_squares += x * x }

mag = Math.sqrt(sum_of_squares)

puts mag

# Sum of Vectors (page 28)

a = [2.0, 4.0]
b = [3.0, 1.0]

sum_of_a_and_b = []

a.zip(b).each do |element_of_a, element_of_b|
  sum_of_a_and_b.append(element_of_a + element_of_b)
end

sum_of_a_and_b.each { |element| puts element }

# Dot product of two vectors (page 37)

