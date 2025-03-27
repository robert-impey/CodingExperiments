fn main() {
    let words = [
        "ABBA",
        "48BA",
        "_A",
        "A!"
    ];

    for word in &words {
        println!("filter_non_alphanumeric(\"{}\") = {}", word, filter_non_alphanumeric(word));
    }    
}

fn filter_non_alphanumeric(s: &str) -> String {
    s.chars().filter(|c| c.is_alphanumeric()).collect::<String>()
}