Import-Module .\Test-RegexWithMatchingAndNonMatchingStrings.psm1

$regex = '(?<!WA.*)WA(?!.*WA)';

$matching = @('["WA"]', '["WA", "ME"]', '["ME", "WA"]');
$nonMatching = @('[]', '["WA", "WA"]', '["WA", "ME", "WA"]', '["ME", "ME"]');

Test-RegexWithMatchingAndNonMatchingStrings $regex $matching $nonMatching

Remove-Module Test-RegexWithMatchingAndNonMatchingStrings
