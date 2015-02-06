#!/usr/bin/perl -w
use strict;

use RegexTests qw(test_matching_and_non_matching);

my @matching = ('["WA"]', '["WA", "ME"]', '["ME", "WA"]');

my @non_matching = ('[]', '["WA", "WA"]', '["WA", "ME", "WA"]', '["ME", "ME"]');

my $regex = '(?<!WA.*)WA(?!.*WA)';

test_matching_and_non_matching($regex, \@matching, \@non_matching);
