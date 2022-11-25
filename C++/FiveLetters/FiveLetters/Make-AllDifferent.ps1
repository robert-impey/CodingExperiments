param($exe, $dataDir)

$dictionaryFile = "$($dataDir)\british-english.txt"

$fiveLetterWordsFile = "$($dataDir)\five-letter-words.txt"

Start-Process $exe -NoNewWindow -Wait -ArgumentList 'find_5_letter_words' -RedirectStandardInput $dictionaryFile -RedirectStandardOutput $fiveLetterWordsFile

$allLatinFile = "$($dataDir)\five-letter-words-all-latin.txt"
Start-Process $exe -NoNewWindow -Wait -ArgumentList 'remove_words_with_non_latin' -RedirectStandardInput $fiveLetterWordsFile -RedirectStandardOutput $allLatinFile

$upperFile = "$($dataDir)\five-letter-words-all-latin-upper.txt"
Start-Process $exe -NoNewWindow -Wait -ArgumentList 'to_upper' -RedirectStandardInput $allLatinFile -RedirectStandardOutput $upperFile

$sortedFile = "$($dataDir)\sorted.txt"
Start-Process $exe -NoNewWindow -Wait -ArgumentList 'sort' -RedirectStandardInput $upperFile -RedirectStandardOutput $sortedFile

$uniqueFile = "$($dataDir)\unique-five-letter-words-all-latin-upper.txt"
Start-Process $exe -NoNewWindow -Wait -ArgumentList 'remove_duplicates' -RedirectStandardInput $sortedFile -RedirectStandardOutput $uniqueFile

$allDifferentFile = "$($dataDir)\all-different.txt"
Start-Process $exe -NoNewWindow -Wait -ArgumentList 'all_different' -RedirectStandardInput $uniqueFile -RedirectStandardOutput $allDifferentFile
