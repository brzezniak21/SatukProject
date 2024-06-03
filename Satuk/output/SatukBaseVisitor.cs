//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/Msi/RiderProjects/Satuk/Satuk/Satuk.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ISatukVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class SatukBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, ISatukVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.program"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProgram([NotNull] SatukParser.ProgramContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.prog"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProg([NotNull] SatukParser.ProgContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>display</c>
	/// labeled alternative in <see cref="SatukParser.print"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDisplay([NotNull] SatukParser.DisplayContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.assignment"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAssignment([NotNull] SatukParser.AssignmentContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>boolAss</c>
	/// labeled alternative in <see cref="SatukParser.assign_bool"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBoolAss([NotNull] SatukParser.BoolAssContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>boolLogAss</c>
	/// labeled alternative in <see cref="SatukParser.assign_bool_logical"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBoolLogAss([NotNull] SatukParser.BoolLogAssContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>boolDynAss</c>
	/// labeled alternative in <see cref="SatukParser.assign_bool_dynamic"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBoolDynAss([NotNull] SatukParser.BoolDynAssContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>stringAss</c>
	/// labeled alternative in <see cref="SatukParser.assign_string"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStringAss([NotNull] SatukParser.StringAssContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>stringDynAss</c>
	/// labeled alternative in <see cref="SatukParser.assign_string_dynamic"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStringDynAss([NotNull] SatukParser.StringDynAssContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>charAss</c>
	/// labeled alternative in <see cref="SatukParser.assign_char"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCharAss([NotNull] SatukParser.CharAssContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>charDynAss</c>
	/// labeled alternative in <see cref="SatukParser.assign_char_dynamic"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCharDynAss([NotNull] SatukParser.CharDynAssContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>intConstAss</c>
	/// labeled alternative in <see cref="SatukParser.assign_int_constant"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIntConstAss([NotNull] SatukParser.IntConstAssContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>intArAss</c>
	/// labeled alternative in <see cref="SatukParser.assign_int_ar"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIntArAss([NotNull] SatukParser.IntArAssContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>intDynAss</c>
	/// labeled alternative in <see cref="SatukParser.assign_int_dynamic"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIntDynAss([NotNull] SatukParser.IntDynAssContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>floatConstAss</c>
	/// labeled alternative in <see cref="SatukParser.assign_float_constant"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFloatConstAss([NotNull] SatukParser.FloatConstAssContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>floatDynAss</c>
	/// labeled alternative in <see cref="SatukParser.assign_float_dynamic"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFloatDynAss([NotNull] SatukParser.FloatDynAssContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>floatArAss</c>
	/// labeled alternative in <see cref="SatukParser.assign_float_ar"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFloatArAss([NotNull] SatukParser.FloatArAssContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>classAss</c>
	/// labeled alternative in <see cref="SatukParser.assignment_class"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitClassAss([NotNull] SatukParser.ClassAssContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.assignment_function"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAssignment_function([NotNull] SatukParser.Assignment_functionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>numberArithm</c>
	/// labeled alternative in <see cref="SatukParser.arithmetics"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNumberArithm([NotNull] SatukParser.NumberArithmContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>parenArithm</c>
	/// labeled alternative in <see cref="SatukParser.arithmetics"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitParenArithm([NotNull] SatukParser.ParenArithmContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>opArithm</c>
	/// labeled alternative in <see cref="SatukParser.arithmetics"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOpArithm([NotNull] SatukParser.OpArithmContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>opArithmInt</c>
	/// labeled alternative in <see cref="SatukParser.arithmetics_int"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOpArithmInt([NotNull] SatukParser.OpArithmIntContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>opArithmFloat</c>
	/// labeled alternative in <see cref="SatukParser.arithmetics_float"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOpArithmFloat([NotNull] SatukParser.OpArithmFloatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.mutators"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMutators([NotNull] SatukParser.MutatorsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>incInt</c>
	/// labeled alternative in <see cref="SatukParser.int_inc"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIncInt([NotNull] SatukParser.IncIntContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>incFloat</c>
	/// labeled alternative in <see cref="SatukParser.float_inc"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIncFloat([NotNull] SatukParser.IncFloatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>decInt</c>
	/// labeled alternative in <see cref="SatukParser.int_dec"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDecInt([NotNull] SatukParser.DecIntContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>decFloat</c>
	/// labeled alternative in <see cref="SatukParser.float_dec"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDecFloat([NotNull] SatukParser.DecFloatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>incVar</c>
	/// labeled alternative in <see cref="SatukParser.variable_inc"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIncVar([NotNull] SatukParser.IncVarContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>decVar</c>
	/// labeled alternative in <see cref="SatukParser.variable_dec"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDecVar([NotNull] SatukParser.DecVarContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.logical_instructions"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLogical_instructions([NotNull] SatukParser.Logical_instructionsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>logBool</c>
	/// labeled alternative in <see cref="SatukParser.logical_bool"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLogBool([NotNull] SatukParser.LogBoolContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>logNum</c>
	/// labeled alternative in <see cref="SatukParser.logical_numeric"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLogNum([NotNull] SatukParser.LogNumContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>logText</c>
	/// labeled alternative in <see cref="SatukParser.logical_text"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLogText([NotNull] SatukParser.LogTextContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>logVar</c>
	/// labeled alternative in <see cref="SatukParser.logical_var"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLogVar([NotNull] SatukParser.LogVarContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.if_statement"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIf_statement([NotNull] SatukParser.If_statementContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.loop"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLoop([NotNull] SatukParser.LoopContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.print_content"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPrint_content([NotNull] SatukParser.Print_contentContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.functions"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFunctions([NotNull] SatukParser.FunctionsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.function"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFunction([NotNull] SatukParser.FunctionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>construct</c>
	/// labeled alternative in <see cref="SatukParser.constructor"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitConstruct([NotNull] SatukParser.ConstructContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.return"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitReturn([NotNull] SatukParser.ReturnContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.class"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitClass([NotNull] SatukParser.ClassContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.execute_function"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExecute_function([NotNull] SatukParser.Execute_functionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>funcVoid</c>
	/// labeled alternative in <see cref="SatukParser.void_function"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFuncVoid([NotNull] SatukParser.FuncVoidContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>funcInt</c>
	/// labeled alternative in <see cref="SatukParser.int_function"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFuncInt([NotNull] SatukParser.FuncIntContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>funcFloat</c>
	/// labeled alternative in <see cref="SatukParser.float_function"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFuncFloat([NotNull] SatukParser.FuncFloatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>funcString</c>
	/// labeled alternative in <see cref="SatukParser.string_function"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFuncString([NotNull] SatukParser.FuncStringContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>funcChar</c>
	/// labeled alternative in <see cref="SatukParser.char_function"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFuncChar([NotNull] SatukParser.FuncCharContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>funcBool</c>
	/// labeled alternative in <see cref="SatukParser.bool_function"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFuncBool([NotNull] SatukParser.FuncBoolContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>funcVar</c>
	/// labeled alternative in <see cref="SatukParser.variable_function"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFuncVar([NotNull] SatukParser.FuncVarContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.void_return"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitVoid_return([NotNull] SatukParser.Void_returnContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>retInt</c>
	/// labeled alternative in <see cref="SatukParser.int_return"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRetInt([NotNull] SatukParser.RetIntContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>retFloat</c>
	/// labeled alternative in <see cref="SatukParser.float_return"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRetFloat([NotNull] SatukParser.RetFloatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>retString</c>
	/// labeled alternative in <see cref="SatukParser.string_return"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRetString([NotNull] SatukParser.RetStringContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>retChar</c>
	/// labeled alternative in <see cref="SatukParser.char_return"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRetChar([NotNull] SatukParser.RetCharContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>retBool</c>
	/// labeled alternative in <see cref="SatukParser.bool_return"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRetBool([NotNull] SatukParser.RetBoolContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>retVar</c>
	/// labeled alternative in <see cref="SatukParser.variable_return"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRetVar([NotNull] SatukParser.RetVarContext context) { return VisitChildren(context); }
}
