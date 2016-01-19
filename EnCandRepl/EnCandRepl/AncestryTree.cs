using System;
using System.Collections.Generic;

namespace EnCandRepl
{
    class Node
    {
        public string Name { get; set; }
        public int Generation { get; set; }

        public string Mother { get; set; }
        public string Father { get; set; }

        public Node FatherNode { get; set; }
        public Node MotherNode { get; set; }

        [JsonConstructor]
        public Node(string name, int generation, string mother, string father)
        {
            Name = name;
            Generation = generation;
            Mother = mother;
            Father = father;
        }

        public Node(string name, int generation, Node mother, Node father)
        {
            Name = name;
            Generation = generation;
            MotherNode = mother;
            FatherNode = father;
            Mother = mother.Name;
            Father = father.Name;
        }
    }

    internal class AncestryTree
    {
        public Node root;

        public AncestryTree()
        {
            root = null;
        }

        public AncestryTree(Node Root)
        {
            root = Root;
        }

        public AncestryTree PopulateTree(Dictionary<string, Node> d)
        {
            //define array to construct nodes:
            Node[] nodeArray = new Node[int.Parse(d.Keys.Last()) + 1];
            //calculate the max generation in the pedigree tree
            //using the forumla 2^(gen)-1 = # of nodes:
            var max_generation = Math.Ceiling(Math.Log(nodeArray.Count() + 1, 2));
            for (int i = nodeArray.Count()-1; i >= 0; i--)
            {
                if (d.ContainsKey(i.ToString()))
                {
                    //create node from dictionary data

                }
            }
        }

        public List<Node> FlattenTree()
        {
            List<Node> nodelist = new List<Node>();
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while(q.Count > 0)
            {
                Node n = q.Dequeue();
                if (n!=null)
                {
                    Node k = new Node(n.Name, n.Generation, n.Mother, n.Father);
                    nodelist.Add(k);
                    q.Enqueue(n.FatherNode);
                    q.Enqueue(n.MotherNode);
                }
            }
            return nodelist;
        }
    }
}