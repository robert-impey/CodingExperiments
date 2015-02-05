Import-Module .\Test-RegexWithMatchingAndNonMatchingStrings.psm1

$matching = @('["WA"]', '["WA", "ME"]', '["ME", "WA"]');

$nonMatching = @('[]', '["WA", "WA"]', '["WA", "ME", "WA"]', '["ME", "ME"]');

$regex = '(?<!WA.*)WA(?!.*WA)';

Test-RegexWithMatchingAndNonMatchingStrings $regex $matching $nonMatching

Remove-Module Test-RegexWithMatchingAndNonMatchingStrings
