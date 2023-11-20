fn main() {
    let mut my_var: i32 = 10;
    println!("my_var is {}", my_var);
    my_var = 20;
    println!("my_var is {}", my_var);

    let x: u8 = 255;
    println!("x is {}", x);

    let years: f64 = 100.0;
    let rate: f64 = 1.01;

    let investment_return = rate.powf(years);

    println!("investment_return is {}", investment_return);
}
