// https://leetcode.com/problems/find-the-maximum-achievable-number/

fn the_maximum_achievable_x(num: i32, t: i32) -> i32 {
    num + (2 * t)
}

#[cfg(test)]
mod tests {
    use super::*;

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
