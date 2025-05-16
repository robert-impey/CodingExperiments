package com.robertimpey;

import org.jetbrains.annotations.NotNull;

import java.io.*;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

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

                Path outputRelativePath = Paths.get("FiveLetters/Java");
                Path outputPath = dataPath.resolve(outputRelativePath);

                if (!Files.exists(outputPath)) {
                    Files.createDirectory(outputPath);
                }

                fiveLetters(dictionaryPath, outputPath);
            } else {
                System.out.printf("Data dictionary file %s does not exist\n", dictionaryPath);
            }
        } else {
            System.out.printf("Environment variable '%s' is not set.", dataEnvVar);
        }
    }

    public static void fiveLetters(Path dictionaryPath,
                                   @NotNull Path outputPath) throws IOException {
        Path fiveLetterWordsPath = outputPath.resolve(Paths.get("five-letter-words.txt"));

        if (Files.exists(fiveLetterWordsPath)) {
            System.out.printf("%s exists, skipping generating...", fiveLetterWordsPath);
        } else {
            System.out.printf("%s does not, generating...", fiveLetterWordsPath);
            find5LetterWords(dictionaryPath, fiveLetterWordsPath);
        }
    }

    private static void find5LetterWords(@NotNull Path dictionaryPath,
                                         @NotNull Path fiveLetterWordsPath) throws IOException {
        BufferedReader reader = new BufferedReader(
                new InputStreamReader(
                        Files.newInputStream(dictionaryPath.toFile().toPath())));
        FileWriter writer = new FileWriter(fiveLetterWordsPath.toFile());

        String line;
        while ((line = reader.readLine()) != null) {
            if (5 == line.length()) {
                writer.write(line);
                writer.write(System.lineSeparator());
            }
        }

        writer.close();
    }
}
