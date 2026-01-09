namespace LeetCode;

// https://leetcode.com/problems/defanging-an-ip-address

public class IpAddressDefanger
{
    public string DefangIPaddr(string address) => address.Replace(".", "[.]");
}
