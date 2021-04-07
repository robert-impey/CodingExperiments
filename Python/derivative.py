#!/usr/bin/env python3


def get_slope(out_nudge: float, out_point: float, this_nudge: float) -> float:
    return (out_nudge - out_point) / this_nudge


def f(x: float) -> float:
    return 3.0 * x


point_x = 3.0
nudge = 0.001

f_point = f(point_x)
f_nudge = f(point_x + nudge)

print(get_slope(f_nudge, f_point, nudge))


def g(x: float) -> float:
    return x * x


g_point_2 = g(2.0)
g_nudge_2 = g(2.0 + nudge)

print(get_slope(g_nudge_2, g_point_2, nudge))

g_point_5 = g(5.0)
g_nudge_5 = g(5.0 + nudge)

print(get_slope(g_nudge_5, g_point_5, nudge))
