#!/usr/bin/perl -w
use strict;

use RegexTests qw(test_matching_and_non_matching);

my @matching = qw(WA WAME MEWA);

my @non_matching = ('', 'WAWA');

my $regex = '(?<!WA)WA(?!WA)';

test_matching_and_non_matching($regex, \@matching, \@non_matching);
