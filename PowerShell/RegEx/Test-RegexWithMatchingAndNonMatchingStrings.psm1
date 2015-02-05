Function Test-Regex
{
    param($target, $regex, $strings)

    foreach ($string in $strings)
    {
        $actual = $string -match $regex

        if ($actual -ne $target)
        {
            Write-Host -NoNewline 'not '
        }

        Write-Host -NoNewline 'ok'

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
}

Function Test-RegexWithMatchingAndNonMatchingStrings
{
    param($regex, $matching, $nonMatching)

    Write-Host "# Regex: $($regex)"

    Test-Regex $true $regex $matching
    Test-Regex $false $regex $nonMatching
}

Export-ModuleMember Test-RegexWithMatchingAndNonMatchingStrings
