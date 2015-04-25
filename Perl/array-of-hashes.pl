#!/usr/bin/env perl

use strict;
use warnings;

my @aohs = ();

push @aohs, { foo => 'bar' };

push @aohs, { 
    apples => 2,
    bananas => 4,
    coconuts => 1
};

for (@aohs) {
    my $hash_ref = $_;
    for (sort keys $hash_ref) {
        print "$_ ", $hash_ref->{$_}, "\n";
    }
    print '-' x 20, "\n";
}
