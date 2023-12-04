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

    println!("f64::powf(50.0, 50.0) = {}", f64::powf(50.0, 50.0));
    println!("f64::powf(51.0, 49.0) = {}", f64::powf(51.0, 49.0));
    println!("f64::powf(49.0, 51.0) = {}", f64::powf(49.0, 51.0));
}
