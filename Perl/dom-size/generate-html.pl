#!/usr/bin/perl -w
use strict;

foreach (0..6) { system 'many-paragraphs.pl ' . 10 ** $_ }
