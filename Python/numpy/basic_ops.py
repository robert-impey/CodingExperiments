#!/usr/bin/env python3

# https://numpy.org/doc/stable/user/quickstart.html#basic-operations

from math import pi

import numpy as np

a = np.array([20, 30, 40, 50])
b = np.arange(4)

c = a - b

A = np.array([[1, 1], [0, 1]])

B = np.array([[2, 0], [3, 4]])

# >>> basic_ops.A * basic_ops.B
# array([[2, 0],
#        [0, 4]])
# >>> basic_ops.A @ basic_ops.B
# array([[5, 4],
#        [3, 4]])
# >>> basic_ops.A.dot(basic_ops.B)
# array([[5, 4],
#        [3, 4]])

a = np.ones((2, 3), dtype=int)

# >>> basic_ops.a *= 3
# >>> basic_ops.a
# array([[3, 3, 3],
#        [3, 3, 3]])

rg = np.random.default_rng(1)
b = rg.random((2, 3))

# >> basic_ops.b += basic_ops.a
# >>>
# >>>
# >>> basic_ops.b
# array([[3.51182162, 3.9504637 , 3.14415961],
#        [3.94864945, 3.31183145, 3.42332645]])
# >>>
# >>>
# >>>
# >>> basic_ops.b += basic_ops.a
# >>> basic_ops.b
# array([[6.51182162, 6.9504637 , 6.14415961],
#        [6.94864945, 6.31183145, 6.42332645]])
# >>>

# But
# >>> basic_ops.a += basic_ops.b
# Traceback (most recent call last):
#   File "<stdin>", line 1, in <module>
#     basic_ops.a += basic_ops.b
# numpy._core._exceptions._UFuncOutputCastingError: Cannot cast ufunc 'add' output from dtype('float64') to dtype('int64') with casting rule 'same_kind'
# >>>

a = np.ones(3, dtype=np.int32)
b = np.linspace(0, pi, 3)

# >>> basic_ops.b.dtype.name
# 'float64'
# >>>

# Inplace addition fails, but we can create a new array

# c = basic_ops.a + basic_ops.b
# >>>
# >>> c
# array([1.        , 2.57079633, 4.14159265])
# >>>

c = a + b
d = np.exp(c * 1j)

# >>> basic_ops.d
# array([ 0.54030231+0.84147098j, -0.84147098+0.54030231j,
#        -0.54030231-0.84147098j])
# >>>
# >>>
# >>> basic_ops.d.dtype.name
# 'complex128'
# >>>

a = rg.random((2, 3))

# >>> basic_ops.a
# array([[0.82770259, 0.40919914, 0.54959369],
#        [0.02755911, 0.75351311, 0.53814331]])
# >>> 
# >>> 
# >>> 
# >>> basic_ops.a.sum()
# np.float64(3.1057109529998157)
# >>> 
# >>> 
# >>> basic_ops.a.min()
# np.float64(0.027559113243068367)
# >>> basic_ops.a.max()
# np.float64(0.8277025938204418)
# >>> 

b = np.arange(12).reshape(3, 4)

# >>> basic_ops.b
# array([[ 0,  1,  2,  3],
#        [ 4,  5,  6,  7],
#        [ 8,  9, 10, 11]])
# >>> 
# >>> 
# >>> basic_ops.b.sum(axis=0)
# array([12, 15, 18, 21])
# >>> basic_ops.b.min(axis=1)
# array([0, 4, 8])
# >>> basic_ops.b.cumsum(axis=1)
# array([[ 0,  1,  3,  6],
#        [ 4,  9, 15, 22],
#        [ 8, 17, 27, 38]])
# >>> 

def main():
    print(b)
    print(c)

    print(b**2)
    print(10 * np.sin(a))

    print(a < 35)


if __name__ == "__main__":
    main()
