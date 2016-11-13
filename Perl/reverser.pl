#!/usr/bin/perl

use warnings;
use strict;

my $word = shift @ARGV;

if ($word) {
    my @reversed_letters;
    for my $letter (split '', $word) {
        unshift @reversed_letters, $letter;
    }

    print((join '', @reversed_letters), "\n");
}
