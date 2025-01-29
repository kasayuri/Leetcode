# 121. Best Time to Buy and Sell Stock - Easy

'''
You are given an array prices where prices[i] is the price of a given stock on the ith day.

You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
'''

'''
Example 1:

Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

Example 2:

Input: prices = [7,6,4,3,1]
Output: 0
Explanation: In this case, no transactions are done and the max profit = 0.
'''


# 2 pointers: iterar array buscando pelo menor valor (compra) e maior valor (venda) - Solução do neetcode (sliding window)

# recursivo buscando pelo menor valor
left, right = 0, 1
max_profit = 0
while right < len(prices):
    if prices[left] < prices[right]:
        max_profit = max(max_profit, prices[right] - prices[left]
    else:
        left = right
    right += 1
    
    return max_profit


#Falha no teste por causa de performance:
'''
max_profit = 0

for i in range(len(prices) - 1):
    for j in range(i + 1, len(prices)):
        max_profit = max(max_profit, prices[j] - prices[i])
            
return max_profit
'''


#Editorial:
'''
class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        min_price = float("inf")
        max_profit = 0
        for i in range(len(prices)):
            if prices[i] < min_price:
                min_price = prices[i]
            elif prices[i] - min_price > max_profit:
                max_profit = prices[i] - min_price

        return max_profit


        min_price = float('inf')
        max_profit = 0
        class Solution:
            def maxProfit(self, prices: List[int]) -> int:
                max_profit = 0
                for i in range(len(prices) - 1):
                    for j in range(i + 1, len(prices)):
                        profit = prices[j] - prices[i]
                        if profit > max_profit:
                            max_profit = profit

        return max_profit
'''