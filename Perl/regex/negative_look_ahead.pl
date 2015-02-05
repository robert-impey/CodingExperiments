#!/usr/bin/perl -w
use strict;

use RegexTests qw(test_matching_and_non_matching);

my @matching = qw(q qq qv);

my @non_matching = qw(qu qvu);
push @non_matching, '', 'q u', 'q"u', '"q", "u"', '["q", "u"]';

my $regex = 'q(?!.*u)';

test_matching_and_non_matching($regex, \@matching, \@non_matching);
