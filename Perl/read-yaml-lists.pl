#!/usr/bin/env perl

use strict;
use warnings;

use File::Slurp;
use YAML::XS qw(Load);

for my $file (@ARGV) {
    my $text = read_file($file);
    
    my @ary = Load($text);

    my $first_ref = shift @ary;
    print join "\n", @{$first_ref};
}
