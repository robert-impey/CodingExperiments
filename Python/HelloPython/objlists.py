#!/usr/bin/env python

class Foo:
    def __init__(self, text, number):
        self.text = text
        self.number = number

    def __str__(self):
        return "{ text: %s, number: %d }" % (self.text, self.number)

    def __repr__(self):
        return str(self)

a_foo = Foo('a', 1)

print "a_foo: %s" % a_foo

b_foo = Foo('b', 2)

print "b_foo: %s" % b_foo

foos = [a_foo, b_foo]

print "foos: %s" % foos
