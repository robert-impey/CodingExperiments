# See Chapter 5, Schaum's Outlines Discrete Mathematics, 2nd Ed. by Lipschutz and Lipson

import numpy as np

u = np.array([2, 3, -4])
v = np.array([1, -5, 8])

print(u + v)

print(5 * u)
print(-1 * v)

print(2 * u - 3 * v)

print(np.dot(u, v))

# Finding the magnitude of a vector
# See https://stackoverflow.com/questions/9171158/how-do-you-get-the-magnitude-of-a-vector-in-numpy
mag_u = np.linalg.norm(u)
print(mag_u)
# Note that in the book this is given as sqrt(29)
print(mag_u * mag_u)

# See https://www.bbc.co.uk/bitesize/guides/zqykv9q/revision/2
p = np.array([3, 7])
mag_p = np.linalg.norm(p)
print(mag_p * mag_p)  # Answer given as sqrt(58)

p_to_q = np.array([5, 4, -2])
mag_p_to_q = np.linalg.norm(p_to_q)
print(mag_p_to_q)
print(mag_p_to_q * mag_p_to_q)  # Answer given as sqrt(45)

a = np.array([5, -1, 2])
b = np.array([7, 9, -2])

a_to_b = b - a
print(a_to_b)

mag_a_to_b = np.linalg.norm(a_to_b)
print(mag_a_to_b)
print(mag_a_to_b * mag_a_to_b)  # Answer given as sqrt(120)
