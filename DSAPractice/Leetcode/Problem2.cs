using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSAPractice.Leetcode
{
    public class Problem2
    {
        private long[] balance;

        public Problem2(long[] balance) {
            this.balance = balance;
        }

        private bool isValid(int account) {
            return account >= 1 && account <= balance.Length;
        }
        
        public bool Transfer(int account1, int account2, long money) {
            if(!isValid(account1) || !isValid(account2)) {
                return false;
            }

            if(balance[account1 - 1] < money) {
                return false;
            }

            balance[account1 - 1] -= money;
            balance[account2 - 1] += money;
            return true;
        }
        
        public bool Deposit(int account, long money) {
            if(!isValid(account)) {
                return false;
            }

            balance[account - 1] += money;
            return true;
        }
        
        public bool Withdraw(int account, long money) {
            if(!isValid(account)) {
                return false;
            }

            if(balance[account - 1] < money) {
                return false;
            }

            balance[account - 1] -= money;
            return true;
        }
    }
}

/**
 * Your Bank object will be instantiated and called as such:
 * Bank obj = new Bank(balance);
 * bool param_1 = obj.Transfer(account1,account2,money);
 * bool param_2 = obj.Deposit(account,money);
 * bool param_3 = obj.Withdraw(account,money);
 */