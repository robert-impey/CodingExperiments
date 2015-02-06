#!/usr/bin/perl -w
use strict;

my $dadStr = shift @ARGV;
my $mumStr = shift @ARGV;

my @dad = split //, $dadStr;
my @mum = split //, $mumStr;

sub make_gametes
{
    return (
        [$_[0], $_[2]],
        [$_[0], $_[3]],
        [$_[1], $_[2]],
        [$_[1], $_[3]]
    )
}

my @dad_gametes = make_gametes @dad;
my @mum_gametes = make_gametes @mum;

print ' ' x 3;
for (@dad_gametes) {
    print ' ';
    for (@$_) {
        print $_
    }
    print '  ';
}
print "\n";

print '-' x (2 + 5 * 4), "\n";

for (@mum_gametes) {
    my @mum_gamete = @$_;
    
    for (@mum_gamete) {
        print $_;
    }
    
    print '|';
    
    for (@dad_gametes) {
        my @dad_gamete = @$_;
        
        print $dad_gamete[0], $mum_gamete[0];
        print $dad_gamete[1], $mum_gamete[1];
        
        print ' ';
    }
    
    print "\n";
}
