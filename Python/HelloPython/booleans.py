#!/usr/bin/env python3

def i_say_which_function_i_am(order):
    print("I'm function number ", order) 

def tell_me_true(order):
    i_say_which_function_i_am(order)
    print("I'm going to return True!")
    return True

def tell_me_false(order):
    i_say_which_function_i_am(order)
    print("I'm going to return False!")
    return False

def i_say_what_i_get(boolean_expression):
    if boolean_expression:
        print("I got a true expression!")
    else:
        print("I got a false expression!")
    print()

i_say_what_i_get(tell_me_false(1) and not tell_me_true(2) or tell_me_false(3))
i_say_what_i_get(tell_me_false(1) or tell_me_false(2))
i_say_what_i_get(tell_me_true(1) or tell_me_false(2))
i_say_what_i_get(tell_me_false(1) and tell_me_true(2) or tell_me_false(3))
i_say_what_i_get(tell_me_true(1) and tell_me_false(2) or tell_me_false(3))
i_say_what_i_get(tell_me_true(1) and tell_me_true(2) or tell_me_false(3))
i_say_what_i_get(tell_me_true(1) and not tell_me_false(2) or tell_me_false(3))

