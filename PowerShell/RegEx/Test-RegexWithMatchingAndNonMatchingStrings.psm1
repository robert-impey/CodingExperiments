Function Test-Regex
{
    param($target, $regex, $strings)

    $result = @{
        'passes' = 0
        'tests' = 0
    }

    foreach ($string in $strings)
    {
        $actual = $string -match $regex

        $result['tests']++

        if ($actual -eq $target)
        {
            $result['passes']++
            Write-Host -NoNewline -ForegroundColor Green 'ok'
        }
        else
        {
            Write-Host -NoNewline -ForegroundColor Red 'not ok'
        }


        Write-Host -NoNewline " # $($string) "

        if ($actual) 
        {
            Write-Host 'matches'
        }
        else
        {
            Write-Host 'does not match'
        }
    }

    return $result
}

Function Test-RegexWithMatchingAndNonMatchingStrings
{
    param($regex, $matching, $nonMatching)

    Write-Host "# Regex: $($regex)"

    $matchingResult = Test-Regex $true $regex $matching
    $nonMatchingResult = Test-Regex $false $regex $nonMatching

    $passes = $matchingResult['passes'] + $nonMatchingResult['passes']
    $tests = $matchingResult['tests'] + $nonMatchingResult['tests']

    Write-Host "# $($passes) of $($tests) tests passed"

    if ($tests -eq $passes)
    {
        Write-Host -ForegroundColor Green "# All tests pass"
    }
    else
    {
        Write-Host -ForegroundColor Red "# Some tests failed!"
    }
}

Export-ModuleMember Test-RegexWithMatchingAndNonMatchingStrings
