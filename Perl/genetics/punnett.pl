#!/usr/bin/env perl

use strict;
use warnings;

my $dadStr = shift @ARGV;
my $mumStr = shift @ARGV;

my @dad = split //, $dadStr;
my @mum = split //, $mumStr;

print ' |';

for (@dad) {
    print "$_ ";
}

print "\n";

print "-|";

for (@dad) {
    print '--';
}

print "\n";

for my $from_mum (@mum) {
    print "$from_mum|";
    
    for my $from_dad (@dad) {
        print $from_dad;
        print $from_mum;
    }
    
    print "\n";    
}