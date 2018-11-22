/* Hidden stub code will pass a root argument to the function below. Complete the function to solve the challenge. Hint: you may want to write one or more helper functions.  

The Node class is defined as follows:
    class Node {
        int data;
        Node left;
        Node right;
     }
*/
    boolean checkBST(Node root) {
        
        //Create a stack and add -1 as a base case
        Stack<Integer> stack = new Stack<Integer>();
        stack.push(-1);
        
        return (checkBST(root, stack));
        
    }

    boolean checkBST(Node root, Stack<Integer> stack) {
        
        if(root == null) {
            return true;
        }
        
        boolean left = checkBST(root.left, stack);
        
        if(!left) {
            return false;
        }
        
        if(stack.peek() >= root.data) {
            return false;
        }
        else {
            stack.push(root.data);
        }
        
        return (checkBST(root.right, stack));
        
    }
