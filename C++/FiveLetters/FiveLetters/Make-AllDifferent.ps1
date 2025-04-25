param($exe, $inputDir, $outputDir)

# E.g. 
# > .\Make-AllDifferent.ps1 ..\x64\Debug\FiveLetters.exe $env:DATA $env:DATA\FiveLetters\C++

$dictionaryFile = "$($inputDir)\british-english.txt"

$fiveLetterWordsFile = "$($outputDir)\five-letter-words.txt"
Start-Process $exe -NoNewWindow -Wait -ArgumentList 'find_5_letter_words' -RedirectStandardInput $dictionaryFile -RedirectStandardOutput $fiveLetterWordsFile

$allLatinFile = "$($outputDir)\five-letter-words-all-latin.txt"
Start-Process $exe -NoNewWindow -Wait -ArgumentList 'remove_words_with_non_latin' -RedirectStandardInput $fiveLetterWordsFile -RedirectStandardOutput $allLatinFile

$upperFile = "$($outputDir)\five-letter-words-all-latin-upper.txt"
Start-Process $exe -NoNewWindow -Wait -ArgumentList 'to_upper' -RedirectStandardInput $allLatinFile -RedirectStandardOutput $upperFile

$sortedFile = "$($outputDir)\sorted.txt"
Start-Process $exe -NoNewWindow -Wait -ArgumentList 'sort' -RedirectStandardInput $upperFile -RedirectStandardOutput $sortedFile

$uniqueFile = "$($outputDir)\unique-five-letter-words-all-latin-upper.txt"
Start-Process $exe -NoNewWindow -Wait -ArgumentList 'remove_duplicates' -RedirectStandardInput $sortedFile -RedirectStandardOutput $uniqueFile

$allDifferentFile = "$($outputDir)\all-different.txt"
Start-Process $exe -NoNewWindow -Wait -ArgumentList 'all_different' -RedirectStandardInput $uniqueFile -RedirectStandardOutput $allDifferentFile

$anagramsFile = "$($outputDir)\anagrams.txt"
Start-Process $exe -NoNewWindow -Wait -ArgumentList 'anagrams_to_sorted' -RedirectStandardInput $allDifferentFile -RedirectStandardOutput $anagramsFile
