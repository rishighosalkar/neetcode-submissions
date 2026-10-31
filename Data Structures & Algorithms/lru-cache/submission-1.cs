public class DLLNode
{
    public DLLNode prev;
    public DLLNode next;
    public int val, key;
    public DLLNode(int key, int val)
    {
        prev = null;
        next = null;
        this.val = val;
        this.key = key;
    }
}

public class LRUCache {
    Dictionary<int, DLLNode> map = new Dictionary<int, DLLNode>();
    DLLNode head, tail;
    int size;
    public LRUCache(int capacity) {
        size = capacity;
        head = new DLLNode(0, 0);
        tail = new DLLNode(0, 0);
        head.next = tail;
        tail.prev = head;
    }
    
    public void MoveToFront(DLLNode node)
    {
        DLLNode prev = node.prev;
        DLLNode next = node.next;
        prev.next = node.next;
        next.prev = prev;

        DLLNode curr = head.next;
        node.next = curr;
        head.next = node;
        curr.prev = node;
        node.prev = head;
    }

    public void RemoveFromEnd()
    {
        DLLNode node = tail.prev;
        DLLNode prev = node.prev;
        prev.next = tail;
        tail.prev = prev;
        map.Remove(node.key);
        size++;
    }

    public int Get(int key) {
        
        if(!map.ContainsKey(key))
            return -1;
        DLLNode node = map[key];
        MoveToFront(node);
        return node.val;
    }
    
    public void Put(int key, int value) {
        
        if(map.ContainsKey(key))
        {
            DLLNode node = map[key];
            node.val = value;
            MoveToFront(node);
            map[key] = node;
            // continue;
        }
        else{
            if(size == 0)
                RemoveFromEnd();
            size--;
            DLLNode newNode = new DLLNode(key, value);
            DLLNode curr = head.next;
            newNode.next = curr;
            head.next = newNode;
            curr.prev = newNode;
            newNode.prev = head;
            map.Add(key, newNode);
        }
    }
}
//1, 10
// head <-> 1 <-> 10 <-> tail
//