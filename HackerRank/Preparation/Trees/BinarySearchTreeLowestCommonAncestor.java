import java.util.*;
import java.io.*;

class Node {
    Node left;
    Node right;
    int data;
    
    Node(int data) {
        this.data = data;
        left = null;
        right = null;
    }
}

class Solution {

	/*
    class Node 
    	int data;
    	Node left;
    	Node right;
	*/
	public static Node lca(Node root, int v1, int v2) {
      	// Write your code here.
        Stack<Node> v1Path = new Stack<Node>();
        Stack<Node> v2Path = new Stack<Node>();

        getPath(root, v1, v1Path);
        getPath(root, v2, v2Path);

        Node next1 = v1Path.pop();
        Node next2 = v2Path.pop();

        while(true)
        {
            if(v1Path.empty()) {
                return next1;
            }

            if(v2Path.empty()) {
                return next2;
            }

            if(v1Path.peek().data != v2Path.peek().data)
            {
                return next1;
            }

            next1 = v1Path.pop();
            next2 = v2Path.pop();
        }
    }

    private static Boolean getPath(Node root, int v, Stack<Node> path)
    {
        if(root == null)
        {
            return false;
        }

        if(root.data == v)
        {
            path.push(root);
            return true;
        }

        Boolean left = getPath(root.left, v, path);

        if(left)
        {
            path.push(root);
            return true;
        }

        Boolean right = getPath(root.right, v, path);

        if(right) {
            path.push(root);
            return true;
        }

        return false;
    }

	public static Node insert(Node root, int data) {
        if(root == null) {
            return new Node(data);
        } else {
            Node cur;
            if(data <= root.data) {
                cur = insert(root.left, data);
                root.left = cur;
            } else {
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }
    }

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int t = scan.nextInt();
        Node root = null;
        while(t-- > 0) {
            int data = scan.nextInt();
            root = insert(root, data);
        }
      	int v1 = scan.nextInt();
      	int v2 = scan.nextInt();
        scan.close();
        Node ans = lca(root,v1,v2);
        System.out.println(ans.data);
    }	
}
