fn main() {
    let words = [
        "ABBA",
        "ABAB",
        "A",
        "ABA",
        "ABAA"
    ];
    
    for word in &words {
        println!("is_palindrome_reverse(\"{}\") = {}", word, is_palindrome_reverse(word));
        println!("is_palindrome_index(\"{}\") = {}", word, is_palindrome_index(word));
        println!()
    }
}

fn is_palindrome_reverse(s: &str) -> bool {
    let s = s.to_lowercase();
    let s = s.chars().filter(|c| c.is_alphanumeric()).collect::<String>();
    let s_rev = s.chars().rev().collect::<String>();
    s == s_rev
}

fn is_palindrome_index(s: &str) -> bool {
    let s = s.to_lowercase();
    let s = s.chars().filter(|c| c.is_alphanumeric()).collect::<String>();
    let s = s.as_bytes();
    let mut i = 0;
    let mut j = s.len() - 1;
    while i < j {
        if s[i] == s[j] {
            i += 1;
            j -= 1;
        } else {
            return false;
        }
    }
    true
}