namespace Altkom._22_24._11._2023.DesignPatterns.Behavioral.Visitor.II
{
    internal interface IVisitor
    {
        void Visit(Product product);
        void Visit(BoxedProduct boxedProduct);
    }
}