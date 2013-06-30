#!/usr/bin/perl

use strict;
use warnings;

grep ({print "$_\n"} qw(foo bar baz));

print '-' x 40, "\n";

print grep (' ', qw(foo bar baz));

print "\n";

