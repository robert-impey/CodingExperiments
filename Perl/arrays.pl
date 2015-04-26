#!/usr/bin/perl -w

use strict;
use warnings;

my @a = qw(fee fi fo fum);

push @a, 'baz';

for(@a) {
    print "$_\n";
}

my $fee = shift @a;

print '-' x 20, "\n";

print "fee: $fee\n";

print '-' x 20, "\n";

for(@a) {
    print "$_\n";
}

my $baz = pop @a;

print '-' x 20, "\n";

print "baz: $baz\n";

print '-' x 20, "\n";

for(@a) {
    print "$_\n";
}

print '-' x 20, "\n";

unshift @a, $fee;

for(@a) {
    print "$_\n";
}
