use std::collections::BTreeMap;
use std::{fs::File, collections::HashMap};
use std::io::{self,BufRead};

fn main() {
    let file_path = "alice_chapter_1";

    let file: File = File::open(file_path).unwrap();

    let reader =  io::BufReader::new(file);
    let mut counts: HashMap<String, u32> = HashMap::new();

    for line in reader.lines() {
        let unwrapped_line = line.unwrap().to_lowercase();

        let words: Vec<String> = unwrapped_line
            .split_whitespace()
            .map(|w|w.to_string())
            .collect();

        for word in words {
            let count = counts.get(&*word);

            let updated_count = match count {
                Some(cnt) => cnt +1,
                None => 1,
            };

            counts.insert(word, updated_count);
        }
    }

    let mut counter_b: BTreeMap<u32, Vec<String>> = BTreeMap::new();

    for (k,v) in counts {
        let words_of_count = counter_b.get(&v);

        let mut words = match words_of_count {
            Some(ws) => ws.to_vec(),
            None => vec![],
        };

        words.push(k);

        counter_b.insert(v, words);
    }

    for (k,v) in counter_b {
        println!("The {} word(s) that occur(s) {} times: {}",  v.len(), k, v.join(", "));
    }
}
