package com.robertimpey;

import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

public class FiveLetters {
    public static void main(String[] args) {
        String dataEnvVar = "DATA";
        String dataDirectory = System.getenv(dataEnvVar);

        if (dataDirectory != null) {
            System.out.printf("Env var '%s': %s\n", dataEnvVar, dataDirectory);

            Path dataPath = Paths.get(dataDirectory);
            Path dictionaryRelativePath = Paths.get("british-english.txt");
            Path dictionaryPath = dataPath.resolve(dictionaryRelativePath);

            if (Files.exists(dictionaryPath)) {
                System.out.printf("Data dictionary file %s exists\n", dictionaryPath);
            } else {
                System.out.printf("Data dictionary file %s does not exist\n", dictionaryPath);
            }
        } else {
            System.out.printf("Environment variable '%s' is not set.", dataEnvVar);
        }
    }
}
