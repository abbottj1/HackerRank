using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    class SinglyLinkedListNode {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData) {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList() {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData) {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null) {
                this.head = node;
            } else {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter) {
        while (node != null) {
            textWriter.Write(node.data);

            node = node.next;

            if (node != null) {
                textWriter.Write(sep);
            }
        }
    }

    // Complete the findMergeNode function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static int findMergeNode(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {
        var head1Length = 0;
        var head2Length = 0;
        var headTemp = head1;

        while(headTemp.next != null)
        {
            head1Length++;
            headTemp = headTemp.next;
        }

        headTemp = head2;
        while(headTemp.next != null)
        {
            head2Length++;
            headTemp = headTemp.next;
        }

        var diff = Math.Abs(head1Length - head2Length);

        if (head1Length > head2Length)
        {
            while(diff > 0)
            {
                head1 = head1.next;
                diff--;
            }
        }
        else
        {
            while(diff > 0)
            {
                head2 = head2.next;
                diff--;
            }
        }

        do
        {
            if(head1 == head2)
            {
                return head1.data;
            }

            head1 = head1.next;
            head2 = head2.next;
        }while (head1 != null);

        return -1;
    }

    static void Main(string[] args) {
