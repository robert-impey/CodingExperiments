package com.robertimpey.springbootexp;

import java.util.ArrayList;
import java.util.List;

import static org.junit.jupiter.api.Assertions.assertEquals;
import org.junit.jupiter.api.Test;
import org.springframework.boot.test.context.SpringBootTest;

@SpringBootTest
class SpringBootExpApplicationTests {

    @Test
    void contextLoads() {
    }

    @Test
    void find5LetterWords() {
        List<String> words = new ArrayList<>();

        words.add("apple");
        words.add("banana");
        words.add("melon");
        
        var fiveLetterWords = FiveLCommand.find5LetterWords(words);

        assertEquals(2, fiveLetterWords.size());
        
    }
}
