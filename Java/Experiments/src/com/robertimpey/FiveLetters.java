package com.robertimpey;

import org.jetbrains.annotations.NotNull;

import java.io.BufferedReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.List;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class FiveLetters {
    public static void main(String[] args) throws IOException {
        String dataEnvVar = "DATA";
        String dataDirectory = System.getenv(dataEnvVar);

        if (dataDirectory != null) {
            System.out.printf("Env var '%s': %s\n", dataEnvVar, dataDirectory);

            Path dataPath = Paths.get(dataDirectory);
            Path dictionaryRelativePath = Paths.get("british-english.txt");
            Path dictionaryPath = dataPath.resolve(dictionaryRelativePath);

            if (Files.exists(dictionaryPath)) {
                System.out.printf("Data dictionary file %s exists\n", dictionaryPath);

                List<String> words = readWordsFromFile(dictionaryPath);

                Path outputRelativePath = Paths.get("FiveLetters/Java");
                Path outputPath = dataPath.resolve(outputRelativePath);

                if (!Files.exists(outputPath)) {
                    Files.createDirectory(outputPath);
                }

                fiveLetters(words, outputPath);
            } else {
                System.out.printf("Data dictionary file %s does not exist\n", dictionaryPath);
            }
        } else {
            System.out.printf("Environment variable '%s' is not set.", dataEnvVar);
        }
    }

    private static @NotNull List<String> readWordsFromFile(Path wordsFilePath) throws IOException {
        List<String> words = new ArrayList<>();
        BufferedReader reader = new BufferedReader(new InputStreamReader(Files.newInputStream(wordsFilePath)));
        String line;
        while ((line = reader.readLine()) != null) {
            words.add(line);
        }

        return words;
    }

    private static void writeWordsToFile(@NotNull List<String> words, @NotNull Path path) throws IOException {
        FileWriter writer = new FileWriter(path.toFile());

        for (String word : words) {
            if (5 == word.length()) {
                writer.write(word);
                writer.write(System.lineSeparator());
            }
        }

        writer.close();
    }

    public static void fiveLetters(@NotNull List<String> words, @NotNull Path outputPath) throws IOException {
        Path fiveLetterWordsPath = outputPath.resolve(Paths.get("five-letter-words.txt"));

        List<String> fiveLetterWords;
        if (Files.exists(fiveLetterWordsPath)) {
            System.out.printf("%s exists\nreading...\n", fiveLetterWordsPath);

            fiveLetterWords = readWordsFromFile(fiveLetterWordsPath);
        } else {
            System.out.printf("%s does not exist\ngenerating...\n", fiveLetterWordsPath);
            fiveLetterWords = find5LetterWords(words);
            writeWordsToFile(fiveLetterWords, fiveLetterWordsPath);
        }

        System.out.printf("Found %d 5 letter words\n", fiveLetterWords.toArray().length);

        Path fiveLetterWordsAllLatinPath = outputPath.resolve((Paths.get("five-letter-words-all-latin.txt")));

        List<String> fiveLetterWordsAllLatin;
        if (Files.exists(fiveLetterWordsAllLatinPath)) {
            System.out.printf("%s exists\nreading...\n", fiveLetterWordsAllLatinPath);

            fiveLetterWordsAllLatin = readWordsFromFile(fiveLetterWordsAllLatinPath);
        } else {
            System.out.printf("%s does not exist\ngenerating...\n", fiveLetterWordsAllLatinPath);

            fiveLetterWordsAllLatin = find5LetterWordsAllLatin(fiveLetterWords);
            writeWordsToFile(fiveLetterWordsAllLatin, fiveLetterWordsAllLatinPath);
        }

        System.out.printf("Found %d 5 letter words all Latin\n", fiveLetterWordsAllLatin.toArray().length);

        Path fiveLetterWordsAllLatinUpperPath = outputPath.resolve((Paths.get("five-letter-words-all-latin-upper.txt")));

        List<String> fiveLetterWordsAllLatinUpper;
        if (Files.exists(fiveLetterWordsAllLatinUpperPath)) {
            System.out.printf("%s exists\nreading...\n", fiveLetterWordsAllLatinUpperPath);

            fiveLetterWordsAllLatinUpper = readWordsFromFile(fiveLetterWordsAllLatinUpperPath);
        } else {
            System.out.printf("%s does not exist\ngenerating...\n", fiveLetterWordsAllLatinUpperPath);

            fiveLetterWordsAllLatinUpper = find5LetterWordsAllLatinUpper(fiveLetterWordsAllLatin);
            writeWordsToFile(fiveLetterWordsAllLatinUpper, fiveLetterWordsAllLatinUpperPath);
        }

        System.out.printf("Found %d 5 letter words all Latin, uppercase\n", fiveLetterWordsAllLatinUpper.toArray().length);
    }

    private static @NotNull List<String> find5LetterWords(@NotNull List<String> words) {
        List<String> fiveLetterWords = new ArrayList<>();
        for (String word : words) {
            if (5 == word.length()) {
                fiveLetterWords.add(word);
            }
        }

        return fiveLetterWords;
    }

    private static @NotNull List<String> find5LetterWordsAllLatin(@NotNull List<String> fiveLetterWords) {
        Pattern pattern = Pattern.compile("^[a-z]{5}$", Pattern.CASE_INSENSITIVE);
        List<String> fiveLetterWordsAllLatin = new ArrayList<>();
        for (String word : fiveLetterWords) {
            Matcher matcher = pattern.matcher(word);
            if (matcher.find()) {
                fiveLetterWordsAllLatin.add(word);
            }
        }

        return fiveLetterWordsAllLatin;
    }

    private static @NotNull List<String> find5LetterWordsAllLatinUpper(@NotNull List<String> fiveLetterWordsAllLatin) {
        List<String> fiveLetterWordsAllLatinUpper = new ArrayList<>();
        for (String word : fiveLetterWordsAllLatin) {
            String wordUpper = word.toUpperCase();
            fiveLetterWordsAllLatinUpper.add(wordUpper);
        }

        return fiveLetterWordsAllLatinUpper;
    }
}
