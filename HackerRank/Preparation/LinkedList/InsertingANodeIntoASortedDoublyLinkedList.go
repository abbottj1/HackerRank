package main

import (
    "bufio"
    "fmt"
    "io"
    "os"
    "strconv"
    "strings"
)

type DoublyLinkedListNode struct {
    data int32
    next *DoublyLinkedListNode
    prev *DoublyLinkedListNode
}

type DoublyLinkedList struct {
    head *DoublyLinkedListNode
    tail *DoublyLinkedListNode
}

func (doublyLinkedList *DoublyLinkedList) insertNodeIntoDoublyLinkedList(nodeData int32) {
    node := &DoublyLinkedListNode {
        next: nil,
        prev: nil,
        data: nodeData,
    }

    if doublyLinkedList.head == nil {
        doublyLinkedList.head = node
    } else {
        doublyLinkedList.tail.next = node
        node.prev = doublyLinkedList.tail
    }

    doublyLinkedList.tail = node
}

func printDoublyLinkedList(node *DoublyLinkedListNode, sep string, writer *bufio.Writer) {
    for node != nil {
        fmt.Fprintf(writer, "%d", node.data)

        node = node.next

        if node != nil {
            fmt.Fprintf(writer, sep)
        }
    }
}

// Complete the sortedInsert function below.

/*
 * For your reference:
 *
 * DoublyLinkedListNode {
 *     data int32
 *     next *DoublyLinkedListNode
 *     prev *DoublyLinkedListNode
 * }
 *
 */
func sortedInsert(head *DoublyLinkedListNode, data int32) *DoublyLinkedListNode {
    if data < head.data {
        node := &DoublyLinkedListNode {
            next: head,
            prev: head.prev,
            data: data,
        }

        head.prev = node

        return node
    }

    if head.next == nil {
        node := &DoublyLinkedListNode {
            data: data, 
            prev: head,
            next: nil,
        }

        head.next = node

        return head
    }

    head.next = sortedInsert(head.next, data)

    return head
}

func main() {
    reader := bufio.NewReaderSize(os.Stdin, 1024 * 1024)

    stdout, err := os.Create(os.Getenv("OUTPUT_PATH"))
    checkError(err)

    defer stdout.Close()

    writer := bufio.NewWriterSize(stdout, 1024 * 1024)

    tTemp, err := strconv.ParseInt(readLine(reader), 10, 64)
    checkError(err)
    t := int32(tTemp)

    for tItr := 0; tItr < int(t); tItr++ {
        llistCount, err := strconv.ParseInt(readLine(reader), 10, 64)
        checkError(err)

        llist := DoublyLinkedList{}
        for i := 0; i < int(llistCount); i++ {
            llistItemTemp, err := strconv.ParseInt(readLine(reader), 10, 64)
            checkError(err)
            llistItem := int32(llistItemTemp)
            llist.insertNodeIntoDoublyLinkedList(llistItem)
        }

        dataTemp, err := strconv.ParseInt(readLine(reader), 10, 64)
        checkError(err)
        data := int32(dataTemp)

        llist1 := sortedInsert(llist.head, data)

        printDoublyLinkedList(llist1, " ", writer)
        fmt.Fprintf(writer, "\n")
    }

    writer.Flush()
}

func readLine(reader *bufio.Reader) string {
    str, _, err := reader.ReadLine()
    if err == io.EOF {
        return ""
    }

    return strings.TrimRight(string(str), "\r\n")
}

func checkError(err error) {
    if err != nil {
        panic(err)
    }
}
