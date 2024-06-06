using System.Data;
using Antlr4.Runtime.Tree;

namespace Satuk.output;

public class Visitor : SatukBaseVisitor<object>
{
    private Dictionary<string, object> variables = new();
    private Dictionary<string, string> variableTypes = new();


    public override object VisitStringAss(SatukParser.StringAssContext context)
    {
        if (variables.ContainsKey(context.VARIABLE().GetText()))
            throw new DuplicateNameException($"Duplicate declaration of variable named {context.VARIABLE().GetText()}");
        else
        {
            variableTypes.Add(context.VARIABLE().GetText(), "string");
            variables.Add(context.VARIABLE().GetText(), context.GetText().Contains('=') ? context.STRING().GetText() : string.Empty);
        }

        return null;
    }

  /*  public override object VisitBoolLogAss(SatukParser.BoolLogAssContext context)
    {
        if (!variables.ContainsKey(context.VARIABLE().GetText()))
            throw new NotImplementedException($"No variable named {context.VARIABLE().GetText()}");
        else
        {
            variables[context.VARIABLE().GetText()] = Visit(context.expr);
        }

        return null;
    }*/

    public override object VisitDisplay(SatukParser.DisplayContext context)
    {
        return VisitChildren(context);
    }

    public override object VisitPrint_logicalInstructions(SatukParser.Print_logicalInstructionsContext context)
    {
        var visitChildren = VisitChildren(context) ?? context.GetText();
        Console.WriteLine(Convert.ToString(visitChildren));
        return null;
    }

    public override object VisitPrint_variable(SatukParser.Print_variableContext context)
    {
        if (variables.ContainsKey(context.VARIABLE().GetText()))
        {
            Console.WriteLine(variables[context.VARIABLE().GetText()].ToString().Replace("\"", ""));
        }
        else throw new NotImplementedException($"Variable {context.VARIABLE().GetText()} does not exist");

        return null;
    }

    public override object VisitPrint_int(SatukParser.Print_intContext context)
    {
        Console.WriteLine(context.INT().GetText());
        return null;
    }

    public override object VisitPrint_float(SatukParser.Print_floatContext context)
    {
        Console.WriteLine(context.FLOAT().GetText());
        return null;
    }

    public override object VisitPrint_bool(SatukParser.Print_boolContext context)
    {
        Console.WriteLine(context.BOOL().GetText());
        return null;
    }

    public override object VisitPrint_char(SatukParser.Print_charContext context)
    {
        Console.WriteLine(context.CHAR().GetText().Replace("\'", string.Empty));
        return null;
    }

    public override object VisitPrint_arithmetics(SatukParser.Print_arithmeticsContext context)
    {
        var visitChildren = VisitChildren(context) ?? context.GetText();
        Console.WriteLine(visitChildren.ToString()?.Replace("\"", "").Replace('\'', '\''));
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
        if (variables.ContainsKey(left_string)) left_string = Convert.ToString(variables[left_string]);
        if (variables.ContainsKey(right_string)) right_string = Convert.ToString(variables[right_string]);

        if ((!left_string.Contains(COMMA) && right_string.Contains(COMMA)) ||
            (left_string.Contains(COMMA) && !right_string.Contains(COMMA)))
        {
            throw new FormatException("Unable to make operation on different types");
        }


        if (op.Equals("*"))
        {
            return (!left_string.Contains(COMMA))
                ? Convert.ToInt32(left_string) * Convert.ToInt32(right_string)
                : Convert.ToSingle(left_string) * Convert.ToSingle(right_string);
        }
        else if (op.Equals("/"))
        {
            return (!left_string.Contains(COMMA))
                ? Convert.ToInt32(left_string) / Convert.ToInt32(right_string)
                : Convert.ToSingle(left_string) / Convert.ToSingle(right_string);
        }
        else if (op.Equals("%"))
        {
            return (!left_string.Contains(COMMA))
                ? Convert.ToInt32(left_string) % Convert.ToInt32(right_string)
                : Convert.ToSingle(left_string) % Convert.ToSingle(right_string);
        }
        else if (op.Equals("+"))
        {
            return (!left_string.Contains(COMMA))
                ? Convert.ToInt32(left_string) + Convert.ToInt32(right_string)
                : Convert.ToSingle(left_string) + Convert.ToSingle(right_string);
        }
        else if (op.Equals("-"))
        {
            return (!left_string.Contains(COMMA))
                ? Convert.ToInt32(left_string) - Convert.ToInt32(right_string)
                : Convert.ToSingle(left_string) - Convert.ToSingle(right_string);
        }
        else
        {
            throw new Exception($"Invalid operator {op} in {nameof(VisitOpArithm)}");
        }
    }

    public override object VisitNumberArithm(SatukParser.NumberArithmContext context)
    {
        return context.GetText();
    }

    public override object VisitDisplayString(SatukParser.DisplayStringContext context)
    {
        Console.WriteLine(context.STRING().GetText().Replace("\"", string.Empty));

        return VisitChildren(context);
    }
    
    

    public override object VisitIntConstAss(SatukParser.IntConstAssContext context)
    {
        if (variables.ContainsKey(context.VARIABLE().GetText()))
            throw new DuplicateNameException($"Duplicate declaration of variable named {context.VARIABLE().GetText()}");
        else
        {
            variableTypes.Add(context.VARIABLE().GetText(), "int");
            variables.Add(context.VARIABLE().GetText(), context.GetText().Contains('=') ? Visit(context.expr) : 0);
        }

        return null;
    }
    
    public override object VisitBoolAss(SatukParser.BoolAssContext context)
    {
        if (variables.ContainsKey(context.VARIABLE().GetText()))
            throw new DuplicateNameException($"Duplicate declaration of variable named {context.VARIABLE().GetText()}");
        else
        {
            variableTypes.Add(context.VARIABLE().GetText(), "bool");
            variables.Add(context.VARIABLE().GetText(), context.GetText().Contains('=') ? Visit(context.expr) : false);
        }

        return context.VARIABLE().GetText();
    }

    public override object VisitVarLogical(SatukParser.VarLogicalContext context)
    {
        if (context.GetText() == "true" || context.GetText() == "false") return Convert.ToBoolean(context.BOOL().GetText());
        else return context.GetText();
    }

    public override object VisitCharAss(SatukParser.CharAssContext context)
    {
        if (variables.ContainsKey(context.VARIABLE().GetText()))
            throw new DuplicateNameException($"Duplicate declaration of variable named {context.VARIABLE().GetText()}");
        else
        {
            variableTypes.Add(context.VARIABLE().GetText(), "char");
            variables.Add(context.VARIABLE().GetText(), context.GetText().Contains('=') ? context.CHAR().GetText() : default(char));
        }

        return null;
    }

    public override object VisitFloatConstAss(SatukParser.FloatConstAssContext context)
    {
        if (variables.ContainsKey(context.VARIABLE().GetText()))
            throw new DuplicateNameException($"Duplicate declaration of variable named {context.VARIABLE().GetText()}");
        else
        {
            variableTypes.Add(context.VARIABLE().GetText(), "float");
            variables.Add(context.VARIABLE().GetText(), context.GetText().Contains('=') ? Visit(context.expr) : 0.0);
        }

        return null;
    }

    public override object VisitArAss(SatukParser.ArAssContext context)
    {
        if (!variables.ContainsKey(context.VARIABLE().GetText()))
            throw new NotImplementedException($"No variable named {context.VARIABLE().GetText()}");
        else
        {
            variables[context.VARIABLE().GetText()] = Visit(context.expr);
        }

        return null;
    }

    public override object VisitVarDynAss(SatukParser.VarDynAssContext context)
    {
        string variableName = context.VARIABLE().GetText();
        if (!variables.ContainsKey(variableName))
            throw new NotImplementedException($"No variable named {variableName}");
        else
        {
            if (variableTypes[variableName] == "float")
                variables[variableName] = Convert.ToSingle(context.FLOAT().GetText());
            else if (variableTypes[variableName] == "int")
                variables[variableName] = Convert.ToInt32(context.INT().GetText());
            else if (variableTypes[variableName] == "bool")
                variables[variableName] = Convert.ToBoolean(context.BOOL().GetText());
            else if (variableTypes[variableName] == "string")
                variables[variableName] = context.STRING().GetText();
            else if (variableTypes[variableName] == "char")
                variables[variableName] = Convert.ToChar(context.CHAR().GetText());
            else throw new TypeUnloadedException($"Unknown type {variableTypes[variableName]}");
        }

        return null;
    }

    public override object VisitOpLogical(SatukParser.OpLogicalContext context)
    {
        var left = Visit(context.left) ?? context.left.GetText();
        var right = Visit(context.right) ?? context.right.GetText();
        var op = context.op.Text;

        string left_string = Convert.ToString(left);
        string right_string = Convert.ToString(right);
        string left_string_value = string.Empty;
        string right_string_value = string.Empty;

        if (variables.ContainsKey(left_string)) left_string_value = Convert.ToString(variables[left_string]);
        if (variables.ContainsKey(right_string)) right_string_value = Convert.ToString(variables[right_string]);
        
        
        if (op.Equals("=="))
            return left_string == right_string;
        else if (op.Equals("!="))
            return left_string != right_string;
        else if (op.Equals(">="))
        {
            if (variableTypes.ContainsKey(left_string) && variableTypes.ContainsKey(right_string))
            {
                if (variableTypes[left_string] == "float" && variableTypes[right_string] == "float")
                {
                    return Convert.ToSingle(variables[left_string]) >= Convert.ToSingle(variables[right_string]);
                }
                else if (variableTypes[left_string] == "int" && variableTypes[right_string] == "int")
                {
                    return Convert.ToInt32(variables[left_string]) >= Convert.ToInt32(variables[right_string]);
                }
                else throw new InvalidDataException("Invalid operation");
            }
            else if (variableTypes.ContainsKey(left_string) && !variableTypes.ContainsKey(right_string))
            {
                if (variableTypes[left_string] == "float" && float.TryParse(right_string, out float floatValue))
                {
                    return Convert.ToSingle(variables[left_string]) >= floatValue;
                }
                else if (variableTypes[left_string] == "int" && int.TryParse(right_string, out int intValue))
                {
                    return Convert.ToInt32(variables[left_string]) >= intValue;
                }
                else throw new InvalidDataException("Invalid operation");
            }
            else if (!variableTypes.ContainsKey(left_string) && variableTypes.ContainsKey(right_string))
            {
                if (variableTypes[right_string] == "float" && float.TryParse(left_string, out float floatValue))
                {
                    return floatValue >= Convert.ToSingle(variables[right_string]);
                }
                else if (variableTypes[left_string] == "int" && int.TryParse(right_string, out int intValue))
                {
                    return intValue >= Convert.ToInt32(variables[left_string]);
                }
                else throw new InvalidDataException("Invalid operation");
            }
            else
            {
                if (float.TryParse(left_string, out float floatValueLeft) &&
                    float.TryParse(left_string, out float floatValueRight))
                {
                    return floatValueLeft >= floatValueRight;
                }
                else if (int.TryParse(left_string, out int intValueLeft) &&
                         int.TryParse(left_string, out int intValueRight))
                {
                    return intValueLeft >= intValueRight;
                }
                else throw new InvalidDataException("Invalid operation");
            }
        }
        else if (op.Equals("<="))
        {
            if (variableTypes.ContainsKey(left_string) && variableTypes.ContainsKey(right_string))
            {
                if (variableTypes[left_string] == "float" && variableTypes[right_string] == "float")
                {
                    return Convert.ToSingle(variables[left_string]) <= Convert.ToSingle(variables[right_string]);
                }
                else if (variableTypes[left_string] == "int" && variableTypes[right_string] == "int")
                {
                    return Convert.ToInt32(variables[left_string]) <= Convert.ToInt32(variables[right_string]);
                }
                else throw new InvalidDataException("Invalid operation");
            }
            else if (variableTypes.ContainsKey(left_string) && !variableTypes.ContainsKey(right_string))
            {
                if (variableTypes[left_string] == "float" && float.TryParse(right_string, out float floatValue))
                {
                    return Convert.ToSingle(variables[left_string]) <= floatValue;
                }
                else if (variableTypes[left_string] == "int" && int.TryParse(right_string, out int intValue))
                {
                    return Convert.ToInt32(variables[left_string]) <= intValue;
                }
                else throw new InvalidDataException("Invalid operation");
            }
            else if (!variableTypes.ContainsKey(left_string) && variableTypes.ContainsKey(right_string))
            {
                if (variableTypes[right_string] == "float" && float.TryParse(left_string, out float floatValue))
                {
                    return floatValue <= Convert.ToSingle(variables[right_string]);
                }
                else if (variableTypes[left_string] == "int" && int.TryParse(right_string, out int intValue))
                {
                    return intValue <= Convert.ToInt32(variables[left_string]);
                }
                else throw new InvalidDataException("Invalid operation");
            }
            else
            {
                if (float.TryParse(left_string, out float floatValueLeft) &&
                    float.TryParse(left_string, out float floatValueRight))
                {
                    return floatValueLeft <= floatValueRight;
                }
                else if (int.TryParse(left_string, out int intValueLeft) &&
                         int.TryParse(left_string, out int intValueRight))
                {
                    return intValueLeft <= intValueRight;
                }
                else throw new InvalidDataException("Invalid operation");
            }
        }
        else if (op.Equals(">"))
        {
            if (variableTypes.ContainsKey(left_string) && variableTypes.ContainsKey(right_string))
            {
                if (variableTypes[left_string] == "float" && variableTypes[right_string] == "float")
                {
                    return Convert.ToSingle(variables[left_string]) > Convert.ToSingle(variables[right_string]);
                }
                else if (variableTypes[left_string] == "int" && variableTypes[right_string] == "int")
                {
                    return Convert.ToInt32(variables[left_string]) > Convert.ToInt32(variables[right_string]);
                }
                else throw new InvalidDataException("Invalid operation");
            }
            else if (variableTypes.ContainsKey(left_string) && !variableTypes.ContainsKey(right_string))
            {
                if (variableTypes[left_string] == "float" && float.TryParse(right_string, out float floatValue))
                {
                    return Convert.ToSingle(variables[left_string]) > floatValue;
                }
                else if (variableTypes[left_string] == "int" && int.TryParse(right_string, out int intValue))
                {
                    return Convert.ToInt32(variables[left_string]) > intValue;
                }
                else throw new InvalidDataException("Invalid operation");
            }
            else if (!variableTypes.ContainsKey(left_string) && variableTypes.ContainsKey(right_string))
            {
                if (variableTypes[right_string] == "float" && float.TryParse(left_string, out float floatValue))
                {
                    return floatValue > Convert.ToSingle(variables[right_string]);
                }
                else if (variableTypes[left_string] == "int" && int.TryParse(right_string, out int intValue))
                {
                    return intValue > Convert.ToInt32(variables[left_string]);
                }
                else throw new InvalidDataException("Invalid operation");
            }
            else
            {
                if (float.TryParse(left_string, out float floatValueLeft) &&
                    float.TryParse(left_string, out float floatValueRight))
                {
                    return floatValueLeft > floatValueRight;
                }
                else if (int.TryParse(left_string, out int intValueLeft) &&
                         int.TryParse(left_string, out int intValueRight))
                {
                    return intValueLeft > intValueRight;
                }
                else throw new InvalidDataException("Invalid operation");
            }
        }
        else if (op.Equals("<"))
        {
            if (variableTypes.ContainsKey(left_string) && variableTypes.ContainsKey(right_string))
            {
                if (variableTypes[left_string] == "float" && variableTypes[right_string] == "float")
                {
                    return Convert.ToSingle(variables[left_string]) < Convert.ToSingle(variables[right_string]);
                }
                else if (variableTypes[left_string] == "int" && variableTypes[right_string] == "int")
                {
                    return Convert.ToInt32(variables[left_string]) < Convert.ToInt32(variables[right_string]);
                }
                else throw new InvalidDataException("Invalid operation");
            }
            else if (variableTypes.ContainsKey(left_string) && !variableTypes.ContainsKey(right_string))
            {
                if (variableTypes[left_string] == "float" && float.TryParse(right_string, out float floatValue))
                {
                    return Convert.ToSingle(variables[left_string]) < floatValue;
                }
                else if (variableTypes[left_string] == "int" && int.TryParse(right_string, out int intValue))
                {
                    return Convert.ToInt32(variables[left_string]) < intValue;
                }
                else throw new InvalidDataException("Invalid operation");
            }
            else if (!variableTypes.ContainsKey(left_string) && variableTypes.ContainsKey(right_string))
            {
                if (variableTypes[right_string] == "float" && float.TryParse(left_string, out float floatValue))
                {
                    return floatValue < Convert.ToSingle(variables[right_string]);
                }
                else if (variableTypes[left_string] == "int" && int.TryParse(right_string, out int intValue))
                {
                    return intValue < Convert.ToInt32(variables[left_string]);
                }
                else throw new InvalidDataException("Invalid operation");
            }
            else
            {
                if (float.TryParse(left_string, out float floatValueLeft) &&
                    float.TryParse(left_string, out float floatValueRight))
                {
                    return floatValueLeft < floatValueRight;
                }
                else if (int.TryParse(left_string, out int intValueLeft) &&
                         int.TryParse(left_string, out int intValueRight))
                {
                    return intValueLeft < intValueRight;
                }
                else throw new InvalidDataException("Invalid operation");
            }
        }
        else if (op.Equals("||"))
            return ((left_string_value==string.Empty) ? Convert.ToBoolean(left_string) : Convert.ToBoolean(left_string_value)) || ((right_string_value==string.Empty) ? Convert.ToBoolean(right_string) : Convert.ToBoolean(right_string_value));
        else if (op.Equals("&&"))
            return ((left_string_value==string.Empty) ? Convert.ToBoolean(left_string) : Convert.ToBoolean(left_string_value)) && ((right_string_value==string.Empty) ? Convert.ToBoolean(right_string) : Convert.ToBoolean(right_string_value));
        else throw new InvalidOperationException("Invalid logical operator");
    }

    public override object VisitNotLogical(SatukParser.NotLogicalContext context)
    {
        if(variables.ContainsKey(context.expr.GetText()))
            return !Convert.ToBoolean(variables[context.expr.GetText()]);
        else return !Convert.ToBoolean(Visit(context.expr));
    }

    public override object VisitIncVar(SatukParser.IncVarContext context)
    {
        var var = context.VARIABLE().GetText();
        if(variables.ContainsKey(var))
            if (variableTypes[var] == "int")
                return int.TryParse(variables[var].ToString(), out int value)
                    ? variables[var] = ++value : null;
            else if (variableTypes[var] == "float")
                return float.TryParse(variables[var].ToString(), out float value)
                    ? variables[var] = ++value
                    : null;
            else 
                throw new ArgumentException($"Cant increment type {variableTypes[var]}");
        else 
            throw new ArgumentException($"No variable named {var}");
    }

    public override object VisitDecVar(SatukParser.DecVarContext context)
    {
        var var = context.VARIABLE().GetText();
        if(variables.ContainsKey(var))
            if (variableTypes[var] == "int")
                return int.TryParse(variables[var].ToString(), out int value)
                    ? variables[var] = --value : null;
            else if (variableTypes[var] == "float")
                return float.TryParse(variables[var].ToString(), out float value)
                    ? variables[var] = --value
                    : null;
            else 
                throw new ArgumentException($"Cant decrement type {variableTypes[var]}");
        else 
            throw new ArgumentException($"No variable named {var}");
    }

    public override object VisitIfStatement(SatukParser.IfStatementContext context)
    {
        var ifcondition = Visit(context.ifcondition);

        bool condition;

        if(ifcondition is string v)
        {
            condition = (bool)variables[v];
        }
        else{
            condition = (bool)ifcondition;
        }
        
        bool temp;

        if (condition)
        {
            Visit(context.ifprog);
            return true;
        }
        else if(context.elif is not null){
            temp = (bool)Visit(context.elif);
            if(temp){
                return true;
            }
        }
        if (context.@else is not null){
            return Visit(context.@else);
        }
        return false;
    }
    public override object VisitElifStatement(SatukParser.ElifStatementContext context)
    {
        var ifcondition = Visit(context.elifcondition);

        bool condition;

        if(ifcondition is string v)
        {
            condition = (bool)variables[v];
        }
        else{
            condition = (bool)ifcondition;
        }


        if (condition)
        {
            Visit(context.elifprog);
            return true;
        }
        else if(context.elif is not null){
            return Visit(context.elif);
        }
        else{
            return false;
        }
        
    }
    public override object VisitElseStatement(SatukParser.ElseStatementContext context)
    {
        Visit(context.elseprog);
        return true;
    }

    public override object VisitLoopStatement(SatukParser.LoopStatementContext context)
    {
        
        while (true)
        {
            var loopcondition = Visit(context.loopcondition);

            bool condition;

            if(loopcondition is string v)
            {
                condition = (bool)variables[v];
            }
            else{
                condition = (bool)loopcondition;
            }
            
            if (condition)
            {
                Visit(context.loopprog);
            }
            else
            {
                break;
            }
        }

        return true;
    }
}
