﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._22_24._11._2023.DesignPatterns.Behavioral.Visitor.I
{
    internal class Client
    {
        public static void Execute()
        {
            var collection = new IElement[]
{
                new PlainText() {Text = "Plain"},
                new PlainText() { Text = "\n" },
                new BoldText() {Text = "Bold"},
                new PlainText() { Text = "\n" },
                new Hyperlink() {Text = "Hyperlink",  Link=@"https:\\some.url.pl"}
};

            var htmlVisitor = new HtmlVisitor();
            foreach (IElement item in collection)
            {
                item.Accept(htmlVisitor);
            }
            System.Console.WriteLine(htmlVisitor.ToString());
        }
    }
}
