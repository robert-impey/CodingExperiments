#!/usr/bin/perl

use strict;
use warnings;

my $korean_file_name = "한국어.txt";

if (-f $korean_file_name){
    print "I can see the file.\n"
} else {
    print "I can't see the file!\n"
}

