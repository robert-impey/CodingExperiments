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
