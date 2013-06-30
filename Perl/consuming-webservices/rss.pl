#!/usr/bin/perl -w
use strict;

use Getopt::Long;
use LWP::Simple;
use XML::RSSLite;

my $url;

GetOptions(
	'u|url=s' => \$url
);

my $xml = get($url);

my %result;

parseRSS(\%result, \$xml);

my @fields = qw/title description link/;

print "=== Channel ===\n";

foreach (qw/title link description language generator lastBuildDate/) {
	print camelCaseToTitleCase($_), ': ', $result{$_}, "\n" if $result{$_};
}

foreach my $item (@{$result{'item'}}) {
	print "\t--- Item ---\n";
	foreach (qw/title link pubDate/) {
		my $title = $_;
		
		print "\t", camelCaseToTitleCase($_), ': ', $item->{$_}, "\n" if $item->{$_};
	}
}

sub camelCaseToTitleCase
{
	my $str = shift;
	$str =~ s/(?=[A-Z])/ /g;
	$str = ucfirst $str;
	return $str;
}
