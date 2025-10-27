fn main() {
    let input = "abc*$%123";

    let alpha_num_chars = input.chars();
    let alpha_num: String = alpha_num_chars.filter(|c| c.is_alphanumeric()).collect();

    // Note that we need to get a new iterator for the input chars here.
    // The char iterator for alpha_num_chars was used when we filtered
    // the alphanumeric chars above.
    let non_alpha_num_chars = input.chars();
    let non_alpha_num: String = non_alpha_num_chars
        .filter(|c| !c.is_alphanumeric())
        .collect();

    println!("Alphanumeric characters: {}", alpha_num);
    println!("Non-alphanumeric characters: {}", non_alpha_num);
}
