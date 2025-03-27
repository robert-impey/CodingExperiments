fn main() {
    let xs = [
        0,
        1,
        12,
        123,
        123456789,
        -1,
        -123,
        -123456789,
        1000000
    ];
    
    for x in &xs {
        println!("count_digits_string({}) = {}", x, count_digits_string(*x));
        println!("count_digits_division({}) = {}", x, count_digits_division(*x));
        println!();
    }
}

fn count_digits_string(x: i32) -> usize {
    let x = x.abs();
    let x_str = x.to_string();
    
    x_str.len()
}

fn count_digits_division(x: i32) -> usize {
    let mut x = x.abs();
    let mut count = 0;
    
    while x > 0 {
        x /= 10;
        count += 1;
    }
    
    count
}