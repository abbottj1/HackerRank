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

    private static class NodeInfo {
        Node node;
        int position;

        NodeInfo(Node node, int position) {
            this.node = node;
            this.position = position;
        }
    }
	/* 
    
    class Node 
    	int data;
    	Node left;
    	Node right;
	*/
	public static void topView(Node root) {
        Queue<NodeInfo> queue = new LinkedList<NodeInfo>();
        Map<Integer, Node> treeMap = new TreeMap<Integer, Node>();

        queue.add(new NodeInfo(root, 0));

        while(!queue.isEmpty()) {
            NodeInfo currentNodeInfo = queue.poll();

            if (!treeMap.containsKey(currentNodeInfo.position)) {
                treeMap.put(currentNodeInfo.position, currentNodeInfo.node);
            }

            if (currentNodeInfo.node.left != null) {
                queue.add(new NodeInfo(currentNodeInfo.node.left, currentNodeInfo.position - 1));
            }

            if (currentNodeInfo.node.right != null) {
                queue.add(new NodeInfo(currentNodeInfo.node.right, currentNodeInfo.position + 1));
            }
        }

        for (Map.Entry<Integer, Node> entry : treeMap.entrySet()) { 
            System.out.print(entry.getValue().data + " "); 
        } 
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
        scan.close();
        topView(root);
    }	
}
