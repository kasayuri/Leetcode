#https://leetcode.com/problems/evaluate-reverse-polish-notation/

#ATENCAO para usar / e não //, pois o // arredonda para baixo

class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        operands = ['+','-','*','/']
        stack = []

        for i in tokens:
            if i not in operands:
                stack.append(int(i))
            else:
                primeiro = stack.pop(-1)
                segundo = stack.pop(-1)
                #print(f'{segundo} {str(i)} {primeiro}')
                if i == '+':
                    stack.append(segundo + primeiro)
                elif i == '-':
                    stack.append(segundo - primeiro)
                elif i == '*':
                    stack.append(segundo * primeiro)
                elif i == '/':
                    stack.append(int(segundo / primeiro)) 

        return stack.pop(-1)