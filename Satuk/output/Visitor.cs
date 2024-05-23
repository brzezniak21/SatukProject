namespace Satuk.output;
public class Visitor : SatukBaseVisitor<object>
{
    public override object VisitDisplay(SatukParser.DisplayContext context)
    {
        return VisitChildren(context);
    }

    public override object VisitPrint_content(SatukParser.Print_contentContext context)
    {
        var visitChildren =  VisitChildren(context);
        Console.WriteLine(visitChildren.ToString()?.Replace("\"","").Replace('\'','\''));
        return visitChildren;
    }

    public override object VisitProgram(SatukParser.ProgramContext context)
    {
        return VisitChildren(context);
    }

    public override object VisitOpArithm(SatukParser.OpArithmContext context)
    {
        const char COMMA = ',';
        
        var left = Visit(context.left) ?? context.left.GetText();
        var right = Visit(context.right) ?? context.right.GetText();
        var op = context.op.Text;
        
        string left_string = Convert.ToString(left);
        string right_string = Convert.ToString(right);
        
        if ((!left_string.Contains(COMMA) && right_string.Contains(COMMA)) || (left_string.Contains(COMMA) && !right_string.Contains(COMMA)))
        {
            throw new FormatException("Unable to make operation on different types");
        }
        
        
        if (op.Equals("*"))
        {
            return (!left_string.Contains(COMMA)) ? Convert.ToInt32(left_string) * Convert.ToInt32(right_string) : Convert.ToSingle(left_string) * Convert.ToSingle(right_string);
        }
        else if (op.Equals("/"))
        {
            return (!left_string.Contains(COMMA)) ? Convert.ToInt32(left_string) / Convert.ToInt32(right_string) : Convert.ToSingle(left_string) / Convert.ToSingle(right_string);
        }
        else if (op.Equals("%"))
        {
            return (!left_string.Contains(COMMA)) ? Convert.ToInt32(left_string) % Convert.ToInt32(right_string) : Convert.ToSingle(left_string) % Convert.ToSingle(right_string);
        }
        else if (op.Equals("+"))
        {
            return (!left_string.Contains(COMMA)) ? Convert.ToInt32(left_string) + Convert.ToInt32(right_string) : Convert.ToSingle(left_string) + Convert.ToSingle(right_string);
        }
        else if (op.Equals("-"))
        {
            return (!left_string.Contains(COMMA)) ? Convert.ToInt32(left_string) - Convert.ToInt32(right_string) : Convert.ToSingle(left_string) - Convert.ToSingle(right_string);
        }
        else
        {
            throw new Exception($"Invalid operator {op} in {nameof(VisitOpArithm)}");
        }
    }

    public override object VisitParenArithm(SatukParser.ParenArithmContext context)
    {
        return base.VisitParenArithm(context);
    }

    public override object VisitNumberArithm(SatukParser.NumberArithmContext context)
    {
        return context.GetText();
    }
}