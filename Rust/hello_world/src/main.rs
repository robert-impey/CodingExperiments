use std::collections::{BTreeMap};
use num_bigint::ToBigUint;

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

    let mut powers : BTreeMap<num_bigint::BigUint, &str> = BTreeMap::new();

    powers.insert( 50.to_biguint().unwrap().pow(50), "50 ^ 50");
    powers.insert( 51.to_biguint().unwrap().pow(49), "51 ^ 49");
    powers.insert( 49.to_biguint().unwrap().pow(51), "49 ^ 51");

    for (k, v) in powers {
        println!("{} = {}", v, k);
    }
}
