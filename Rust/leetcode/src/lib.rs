#![allow(dead_code)]

// https://leetcode.com/problems/find-the-maximum-achievable-number/
fn the_maximum_achievable_x(num: i32, t: i32) -> i32 {
    num + (2 * t)
}

// https://leetcode.com/problems/concatenation-of-array/
fn get_concatenation(nums: Vec<i32>) -> Vec<i32> {
    let n = nums.len();
    let mut ans = vec![0; n * 2];

    for (i, val) in nums.iter().enumerate() {
        ans[i] = *val;
        ans[i + n] = *val;
    }

    ans
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn get_concatenation_ex1() {
        let result = get_concatenation([1, 2, 1].to_vec());
        assert_eq!(result, [1, 2, 1, 1, 2, 1].to_vec());
    }

    #[test]
    fn get_concatenation_ex2() {
        let result = get_concatenation([1, 3, 2, 1].to_vec());
        assert_eq!(result, [1, 3, 2, 1, 1, 3, 2, 1].to_vec());
    }

    #[test]
    fn the_maximum_achievable_x_ex1() {
        let result = the_maximum_achievable_x(4, 1);
        assert_eq!(result, 6);
    }

    #[test]
    fn the_maximum_achievable_x_ex2() {
        let result = the_maximum_achievable_x(3, 2);
        assert_eq!(result, 7);
    }
}
