#!/usr/bin/perl -w
use strict;

my @dad = qw(T T);
my @mum =  qw(T t);

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