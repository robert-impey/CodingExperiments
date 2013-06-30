#!/usr/bin/perl -w
use strict;

my $numberOfParagraphs = shift @ARGV or &usage;
&usage unless $numberOfParagraphs =~ /^\d+$/;

my $fileName = "many-paragraphs-$numberOfParagraphs.html";
my $title = "$numberOfParagraphs Paragraphs";
open FILE, '>', $fileName or die $!;

print FILE <<HTML;
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01//EN"
    "http://www.w3.org/TR/html4/strict.dtd">
<html lang="en">
<head>
    <title>$title</title>
</head>
<body>
    <h1>$title</h1>
HTML

my $counter = 0;
while ($counter < $numberOfParagraphs) {
	print FILE "<p id=\"p$counter\">Paragraph $counter</p>\n";
	$counter++;
}

print FILE <<HTML;
</body>
</html>
HTML

sub usage()
{
	die "Please give me a counting number!\n"
}
