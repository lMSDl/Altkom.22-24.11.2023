namespace Altkom._22_24._11._2023.DesignPatterns.Behavioral.Visitor.I
{
    internal interface IVisitor
    {
        void Visit(PlainText element);
        void Visit(BoldText element);
        void Visit(Hyperlink element);
    }
}