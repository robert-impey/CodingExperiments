param(
    [Parameter(Mandatory = $true)]
    [Alias('r')]
    [ValidateRange(1, 2147483647)]
    [int]$Runs,

    [Parameter(Mandatory = $true)]
    [Alias('m')]
    [ValidateRange(1, 2147483647)]
    [int]$Max
)

$binarySearch = Join-Path $PSScriptRoot 'BinarySearch.exe'
$times = @{}

foreach ($searchMethod in @('sequential', 'sentinel', 'binary')) {
    for ($i = 0; $i -lt $Runs; $i++) {
        $sought = Get-Random -Minimum 0 -Maximum $Max
        $output = & $binarySearch -m $Max -s $sought -t -r $searchMethod
        $text = $output -join [Environment]::NewLine

        if ($text -match 'Finished searching after (\d+) milliseconds') {
            if (-not $times.ContainsKey($searchMethod)) {
                $times[$searchMethod] = [System.Collections.Generic.List[long]]::new()
            }
            $times[$searchMethod].Add([long]$Matches[1])
        }
    }
}

foreach ($searchMethod in ($times.Keys | Sort-Object)) {
    $sum = [double]0
    foreach ($time in $times[$searchMethod]) {
        $sum += $time
    }
    [string]::Format(
        [Globalization.CultureInfo]::InvariantCulture,
        '{0}: {1:F2}',
        $searchMethod,
        ($sum / $times[$searchMethod].Count)
    )
}
