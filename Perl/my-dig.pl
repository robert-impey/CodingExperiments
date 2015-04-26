#!/usr/bin/perl

use strict;
use warnings;

use Getopt::Long;

use Net::DNS;

my (
	$domain
);

GetOptions(
	'd|domain=s' => \$domain
);

my $res   = Net::DNS::Resolver->new;
my $query = $res->search($domain);

if ($query) {
	foreach my $rr ($query->answer) {
		print '-' x 20, "\n";
		foreach (qw(name type class ttl rdata rdlength)) {
			print "$_: $rr->{$_}\n";
		}
	}
	print '-' x 20, "\n";
} else {
	warn "Query failed: ", $res->errorstring, "\n";
}

