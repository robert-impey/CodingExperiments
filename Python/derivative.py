#!/usr/bin/env python3

def f(x: float) -> float:
    return 3.0 * x


point_x = 3.0
nudge = 0.001

f_point = f(point_x)
f_nudge = f(point_x + nudge)

slope = (f_nudge - f_point) / nudge

print(slope)
